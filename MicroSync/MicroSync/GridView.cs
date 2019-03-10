using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MicroSync
{
    public class GridView : Grid
    {
        public GridView(double width, double height, int num)
        {
            this.BackgroundColor = Color.Transparent;
            for(double i = 0; i < width / ((double)num); i++)
            {
                for(double j = 0; j < height / ((double)num); j++)
                {
                    Line l = new Line(
                        ((double)i) * (width / ((double)num)),
                        0,
                        ((double)i) * (width / ((double)num)),
                        ((double)j) * (height / ((double)num))
                        );
                    this.Children.Add(l);
                }
            }
        }
    }
}
