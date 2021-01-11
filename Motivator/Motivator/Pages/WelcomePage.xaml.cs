
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Motivator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();

            //ImageButton image = new ImageButton
            //{
                //Source = ImageSource.FromResource("Motivator.photoss.MyM.png")
            //};
            //Content = image;
        }

        private void StartApp(object sender, EventArgs e)
        {
            App.Current.MainPage = new MyTasks();
        }
    }
}
