cd src\PokepayPartnerCsharpSdk
msbuild -restore PokepayPartnerCsharpSdk48.csproj
msbuild -t:build PokepayPartnerCsharpSdk48.csproj
cd ..\..

cd src\PokepayPartnerCsharpSdk.Example
msbuild -restore PokepayPartnerCsharpSdk48.Example.csproj
msbuild -t:build PokepayPartnerCsharpSdk48.Example.csproj
cd ..\..

cd src\PokepayPartnerCsharpSdk.Test
msbuild -restore PokepayPartnerCsharpSdk48.Test.csproj
msbuild -t:build PokepayPartnerCsharpSdk48.Test.csproj
cd ..\..
