﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisiparişWeb.Modeller.Menüler;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BisiparişWeb.Pages.Menüler
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<MenüGörünümModel> Menüler { get; set; }

        public void OnGet()
        {

        }
    }
}