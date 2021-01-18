using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.LocalNotifications;
using System.Threading.Tasks;
namespace Motivator
{
    public partial class App : Application
    {
     
        public App()
        {
            InitializeComponent();
            
            MainPage = new MainPage();

        }

        protected override void OnStart()
        {
            ClickHandler();
        } 
    
        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
        }

        public async void ClickHandler()
        {

            MainPage = new TaskPage();
            await Task.Delay(2000);
            MainPage = new MainPage();


        }
    }
}
