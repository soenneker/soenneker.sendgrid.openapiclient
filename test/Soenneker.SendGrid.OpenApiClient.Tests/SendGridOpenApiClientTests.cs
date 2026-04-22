using Soenneker.Tests.HostedUnit;

namespace Soenneker.SendGrid.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SendGridOpenApiClientTests : HostedUnitTest
{
    public SendGridOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
