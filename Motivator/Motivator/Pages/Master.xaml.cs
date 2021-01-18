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
            Detail = new NavigationPage(new MyTasks());
            IsPresented = false;
            ToolbarItem Tb = new ToolbarItem
            {
                Text = "Text",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                IconImageSource="MyM.png"
            };
            ToolbarItems.Add(Tb);
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
