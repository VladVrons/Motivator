using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Motivator.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageInfo : ContentPage
    {
        public string taskname;
        public bool f;
        public PageInfo(MainPage det)

        {
            InitializeComponent();
            var detail = det;
            f = true;
            ToolbarItem tb = new ToolbarItem
            {   
                
                Text = "Save",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
            };
            ToolbarItems.Add(tb);
            tb.Clicked += (s, e) =>
            {
                int countoftask = Convert.ToInt32(Preferences.Get("count", "def"));
                taskname = Convert.ToString(_TaskName.Text);
                MyTask NewT = new MyTask(taskname);
                DisplayAlert("kek", taskname, "ok boomer");     
                
                Preferences.Set(Convert.ToString(countoftask), NewT.name);
                countoftask++;
                Preferences.Set("count", Convert.ToString(countoftask));

                detail.Detail = new NavigationPage(new MyTasks(detail));
                

            };
            
        }
    }
}