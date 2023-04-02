using Microsoft.AspNetCore.Authentication;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InterviewLearning.JWT
{
    public class CustomOAuthProvider : OAuthAuthorizationServerProvider
    {
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // In this example, we are not validating the client authentication.
            // You should modify this code to validate the client credentials.
            context.Validated();
            return Task.FromResult<object>(null);
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            // Validate the user's credentials
            //var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();
            //var user = await userManager.FindAsync(context.UserName, context.Password);

            //if (user == null)
            //{
            //    context.SetError("invalid_grant", "The username or password is incorrect.");
            //    return;
            //}

            //// Create the identity for the authenticated user
            //var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            //identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));

            //// Add any additional claims to the identity as needed
            //// ...

            //var ticket = new AuthenticationTicket(identity, new AuthenticationProperties());
            //context.Validated(ticket);
        }

    }
}
