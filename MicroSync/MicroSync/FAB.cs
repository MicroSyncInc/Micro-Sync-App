using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace MicroSync
{
    public class FABContainer : AbsoluteLayout
    {
        public static int NUMBER_FOR_RING = 3;
        public static double ANGLE_INCREMENT = 360.0 / ((double)NUMBER_FOR_RING);
        public static double CENTER_RADIUS = 100;
        public static double WIDTH_MOD = 0.9;
        Control AssignedElement;
        public FABContainer(Control element)
        {
            this.WidthRequest = 1000;
            this.HeightRequest = 1000;
            this.TranslateTo(this.TranslationX - 500,this.TranslationY - 500, 0);
            Debug.WriteLine("Creating Container");
            this.BackgroundColor = Color.Transparent;
            this.AssignedElement = element;
            FAB fab = new FAB();
            List<InternalFAB> internals = new List<InternalFAB>();
            InternalFAB Del = new InternalFAB(1);
            Del.Clicked += (s,e) => Debug.WriteLine("Blue Clicked!");
            Del.ButtonColor = Color.Blue;
            InternalFAB Prop = new InternalFAB(2);
            Prop.Clicked += (s, e) => Debug.WriteLine("White Clicked!");
            Prop.ButtonColor = Color.White;
            InternalFAB Dupe = new InternalFAB(3);
            Dupe.Clicked += (s, e) => Debug.WriteLine("Green Clicked!");
            Dupe.ButtonColor = Color.Green;
            this.Children.Add(Del);
            this.Children.Add(Prop);
            this.Children.Add(Dupe);
            this.Children.Add(fab);
            //foreach(InternalFAB f in internals) {this.Children.Add(f);};
        }
        public void OnDeleteClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Called");
            AssignedElement.Destroy();
        }
        
    }
    public class FAB : SuaveControls.Views.FloatingActionButton
    {
        public FAB()
        {
            this.HeightRequest = FABContainer.CENTER_RADIUS;
            this.WidthRequest = FABContainer.CENTER_RADIUS * FABContainer.WIDTH_MOD;
            Debug.WriteLine($"CREATING NEW CENTER WITH W: {this.WidthRequest} H: {this.HeightRequest}");
            this.Image = "Edit_Icon.png";
            this.BackgroundColor = Color.Transparent;
            this.CornerRadius = (int)this.HeightRequest;
            this.Clicked += Click;
        }
        private void Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Center Clicked");
        }
    }
    enum InternalTypes
    {

    }
}
