run:
	dotnet run --project src/PokepayPartnerCsharpSdk.Example/PokepayPartnerCsharpSdk.Example.csproj

build:
	dotnet build src/PokepayPartnerCsharpSdk/PokepayPartnerCsharpSdk.csproj --configuration Release

clean:
	dotnet clean src/PokepayPartnerCsharpSdk/PokepayPartnerCsharpSdk.csproj
	dotnet clean src/PokepayPartnerCsharpSdk.Example/PokepayPartnerCsharpSdk.Example.csproj

.PHONY: clean
