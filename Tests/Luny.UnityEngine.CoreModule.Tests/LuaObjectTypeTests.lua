local context = ...

context.UserData_Concat_CallsToString = function()
    local go = GameObject('test')
    return "this is a concat " .. go
end

function context.LuaGameObject_Equality_AreEqual()
    local go = GameObject('test')
    local go2 = go
    return go == go2, go ~= go2
end

function context.LuaGameObject_Equality_AreNotEqual()
    local go = GameObject('test')
    local go2 = GameObject('test2')
    return go == go2, go ~= go2
end
