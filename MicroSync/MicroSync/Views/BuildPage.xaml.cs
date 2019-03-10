using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;
using Xamarin.Forms.Xaml;

namespace MicroSync
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildPage : ContentPage
    {
        public BuildPage()
        {
            InitializeComponent();
            Layout.Children.Add(
                new TestControl()
                {
                    BackgroundColor = Color.Red,
                    WidthRequest = 100,
                    HeightRequest = 100,
                    parent = Layout,
                });

            Layout.BackgroundColor = Color.FromRgb(53, 53, 53);

            //Layout.Children.Add(new Line(15, 15, 45, 45) { BackgroundColor = Color.Green});
        }
        private void Switch_Clicked(object sender, EventArgs e)
        {

        }
    }
}
