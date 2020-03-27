/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using ICheck.Views;
using Xamarin.Forms;
using ICheck.Extensions;
using System.Reflection;
using System.Globalization;

namespace ICheck
{
    public partial class App : Application
    {
        #region Constructor
        public App()
        {
            InitializeComponent();

            #region Init ImageResourceExtension
            ImageResourceExtension.InitImageResourceExtension("AppResources.Assets", typeof(App).GetTypeInfo().Assembly);
            #endregion

            #region Init TranslateExtension            
            TranslateExtension.InitTranslateExtension("AppResources.Localization.Resources", CultureInfo.CurrentCulture, typeof(App).GetTypeInfo().Assembly);
            #endregion

            InitMainPage();
        }
        #endregion

        #region Methods
        private void InitMainPage()
        {
            NavigationPage navigationPage = new NavigationPage(new HomeView());
            navigationPage.BarBackgroundColor = Color.FromHex("#7E1335");
            navigationPage.BarTextColor = Color.White;
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        #endregion
    }
}
