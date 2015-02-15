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
        public void Button8Click()
        {
            // Create an instance for Calc Window
            CustomCalcWindow calcWindow = new CustomCalcWindow();

            // Create an instance for CustomUIItemWindow
            CustomUIItemWindow cusItemWind = new CustomUIItemWindow(calcWindow);

            Mouse.Click(cusItemWind.UIItem8Button);
        }

    }
}
