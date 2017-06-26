using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile("C:/Tirocinio/Repo/XamarinWebViewApp/XamarinWebViewApp/XamarinWebViewApp.Droid/bin/Debug/xamarinwebviewapp.xamarinwebviewapp.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

