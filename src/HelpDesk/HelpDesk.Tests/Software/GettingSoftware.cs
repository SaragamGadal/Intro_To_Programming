using Alba;

namespace HelpDesk.Tests.Software;

public class GettingSoftware
{
    [Fact]
    public async Task CanGetSoftware()
    {
        var host = await AlbaHost.For<Program>();

        await host.Scenario(api =>
        {
            api.Get.Url("/api/software");
            api.StatusCodeShouldBeOk();
        });
    }
}
