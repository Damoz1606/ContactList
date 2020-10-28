using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contact_List
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Contact_List.View.Contact_View();
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
    }
}
