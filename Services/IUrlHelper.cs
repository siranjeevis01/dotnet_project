using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DOTNET_PROJECT.Services
{
    public static class UrlHelperExtensions
    {
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            // Construct the email confirmation link
            return urlHelper.Action(
                action: "ConfirmEmail",
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }
    }
}
