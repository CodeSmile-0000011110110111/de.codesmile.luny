@echo off
xcopy "..\Lua-CSharp-CodeSmile\src\Lua\bin\Debug\netstandard2.1\*.*" "Runtime\Plugins\LuaCSharp\lib\netstandard2.1\Debug" /Y /V
xcopy "..\Lua-CSharp-CodeSmile\src\Lua\bin\Release\netstandard2.1\*.*" "Runtime\Plugins\LuaCSharp\lib\netstandard2.1\Release" /Y /V
REM pause
