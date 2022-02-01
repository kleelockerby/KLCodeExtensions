using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.Imaging.Interop;

namespace KLCodeExtensions
{
    [Guid(WinformsToolWindow.ToolWindowId)]
    public class WinformsToolWindow : ToolWindowPane
    {
        public const string ToolWindowId = "bdaf0fe9-88d5-418d-b6be-c2d91efcf38c";
        public WinformsToolWindowControl control;
        public const string Title = "Sample Tool Window";

        public WinformsToolWindow() : this(null) { }

        public WinformsToolWindow(WinformsToolWindowData data) : base()
        {
            this.Caption = "WinformsToolWindow";
            this.BitmapImageMoniker = new ImageMoniker { Guid = PackageGuids.guidImages, Id = 2 };
            this.control = new WinformsToolWindowControl(data);
        }
        public override IWin32Window Window
        {
            get { return (IWin32Window)control; }
        }
    }
}