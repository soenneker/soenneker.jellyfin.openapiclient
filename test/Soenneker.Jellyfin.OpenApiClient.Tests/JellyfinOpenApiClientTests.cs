using Soenneker.Tests.HostedUnit;

namespace Soenneker.Jellyfin.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class JellyfinOpenApiClientTests : HostedUnitTest
{
    public JellyfinOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
