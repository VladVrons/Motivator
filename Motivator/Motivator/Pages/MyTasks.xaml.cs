using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Xamarin.Essentials;
using System.IO;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.LocalNotifications;
using Motivator.Pages;
using System.Threading;

namespace Motivator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTasks : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        public int[] a;
        private MainPage mpage;
        public int countoftask;
        
    
        public  MyTasks(MainPage det)
        {
            InitializeComponent();
            mpage = det;
            Items = new ObservableCollection<string> { };
            
           if(Preferences.Get("count", "def").Contains('0')
                || Preferences.Get("count", "def").Contains('1')
                || Preferences.Get("count", "def").Contains('2')
                || Preferences.Get("count", "def").Contains('3')
                || Preferences.Get("count", "def").Contains('4')
                || Preferences.Get("count", "def").Contains('5')
                || Preferences.Get("count", "def").Contains('6')
                || Preferences.Get("count", "def").Contains('7')
                || Preferences.Get("count", "def").Contains('8')
                || Preferences.Get("count", "def").Contains('9')
                )
            {
                countoftask = Convert.ToInt32(Preferences.Get("count", "def"));
            }
            else 
            { 
                countoftask = 0;
                Preferences.Set("count", "0");
            }

           



             for(int i=0; i<countoftask; i++)
             {
                Items.Add(Preferences.Get(Convert.ToString(i),"default"));
             }
             MyListView.ItemsSource = Items;

            ToolbarItem tb = new ToolbarItem
            {
                Text = "New",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                IconImageSource = "like.png"
            };
            ToolbarItems.Add(tb);
            tb.Clicked += (s, e) =>
            {
                this.AddNewTask();
            };



        }
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            

            ((ListView)sender).SelectedItem = null;
        }
        

        private async void AddNewTask()
        {            
            var newpi =new PageInfo(mpage);
            mpage.Detail =new NavigationPage(newpi);      
        }

    }
}
