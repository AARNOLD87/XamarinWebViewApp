using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        //[Test]
        //public void TextUrlEntry()
        //{
        //    //Arrange
        //    app.Tap( x => x.Class("ImageButton").Marked("OK"));
        //    app.EnterText("urlEntry", "www.vaimo.mommo");

        //    //Act

        //    //Assert
        //    var entry = app.Query("urlEntry").First(x => x.Text != "");
        //    Assert.IsTrue(entry != null);
        //}
    }
}

