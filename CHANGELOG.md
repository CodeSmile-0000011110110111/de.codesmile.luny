# Change Log - CodeSmile Luny

Issue numbers refer to GitHub issues:
https://github.com/CodeSmile-0000011110110111/de.codesmile.luny/issues

See also the DevLog for a full history:
https://docs.google.com/document/d/1jADnS6rsSx28-uWu8C4ubvCQD08zRO8sNLwtv8uASNU/edit?usp=sharing


### 0.5.3

- added: 'script.transform' as shorthand for 'script.gameObject.transform' (#24)
- added: runtime script hot reload now calls OnEnable/OnDisable (#27)
- fixed (again): some created assets still used the old `context` variable (#22)
- fixed: script properties (ie 'script.name') now in camelCase, with Name and Path remaining as PascalCase aliases for a while
- fixed: outdated infos in README.md

### 0.5.2

- hotfix: Restored Assembly Definition references, I accidentally caused their GUIDs to change and this caused compile errors.

### 0.5.1
 
- breaking: renamed LunyScript `OnBeforeFirstScriptLoad` to `OnBeforeInitialScriptLoad` 
- added: `script.gameObject` in runtime scripts to access GameObject reference (#23)
- fixed: some created assets still used the old `context` variable (#22)

### 0.5.0

- First public release
