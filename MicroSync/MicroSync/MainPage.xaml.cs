using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MicroSync
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            TestControl control = new TestControl(){ BackgroundColor = Color.Purple, disp = Disp };
            Layout.Children.Add(control);
        }
    }
}
