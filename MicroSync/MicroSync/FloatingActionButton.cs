using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MicroSync
{
    public partial class FAB : SuaveControls.Views.FloatingActionButton
    {
        public FAB()
        {
           // this.HeightRequest = 100;
            //this.WidthRequest = 100;
        
            this.Image = "Edit_Icon.png";
            this.BackgroundColor = Color.Transparent;
            this.CornerRadius = (int)this.HeightRequest;
        }
    }
}
