﻿using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.Controllers
{
    public class CultureController : Controller
    {

        [HttpPost]
        public IActionResult SetCulture(string culture, string returnUrl)
        {
            if (string.IsNullOrEmpty(culture))
                culture = "tr-TR"; // default dil

            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl ?? "/");
        }
    }
}
