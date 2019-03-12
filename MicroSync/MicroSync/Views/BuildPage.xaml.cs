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
            Lay.Children.Add(
                new TestControl()
                {
                    BackgroundColor = Color.Red,
                    WidthRequest = 100,
                    HeightRequest = 100,
                    parent = Lay,
                });

            Lay.BackgroundColor = Color.FromRgb(53, 53, 53);

            //Layout.Children.Add(new Line(15, 15, 45, 45) { BackgroundColor = Color.Green});
        }
        private void Add_Clicked(object sender, EventArgs e)
        {

        }
    }
}
