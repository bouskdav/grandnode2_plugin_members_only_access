using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Widgets.MembersOnly.Services;

namespace Widgets.MembersOnly.Infrastructure.Middleware
{
    public class MembersOnlyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<MembersOnlyMiddleware> _logger;
        private readonly IMembersOnlyService _membersOnlyService;
        private readonly MembersOnlyWidgetSettings _membersOnlyWidgetSettings;

        public MembersOnlyMiddleware(
            RequestDelegate next,
            ILogger<MembersOnlyMiddleware> logger,
            IMembersOnlyService membersOnlyService,
            MembersOnlyWidgetSettings membersOnlyWidgetSettings)
        {
            _next = next;
            _logger = logger;
            _membersOnlyService = membersOnlyService;
            _membersOnlyWidgetSettings = membersOnlyWidgetSettings;
        }

        public async Task InvokeAsync(
            HttpContext context)
        {
            bool isStaticFile = !String.IsNullOrEmpty(System.IO.Path.GetExtension(context.Request.Path));

            //TODO: put after .UseAuthentication() to have identity available
            // authentication not available here, check for .Grand.Authentication cookie
            if (context.Request.Cookies.ContainsKey(".Grand.Authentication") || 
                context.Request.Cookies.ContainsKey(".Nekton.Member") || 
                context.Request.Path.ToString().Contains("MembersOnly") || 
                !_membersOnlyWidgetSettings.MembersOnlyAccessEnabled ||
                isStaticFile)
            {
                await _next(context);
                return;
            }

            // Get the enpoint which is executing (asp.net core 3.0 only)
            var executingEndpoint = context.GetEndpoint();

            // Get attributes on the executing action method and it's defining controller class
            var attributes = executingEndpoint.Metadata.OfType<AllowAnonymousAttribute>();

            if (attributes.Any())
            {
                await _next(context);
                return;
            }

            var viewResult = new ViewResult() {
                ViewName = "~/Views/WidgetsMembersOnly/Index.cshtml"
            };

            var viewDataDictionary = new ViewDataDictionary(
                new EmptyModelMetadataProvider(),
                new ModelStateDictionary());

            viewDataDictionary.Model = null;//your model
            viewResult.ViewData = viewDataDictionary;

            var executor = context.RequestServices
                .GetRequiredService<IActionResultExecutor<ViewResult>>();
            var routeData = context.GetRouteData() ?? new RouteData();
            var actionContext = new ActionContext(
                context, 
                routeData,
                new Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor());

            await executor.ExecuteAsync(actionContext, viewResult);

            //// 1 - if the request is not authenticated, nothing to do
            //if (context.User.Identity == null || !context.User.Identity.IsAuthenticated)
            //{
            //    await _next(context);
            //    return;
            //}

            //var cancellationToken = context.RequestAborted;

            //// 2. The 'sub' claim is how we find the user in our system
            //var userSub = context.User.FindFirst(StandardJwtClaimTypes.Subject)?.Value;
            //if (string.IsNullOrEmpty(userSub))
            //{
            //    await context.WriteAccessDeniedResponse(
            //      "User 'sub' claim is required",
            //      cancellationToken: cancellationToken);
            //    return;
            //}

            //// 3 - Now we try to get the user permissions (as ClaimsIdentity)
            //var permissionsIdentity = await permissionService
            //    .GetUserPermissionsIdentity(userSub, cancellationToken);
            //if (permissionsIdentity == null)
            //{
            //    _logger.LogWarning("User {sub} does not have permissions", userSub);

            //    await context.WriteAccessDeniedResponse(cancellationToken: cancellationToken);
            //    return;
            //}

            //// 4 - User has permissions
            //// so we add the extra identity to the ClaimsPrincipal
            //context.User.AddIdentity(permissionsIdentity);
            //await _next(context);
        }
    }
}
