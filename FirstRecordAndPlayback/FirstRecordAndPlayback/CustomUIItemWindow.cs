using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRecordAndPlayback
{
    public class CustomUIItemWindow : WinWindow
    {
        // constructor
        public CustomUIItemWindow(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "138";
            this.WindowTitles.Add("Calculator");
            #endregion
        }

        #region Properties
        public WinButton UIItem8Button
        {
            get
            {
                if ((this.mUIItem8Button == null))
                {
                    this.mUIItem8Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem8Button.SearchProperties[WinButton.PropertyNames.Name] = "8";
                    this.mUIItem8Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItem8Button;
            }
        }
        #endregion

        #region Fields
        private WinButton mUIItem8Button;
        #endregion
    }
}
