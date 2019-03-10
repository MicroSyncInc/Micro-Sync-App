using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Diagnostics;
using SuaveControls.Views;

namespace MicroSync
{
    abstract class Control : View, IPlugin
    {
        public Container parent { get; set; }
        public abstract string Name { get; set; }
        public abstract string ID { get; set; }
        public abstract string Version { get; set; }
        public abstract string Author { get; set; }
        private TapGestureRecognizer SingleTapRecognizer = new TapGestureRecognizer();
        private TapGestureRecognizer DoubleTapRecognizer = new TapGestureRecognizer() { NumberOfTapsRequired = 2 };
        private PanGestureRecognizer PanGesture = new PanGestureRecognizer();
        public Control()
        {
            SingleTapRecognizer.Tapped += (s, e) => OnTap_Super(s, SingleTapRecognizer);
            DoubleTapRecognizer.Tapped += (s, e) => OnDoubleTap_Super(s, DoubleTapRecognizer);
            PanGesture.PanUpdated += (s, e) => OnPan_Super(s, e);
            
            this.GestureRecognizers.Add(SingleTapRecognizer);
            this.GestureRecognizers.Add(DoubleTapRecognizer);
            this.GestureRecognizers.Add(PanGesture);
        }

        #region API Handlers
            public void SendOverBluetooth() => SendOverBluetooth(JsonConvert.SerializeObject(this));
     
            public void SendOverBluetooth(string json)
            {

            }
        #endregion 

        #region EventHandlers
            #region Built_In
                public void OnPan_Super(object sender, PanUpdatedEventArgs e)
                {
                    if (this.parent.Mode == Modes.EditMode)
                    {
                        Debug.WriteLine("Pan triggered!");
                        this.parent.ClearFABS();
                        switch (e.StatusType)
                        {
                            case GestureStatus.Running:
                                this.TranslationX = this.TranslationX + e.TotalX;
                                this.TranslationY = this.TranslationY + e.TotalY;
                                break;

                            case GestureStatus.Completed:
                                break;
                        }
                    }
                    else if (this.parent.Mode == Modes.PlayMode)
                    {
                        OnPan(sender, e);
                    }
                }
                public void OnDoubleTap_Super(object sender, TapGestureRecognizer e)
        {
            if (this.parent.Mode == Modes.EditMode)
            {
                FAB fab = new FAB();
                fab.TranslationX = this.TranslationX - (fab.Width / 2);
                fab.TranslationY = this.TranslationY - (fab.Height / 2);
                this.parent.ClearFABS();
                this.parent.Children.Add(fab);
            }
            else if (this.parent.Mode == Modes.PlayMode)
            {
                OnDoubleTap(sender, e);
            }
        }
                public void OnTap_Super(object sender, TapGestureRecognizer e)
        {
            if(this.parent.Mode == Modes.EditMode)
            {

            }else if(this.parent.Mode == Modes.PlayMode)
            {
                OnTap(sender, e);
            }
        }
            #endregion
            #region Customizable
                public virtual void OnTap(object sender, TapGestureRecognizer e)
        {
            Debug.WriteLine("Tap Event Triggered");
        }
                public virtual void OnDoubleTap(object sender, TapGestureRecognizer e)
        {
            Debug.WriteLine("Double Tap Event Triggered");
        }
                public virtual void OnPan(object sender, PanUpdatedEventArgs e)
        {
            Debug.WriteLine("Pan Event Triggered");
        }
            #endregion
        #endregion

        #region Unused/Required
        #endregion
    }
}
