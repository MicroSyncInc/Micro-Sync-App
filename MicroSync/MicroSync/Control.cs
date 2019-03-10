using MR.Gestures;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Diagnostics;

namespace MicroSync
{
    abstract class Control : MR.Gestures.Frame, IPlugin
    {
        public Xamarin.Forms.Label disp { get; set; }
        public abstract string Name { get; set; }
        public abstract string ID { get; set; }
        public abstract string Version { get; set; }
        public abstract string Author { get; set; }
        /*
        Down- One or more fingers came down onto the touch screen.
        Up- One or more fingers were lifted from the screen.
        Tapping- A finger came down and up again but it is not sure yet if this may become a multi tap.
        Tapped- There was no second tap within 250ms so this was a single tap gesture.
        DoubleTapped- There have been two Tapping events within 250ms and no more came.
        LongPressing- A finger came down on the screen and did not move. The finger is still down.
        LongPressed- The finger was released and the gesture is finished.
        Panning- A finger came down and is moving on the screen.
        Panned- The finger left the screen while it was moved slowly or not at all.
        Swiped- The finger left the screen while it was moved fast.
        Pinching- Two fingers hit the screen and are moving towards or away from each other.
        Pinched- The fingers left the screen.
        Rotating- Two fingers hit the screen and are rotating on the screen.
        Rotated- The fingers left the screen.
    */
        public Control()
        {
            this.LongPressing += OnHold;
            this.LongPressed += OnLongPressed;
            this.Panned += OnPan;
            this.Panning += OnPanning;
            this.Rotated += OnRotate;
            this.Rotating += OnRotating;
        }
        public void SendOverBluetooth() => SendOverBluetooth(JsonConvert.SerializeObject(this));
     
        public void SendOverBluetooth(string json)
        {

        }
        public void OnHold(object sender, LongPressEventArgs e)
        {

        }
        public void OnLongPressed(object sender, LongPressEventArgs e)
        {
            this.BackgroundColor = Color.Green;
        }
        public void OnPan(object sender, PanEventArgs e)
        {
        }
        public void OnPanning(object sender, PanEventArgs e)
        {
            Point[] Touches = e.Touches;
            this.TranslationX = 50;
            this.TranslationY = 50;
            disp.Text = "Touches " + e.NumberOfTouches;
            if (e.NumberOfTouches > 0)
            {
                double X = Touches[0].X;
                double Y = Touches[0].Y;
                //disp.Text = "X: " + X + " Y: " + Y;
                this.TranslationX = X;
                this.TranslationY = Y;
            }
        }
        public void OnRotate(object sender, RotateEventArgs e){}
        public void OnRotating(object sender, RotateEventArgs e){}
    }
}
