﻿using System;
using Microsoft.Identity.Client;

using Xamarin.Forms;

namespace UserDetailsClient.Core
{
    public class App : Application
    {
        public static IPublicClientApplication PCA = null;

        // Azure AD B2C Coordinates
        public static string Tenant = "fabrikamb2c.onmicrosoft.com";
        public static string AzureADB2CHostname = "login.microsoftonline.com";
        public static string ClientID = "90c0fe63-bcf2-44d5-8fb7-b8bbc0b29dc6";
        public static string PolicySignUpSignIn = "b2c_1_susi";
        public static string PolicyEditProfile = "b2c_1_edit_profile";
        public static string PolicyResetPassword = "b2c_1_reset";

        public static string[] Scopes = { "https://fabrikamb2c.onmicrosoft.com/helloapi/demo.read" };
        public static string ApiEndpoint = "https://fabrikamb2chello.azurewebsites.net/hello";
        
        public static object ParentWindow { get; set; }

        public App()
        {
            // default redirectURI; each platform specific project will have to override it with its own
            PCA = PublicClientApplicationBuilder.Create(ClientID)
                .WithRedirectUri($"msal{ClientID}://auth")
                .WithB2CAuthorityHostInfo(AzureADB2CHostname, Tenant)
                .Build();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
