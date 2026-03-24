using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.SendGrid.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SendGridOpenApiClientTests : FixturedUnitTest
{
    public SendGridOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
