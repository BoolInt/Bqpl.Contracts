@echo off

set project=Bqpl.Contracts

set config=%1
if "%config%" == "" (
   set config=Release
)

set version=
if not "%PackageVersion%" == "" (
   set version=-Version %PackageVersion%
)

call %GitVersion% /updateassemblyinfo true

call %NuGet% restore Bqpl.Contracts.sln -OutputDirectory %cd%\packages -NonInteractive

"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" Bqpl.Contracts.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

mkdir Build
call %nuget% pack "Bqpl.Contracts\Bqpl.Contracts.csproj" -symbols -o Build -p Configuration=%config% %version%
