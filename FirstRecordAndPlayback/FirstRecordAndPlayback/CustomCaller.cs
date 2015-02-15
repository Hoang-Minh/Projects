using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;

namespace FirstRecordAndPlayback
{
    public class CustomCaller
    {
        public static void Button8Click()
        {
            // Instance for WinWindow
            WinWindow calcWindow = new WinWindow();
            calcWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            calcWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "CalcFrame";

            //// Instance for WinWindow
            //WinWindow uiItemWindow = new WinWindow(calcWindow);
            //uiItemWindow.SearchProperties[WinWindow.PropertyNames.ControlId] = "138";

            // Instance for WinWindow
            WinButton btn = new WinButton(calcWindow);
            btn.SearchProperties[WinWindow.PropertyNames.Name] = "8";

            Mouse.Click(btn);
        }

    }
}
