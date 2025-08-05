local context = ...

function context.LuaGameObject_GetComponents_IsLuaListWithComponents()
    local go = CreateGameObjectWithComponents(Skybox, 3)
    return go, go:GetComponents(Skybox)
end

function context.LuaGameObject_GetComponentsLength_CorrectLength()
    local go = CreateGameObjectWithComponents(Skybox, 3)
    return go, #go:GetComponents(Skybox)
end

function context.LuaList_Indexers_CorrectValues()
    local go = CreateGameObjectWithComponents(Skybox, 3)
    local coms = go:GetComponents(Skybox)
    return go, coms[1], coms[2], coms[3]
end

function context.LuaList_IPairs_EnumeratesAllAndCorrectValues()
    local go = CreateGameObjectWithComponents(Skybox, 3)
    local enumeratedValues = {}
    for i, v in pairs(go:GetComponents(Skybox)) do
        enumeratedValues[i] = v
    end
    return go, go:GetComponents(Skybox), enumeratedValues
end
