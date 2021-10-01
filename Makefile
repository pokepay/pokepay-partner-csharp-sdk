run:
	dotnet run --project src/PokepayPartnerCsharpSdk.Example/PokepayPartnerCsharpSdk.Example.csproj

build:
	dotnet build src/PokepayPartnerCsharpSdk/PokepayPartnerCsharpSdk.csproj --configuration Release

test:
	dotnet test -v normal src/PokepayPartnerCsharpSdk.Test/PokepayPartnerCsharpSdk.Test.csproj

check-publish-env:
ifndef RELEASE_VERSION
	$(error RELEASE_VERSION is mandatory. eg: RELEASE_VERSION=1.2.3)
endif
ifndef API_KEY
	$(error API_KEY is mandatory. eg: API_KEY=xxxxxxyyyyyyyyyzzzzzz)
endif

publish: check-publish-env build
	dotnet nuget push src/PokepayPartnerCsharpSdk/bin/Release/pokepay-partner-csharp-sdk.$(RELEASE_VERSION).nupkg --api-key $(API_KEY) --source https://api.nuget.org/v3/index.json

clean:
	dotnet clean src/PokepayPartnerCsharpSdk/PokepayPartnerCsharpSdk.csproj
	dotnet clean src/PokepayPartnerCsharpSdk/PokepayPartnerCsharpSdk.Test.csproj
	dotnet clean src/PokepayPartnerCsharpSdk.Example/PokepayPartnerCsharpSdk.Example.csproj

.PHONY: clean publish
