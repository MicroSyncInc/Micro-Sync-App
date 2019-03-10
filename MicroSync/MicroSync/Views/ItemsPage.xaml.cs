using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace MicroSync.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();

     //       Xamarin.Forms.Label l = new Xamarin.Forms.Label() { Text = "Test" };
     //       MR.Gestures.BoxView bx = new MR.Gestures.BoxView() { BackgroundColor = Color.Red, Color = Color.Red };
      //      bx.LongPressed += LongPress;
        }

       // public void LongPress(object sender, LongPressEventArgs e)
     //   {
     //       ((MR.Gestures.BoxView)sender).Color = Color.Green;
    //        ((MR.Gestures.BoxView)sender).BackgroundColor = Color.Green;
    //    }
    }
}