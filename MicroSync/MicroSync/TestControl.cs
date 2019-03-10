using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MicroSync
{
    class TestControl : Control
    {
        public override string Name { get => "Test Control"; set => throw new NotImplementedException(); }
        public override string ID { get => "0000"; set => throw new NotImplementedException(); }
        public override string Version { get => "1.0.0"; set => throw new NotImplementedException(); }
        public override string Author { get => "Lincoln"; set => throw new NotImplementedException(); }
        
        public override void OnTap(object sender, TapGestureRecognizer e)
        {
            Debug.WriteLine("Single Tap Triggered!");
        }
    }
}
