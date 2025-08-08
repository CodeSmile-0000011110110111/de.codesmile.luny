local context = ...

function context.LuaObject_BindObject_AccessibleInLua()
    return MyCustomObject
end
function context.LuaObject_Index_ReturnsCorrectValue()
    return MyCustomObject, MyCustomObject.SomeInteger, MyCustomObject[1]
end
function context.LuaObject_IndexViaReflection_ReturnsCorrectValue()
    return MyCustomObject, MyCustomObject.SomeInteger, MyCustomObject[1]
end

function context.LuaObject_WrongStringIndex_Throws()
    return MyCustomObject, MyCustomObject.XBADSERR
end
function context.LuaObject_WrongIntIndex_Throws()
    return MyCustomObject, MyCustomObject[123.456789]
end


function context.LuaValueType_BindStruct_AccessibleInLua()
    return MyCustomStruct
end
