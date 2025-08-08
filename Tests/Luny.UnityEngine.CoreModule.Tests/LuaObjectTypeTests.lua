local context = ...

function context.LuaGameObject_Equality_AreEqual()
    local go = GameObject.new('test')
    local go2 = go
    return go == go2, go ~= go2
end

function context.LuaGameObject_Equality_AreNotEqual()
    local go = GameObject.new('test')
    local go2 = GameObject.new('test2')
    return go == go2, go ~= go2
end
