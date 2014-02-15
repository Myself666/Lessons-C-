@echo off

rem Командный файл для приложения SimpleCSharpAppB.exe,
rem перехватывающий возвращаемое им значение.

SimpleCsharpAppB
@if "%ERRORLEVEL%" == "0" goto success
:fail
  echo This Application has failed!
  rem Выполнение этого приложения не удалось!
  echo return value = %ERRORLEVEL%
  goto end
:success
  echo This Application has succeeded!
    rem Выполнение этого приложения прошло успешно!
  echo return value = %ERRORLEVEL%
  goto end
:end
  echo All Done.
  rem Все сделано.