using MyNutritionTracker.Data;
using Microsoft.AspNetCore.Identity;

namespace MyNutritionTracker.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<FoodUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<FoodUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
