function CreateGameObjectWithComponents(componentType, count)
    local go = GameObject('go')
    if componentType then
        count = count and count or 1
        for _ = 1, count do
            go:AddComponent(componentType)
        end
    end
    return go
end
