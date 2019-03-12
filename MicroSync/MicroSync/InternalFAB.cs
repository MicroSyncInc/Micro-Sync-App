using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace MicroSync
{
    public class InternalFAB : SuaveControls.Views.FloatingActionButton
    {
        public static double DIST = 3;
        public static double radius = 80;
        public static double INTERNAL_X_DISTORTION = 9;
        public static double INTERNAL_Y_DISTORTION = 6;
        public InternalFAB(int index)
        {
            this.HeightRequest = (radius);
            this.WidthRequest = (radius * FABContainer.WIDTH_MOD * 0.95);
            this.BackgroundColor = Color.Transparent;
            
            double AngleDistortion = ((double)index) * FABContainer.ANGLE_INCREMENT;

            double xpos = (DIST + this.WidthRequest) * (Math.Cos((Math.PI / 180.0) * AngleDistortion)) + INTERNAL_X_DISTORTION;
            double ypos = (DIST + this.HeightRequest) * (Math.Sin((Math.PI / 180.0) * AngleDistortion)) + INTERNAL_Y_DISTORTION;

            Debug.WriteLine($"CREATING NEW INTERNAL AT: {xpos},{ypos} from distortion {AngleDistortion}");

            this.TranslationX = xpos;
            this.TranslationY = ypos;

            //this.Clicked += (s, e) => Debug.WriteLine("Clicked Internal");
        }
        private void Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked Internal");
        }
    }
}
