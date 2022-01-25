using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Imaging.Interop;

namespace KLCodeExtensions
{
    [Guid(CodeLayoutToolWindow.ToolWindowId)]
    public class CodeLayoutToolWindow : ToolWindowPane
    {
        internal const string ToolWindowId = "906e4b7c-e763-49a4-ab40-fa9cc272bc1a";

        public CodeLayoutToolWindow() : this(null) { }

        public CodeLayoutToolWindow(CodeLayoutToolWindowData data) : base(null)
        {
            this.Caption = "Code Layout";
            BitmapImageMoniker = new ImageMoniker { Guid = PackageGuids.guidImages, Id = 2, };
            this.Content = new CodeLayoutToolWindowControl(data);
        }
    }
}
