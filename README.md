# Pokepay Partner SDK for C#

### Setup

* Install .NET 5.0 or Later from the [Download site](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install)

### Build
```
$ make build
```

### Run test
```
$ make test
```

### How to use
- [Document](https://github.com/pokepay/pokepay-partner-csharp-sdk/blob/main/docs/index.md)

----------------------------------

### Developer information

#### How to release

For example if the version is `1.2.3` then:

1. Please update version. Update `<Version>1.2.3</Version>` on `src/PokepayPartnerCsharpSdk/PokepayPartnerCsharpSdk.csproj`
2. Please git commit/push the modification
3. Please add/push git tag `$ git tag -a 1.2.3 -m 1.2.3; git push 1.2.3`
4. Please publish it on nuget.org

You need to be in pokepay.org and has APIKEY

```
$ RELEASE_VERSION=1.0.0 API_KEY=`cat ~/.nuget/apikey` make publish
```

The API key can be acquired from nuget.org
See: https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli
