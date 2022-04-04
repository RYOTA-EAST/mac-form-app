using System;

using AppKit;
using Foundation;

namespace macformapp
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            label1.StringValue = "Hello world";
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void button1_clicked(Foundation.NSObject sender)
        {
            label1.StringValue += string.Format(textfield1.StringValue + "\r\n");
        }
    }
}
