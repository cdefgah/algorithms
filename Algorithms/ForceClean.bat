REM "Deletes recursively all obj and bin folders. Doing the Visual Studio Clean command, but better."
for /d /r . %%d in (bin,obj) do @if exist "%%d" rd /s/q "%%d"
pause
