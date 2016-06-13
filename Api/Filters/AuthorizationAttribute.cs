using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Api.Filters
{
    public class AuthorizationAttribute : AuthorizationFilterAttribute
    {
        public override Task OnAuthorizationAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {

            return Task.FromResult<object>(null);

        }

    }
}