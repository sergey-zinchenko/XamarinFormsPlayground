using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossLibrary
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new MainPage(); // your page here
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
        }
    }
}
