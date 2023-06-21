using DoAn_QL_Karaoke;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalDecisions
{
    internal class Windows
    {
        internal class Forms
        {
            public static object ToolPanelViewType { get; internal set; }

            internal class CrystalReportViewer
            {
                public CrystalReportViewer()
                {
                }

                public int ActiveViewIndex { get; internal set; }
                public BorderStyle BorderStyle { get; internal set; }
                public Cursor Cursor { get; internal set; }
                public DockStyle Dock { get; internal set; }
                public Point Location { get; internal set; }
                public string Name { get; internal set; }
                public Size Size { get; internal set; }
                public int TabIndex { get; internal set; }
                public Xuathoadon ReportSource { get; internal set; }
                public object ToolPanelView { get; internal set; }

                public static explicit operator Control(CrystalReportViewer v)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}