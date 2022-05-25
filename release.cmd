@echo off
if not defined RELEASE_VERSION (
  echo environment RELEASE_VERSION is required.
  exit /b
)
if not defined API_KEY(
  echo environment API_KEY is required.
  exit /b
)

dotnet nuget push src/PokepayPartnerCsharpSdk/bin/Release/pokepay-partner-csharp-sdk.%RELEASE_VERSION%.nupkg --api-key %API_KEY% --source https://api.nuget.org/v3/index.json
