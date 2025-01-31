﻿using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(EmmaUseCaseJacobClayton.Startup1))]

namespace EmmaUseCaseJacobClayton
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                CookieName = "PROG1210Cookie",
                LoginPath = new PathString("/Login"),
                LogoutPath = new PathString("/Default"),
                ExpireTimeSpan = System.TimeSpan.FromMinutes(5)

            });
        }
    }
}
