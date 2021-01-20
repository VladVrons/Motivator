using System;
using System.ComponentModel;
using Xamarin.Forms;


namespace Motivator
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MyTasks())
            {
                BarBackgroundColor = Color.Aquamarine 
            };

            IsPresented = false;
           
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MyTasks());
            IsPresented = false;
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TimePage());
            IsPresented = false;
        }
    }
}
