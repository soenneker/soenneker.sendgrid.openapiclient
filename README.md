[![](https://img.shields.io/nuget/v/soenneker.sendgrid.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sendgrid.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sendgrid.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.sendgrid.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.sendgrid.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sendgrid.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sendgrid.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.sendgrid.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.SendGrid.OpenApiClient

Generated request builders and models for SendGrid mail, contacts, lists, templates, suppressions, statistics, settings, webhooks, API keys, and account resources.

## Installation

```bash
dotnet add package Soenneker.SendGrid.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.SendGrid.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://api.sendgrid.com"
};

var client = new SendGridOpenApiClient(adapter);
var scopes = await client.Tsg_scopes_v3.V3.Scopes
    .WithUrl("https://api.sendgrid.com/v3/scopes")
    .GetAsync(cancellationToken: cancellationToken);
```

SendGrid API keys use the bearer scheme. The anonymous Kiota authentication provider is intentional because the supplied `HttpClient` already carries the `Authorization` header.

The source schema groups operations under names such as `tsg_scopes_v3`, and those group names appear in generated URL templates even though they are not part of SendGrid's public routes. Use the relevant builder's `WithUrl` method with the documented `https://api.sendgrid.com/v3/...` endpoint, as shown above.
