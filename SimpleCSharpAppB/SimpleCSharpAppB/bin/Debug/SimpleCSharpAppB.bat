@echo off

rem ��������� ���� ��� ���������� SimpleCSharpAppB.exe,
rem ��������������� ������������ �� ��������.

SimpleCsharpAppB
@if "%ERRORLEVEL%" == "0" goto success
:fail
  echo This Application has failed!
  rem ���������� ����� ���������� �� �������!
  echo return value = %ERRORLEVEL%
  goto end
:success
  echo This Application has succeeded!
    rem ���������� ����� ���������� ������ �������!
  echo return value = %ERRORLEVEL%
  goto end
:end
  echo All Done.
  rem ��� �������.