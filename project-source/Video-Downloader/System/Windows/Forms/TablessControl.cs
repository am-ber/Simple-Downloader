using System;
using System.Windows.Forms;

namespace System.Windows.Forms
{
	public class TablessControl : TabControl
	{
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x1328)
				m.Result = (IntPtr)1;
			else
				base.WndProc(ref m);
		}
    }
}

