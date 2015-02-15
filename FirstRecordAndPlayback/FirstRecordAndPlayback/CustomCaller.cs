using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;

namespace FirstRecordAndPlayback
{
    public class CustomCaller
    {
        public static void Button8Click()
        {
            // Instance for WinWindow
            UITestControl calcWindow = new UITestControl();
            calcWindow.TechnologyName = "MSAA";
            calcWindow.SearchProperties[UITestControl.PropertyNames.Name] = "Calculator";
            calcWindow.SearchProperties[UITestControl.PropertyNames.ClassName] = "CalcFrame";

            //// Instance for WinWindow
            //WinWindow uiItemWindow = new WinWindow(calcWindow);
            //uiItemWindow.SearchProperties[WinWindow.PropertyNames.ControlId] = "138";

            // Instance for WinWindow
            UITestControl btn = new WinButton(calcWindow);
            btn.SearchProperties[UITestControl.PropertyNames.Name] = "8";

            Mouse.Click(btn);
        }

    }
}
