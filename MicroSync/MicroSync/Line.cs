using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MicroSync
{
    class Line : BoxView
    {
        public Line(double pointX1, double pointY1, double pointX2, double pointY2)
        {
            this.TranslationX = pointX1;
            this.TranslationY = pointY1;
            this.WidthRequest = 3;

            double XDist = pointX2 - pointX1;
            double YDist = pointY2 - pointY1;

            double angle = -Math.Atan(YDist / XDist) * (180 / Math.PI);
            double ZDist = Math.Sqrt(Math.Pow(XDist, 2) + Math.Pow(YDist, 2));

            this.HeightRequest = ZDist;
            this.RotateTo(angle);

        }
    }
}
