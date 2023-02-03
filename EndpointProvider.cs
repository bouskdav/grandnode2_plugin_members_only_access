using Grand.Infrastructure.Endpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Widgets.MembersOnly
{
    public partial class EndpointProvider : IEndpointProvider
    {
        public void RegisterEndpoint(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //PaymentInfo
            endpointRouteBuilder.MapControllerRoute("Plugin.MembersOnly",
                 "Plugins/MembersOnly/Check",
                 new { controller = "MembersOnly", action = "Check", area = "" }
            );

            ////PDT
            //endpointRouteBuilder.MapControllerRoute("Plugin.Payments.MembersOnly",
            //     "Plugins/PaymentPayPalStandard/PDTHandler",
            //     new { controller = "PaymentPayPalStandard", action = "PDTHandler" }
            //);
        }
        public int Priority => 0;

    }
}
