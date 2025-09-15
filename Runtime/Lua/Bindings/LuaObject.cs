// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using Luny.Core;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace Luny
{
	public sealed partial class LuaObject<T> : ILuaObject<T> where T : class
	{
		public T Instance { get; }
		public Type BindType => typeof(T);
		public static implicit operator LuaValue(LuaObject<T> obj) => new(obj);

		public static LuaValue Bind([NotNull] T instance) => new LuaObject<T>(instance);

		private LuaObject(T instance)
		{
			if (instance == null)
				throw new ArgumentNullException(nameof(instance), "cannot bind null reference");

			Instance = instance;
		}

		public override String ToString() => Instance != null ? Instance.ToString() : $"LuaObject<{BindType.FullName}>(null)";
	}

	public sealed partial class LuaObject<T>
	{
		private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>
		{
			var luaObject = context.GetArgument<LuaObject<T>>(0);
			var key = context.GetArgument(1);

			if (luaObject.Instance is ILuaIndexable indexable)
			{
				if (key.Type == LuaValueType.Number)
				{
					if (indexable.TryGetLuaValue(key.Read<Int32>(), out var value, context.GetObjectFactory()))
						return new ValueTask<Int32>(context.Return(value));
				}
				else if (key.Type == LuaValueType.String)
				{
					if (indexable.TryGetLuaValue(key.Read<String>(), out var value, context.GetObjectFactory()))
						return new ValueTask<Int32>(context.Return(value));
				}
			}
			else
			{
				if (key.Type == LuaValueType.Number)
				{
					// TODO: support other indexer keys than Int32
					var indexer = typeof(T).GetProperties().Where(p => p.IsIndexer()).FirstOrDefault();
					if (indexer != null)
					{
						var index = key.Read<Int32>() - 1; // C# indexer would not expect a 1-based index
						var objValue = indexer.GetValue(luaObject.Instance, new Object[] { index });
						var value = indexer.PropertyType == typeof(LuaValue) ? (LuaValue)objValue : LuaValue.FromObject(objValue);
						return new ValueTask<Int32>(context.Return(value));
					}
				}
				else if (key.Type == LuaValueType.String)
				{
					var keyStr = key.Read<String>();

					var field = typeof(T).GetField(keyStr, BindingFlags.Public | BindingFlags.Instance);
					if (field != null)
					{
						var objValue = field.GetValue(luaObject.Instance);
						var value = field.FieldType == typeof(LuaValue) ? (LuaValue)objValue : LuaValue.FromObject(objValue);
						return new ValueTask<Int32>(context.Return(value));
					}

					var property = typeof(T).GetProperty(keyStr, BindingFlags.Public | BindingFlags.Instance);
					if (property != null)
					{
						var objValue = property.GetValue(luaObject.Instance);
						var value = property.PropertyType == typeof(LuaValue) ? (LuaValue)objValue : LuaValue.FromObject(objValue);
						return new ValueTask<Int32>(context.Return(value));
					}
				}
			}

			throw new LuaRuntimeException(context.Thread, $"{luaObject} failed to index: {key}");
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, _) =>
		{
			var luaObject = context.GetArgument<LuaObject<T>>(0);
			var key = context.GetArgument(1);
			var value = context.GetArgument(2);

			if (luaObject.Instance is ILuaIndexable indexable)
			{
				if (key.Type == LuaValueType.Number)
				{
					if (key.TryRead<Int32>(out var luaIndex) && indexable.TrySetLuaValue(luaIndex, value))
						return new ValueTask<Int32>(context.Return(0));
				}
				else if (key.Type == LuaValueType.String)
				{
					if (indexable.TrySetLuaValue(key.Read<String>(), value))
						return new ValueTask<Int32>(context.Return(0));
				}
			}
			else
			{
				if (key.Type == LuaValueType.Number)
				{
					// TODO: indexer
				}
				else if (key.Type == LuaValueType.String)
				{
					var keyStr = key.Read<String>();

					var field = typeof(T).GetField(keyStr, BindingFlags.Public | BindingFlags.Instance);
					if (field != null)
					{
						var fieldType = field.FieldType;
						if (fieldType.IsPrimitive)
						{
							// TODO
						}
						else if (fieldType == typeof(String))
						{
							field.SetValue(luaObject.Instance, value.ReadString());
							return new ValueTask<Int32>(context.Return(0));
						}
					}

					var property = typeof(T).GetProperty(keyStr, BindingFlags.Public | BindingFlags.Instance);
					if (property != null)
					{
						var propertyType = property.PropertyType;
						if (propertyType.IsPrimitive)
						{
							// TODO
						}
						else if (propertyType == typeof(String))
						{
							field.SetValue(luaObject.Instance, value.ReadString());
							return new ValueTask<Int32>(context.Return(0));
						}
					}
				}
			}

			throw new LuaRuntimeException(context.Thread, $"{luaObject} failed to assign: {key} = {value}");
		});
		private static LuaTable s_Metatable = LuaMetatable.Create(__index, __newindex);
		public LuaTable Metatable
		{
			get => s_Metatable ??= LuaMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException($"can't set Metatable of {nameof(LuaObject<T>)}");
		}
	}
}
