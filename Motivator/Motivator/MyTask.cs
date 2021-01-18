using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Motivator
{
    public class MyTask
    {
        public string name;
        public bool f = true;
        public string description;
       
        public MyTask()
        { }
        
        public MyTask(string nm)
        {
            this.name = nm;
        }
      
    }
}
