using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MicroSync
{
    public enum Modes
    {
        EditMode,
        PlayMode
    }
    public class Container : AbsoluteLayout
    {
        //private static int NUM_GRIDLINES = 3;
        TapGestureRecognizer SingleTapRecognizer = new TapGestureRecognizer();
        public Modes Mode = Modes.EditMode;
        public Container()
        {
            
            SingleTapRecognizer.Tapped += (s, e) => OnTap(s, SingleTapRecognizer);
            this.GestureRecognizers.Add(SingleTapRecognizer);
        }

        private void OnTap(object s, TapGestureRecognizer e)
        {
            Debug.WriteLine("CLICKED: " + s.GetType().Name);
            if(s.GetType().Name != "InternalFAB")
            {
                ClearFABS();
            }
        }

        public void ClearFABS()
        {
            foreach (View v in this.Children)
            {
                if (v.GetType().Name == "FABContainer")
                {
                    this.Children.Remove(v);
                    break;
                }
            }
        }
    }
}
