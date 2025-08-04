local context = ...

local function MakeGameObjectWithThreeSkyboxes()
    local go = GameObject.new('go')
    go:AddComponent(Skybox)
    go:AddComponent(Skybox)
    go:AddComponent(Skybox)
    return go
end

function context.Lua_GetComponents_ReturnsLuaList()
    local go = MakeGameObjectWithThreeSkyboxes()
    return go, go:GetComponents(Skybox)
end


function context.Lua_GetComponents_CanGetLength()
    local go = MakeGameObjectWithThreeSkyboxes()
    return go, #go:GetComponents(Skybox)
end
