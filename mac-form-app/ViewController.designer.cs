// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace macformapp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField label1 { get; set; }

		[Outlet]
		AppKit.NSTextField textfield1 { get; set; }

		[Action ("button1_clicked:")]
		partial void button1_clicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (textfield1 != null) {
				textfield1.Dispose ();
				textfield1 = null;
			}

			if (label1 != null) {
				label1.Dispose ();
				label1 = null;
			}
		}
	}
}
