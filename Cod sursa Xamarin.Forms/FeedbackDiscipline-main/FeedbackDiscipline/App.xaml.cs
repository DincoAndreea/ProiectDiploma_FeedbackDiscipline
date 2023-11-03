using FeedbackDiscipline.Pagini;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FeedbackDiscipline
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Conectare());
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
