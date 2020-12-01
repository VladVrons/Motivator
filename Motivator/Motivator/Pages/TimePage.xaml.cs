using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Motivator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePage : ContentPage
    {
        public bool f;
        DateTime _time;
        public TimePage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), Tick);
        }
    

        bool Tick()
        {

            if (_Vajil.IsToggled && DateTime.Now >= _time)
            {
                CrossLocalNotifications.Current.Show("TIME!!!", "WAKE THE FUCK UP THE SAMURAI, WE HAVE A SITY TO BURN");
                _Vajil.IsToggled = false;

            }
            return true;
        }
      
        private void TimePicker1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                _time = DateTime.Today + TimePicker1.Time;

            }

        }

        private void _Vajil_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            
        }
    }
}