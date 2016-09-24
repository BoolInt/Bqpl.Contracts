@echo off

set project=Bqpl.Contracts

set config=%1
if "%config%" == "" (
   set config=Release
)

REM Restore
call dotnet restore
if not "%errorlevel%"=="0" goto failure

REM Build
"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" %project%.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false
if not "%errorlevel%"=="0" goto failure

REM Packge
mkdir %cd%\Artifacts
call dotnet pack %project% --configuration %config% %version% --output Artifacts
if not "%errorlevel%"=="0" goto failure

:success
exit 0

:failure
exit -1
