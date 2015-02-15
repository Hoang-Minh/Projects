﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace FirstRecordAndPlayback
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// This method tests the addition of two numbers
        /// </summary>
        public void AdditionOperatoin()
        {
            #region Variable Declarations
            WinTitleBar uICalculatorTitleBar = this.UICalculatorWindow.UICalculatorTitleBar;
            WinButton uIItem8Button = this.UICalculatorWindow.UIItemWindow.UIItem8Button;
            WinButton uIItem9Button = this.UICalculatorWindow.UIItemWindow1.UIItem9Button;
            WinButton uIAddButton = this.UICalculatorWindow.UIItemWindow2.UIAddButton;
            WinButton uIItem2Button = this.UICalculatorWindow.UIItemWindow3.UIItem2Button;
            WinButton uIItem3Button = this.UICalculatorWindow.UIItemWindow4.UIItem3Button;
            WinButton uIEqualsButton = this.UICalculatorWindow.UIItemWindow5.UIEqualsButton;
            #endregion

            // Click 'Calculator' title bar
            Mouse.Click(uICalculatorTitleBar, new Point(20, 11));

            // Click '8' button
            Mouse.Click(uIItem8Button, new Point(24, 15));

            // Click '9' button
            Mouse.Click(uIItem9Button, new Point(16, 18));

            // Click 'Add' button
            Mouse.Click(uIAddButton, new Point(24, 10));

            // Click '2' button
            Mouse.Click(uIItem2Button, new Point(26, 17));

            // Click '3' button
            Mouse.Click(uIItem3Button, new Point(21, 14));

            // Click 'Equals' button
            Mouse.Click(uIEqualsButton, new Point(19, 29));
        }
        
        /// <summary>
        /// Asserting addition operation
        /// </summary>
        public void AssertAdd(string expData)
        {
            #region Variable Declarations
            WinText uIItem112Text = this.UICalculatorWindow.UIItem112Window.UIItem112TextProperty;
            #endregion

            // Verify that the 'DisplayText' property of '112' label equals '112'
            Assert.AreEqual(expData, uIItem112Text.DisplayText, "The value should be 112, else addition is not working properly");
        }
        
        #region Properties
        public virtual AssertAddExpectedValues AssertAddExpectedValues
        {
            get
            {
                if ((this.mAssertAddExpectedValues == null))
                {
                    this.mAssertAddExpectedValues = new AssertAddExpectedValues();
                }
                return this.mAssertAddExpectedValues;
            }
        }
        
        public UICalculatorWindow UICalculatorWindow
        {
            get
            {
                if ((this.mUICalculatorWindow == null))
                {
                    this.mUICalculatorWindow = new UICalculatorWindow();
                }
                return this.mUICalculatorWindow;
            }
        }
        #endregion
        
        #region Fields
        private AssertAddExpectedValues mAssertAddExpectedValues;
        
        private UICalculatorWindow mUICalculatorWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertAdd'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class AssertAddExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of '112' label equals '112'
        /// </summary>
        public string UIItem112TextDisplayText = "115";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UICalculatorWindow : WinWindow
    {
        
        public UICalculatorWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CalcFrame";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinTitleBar UICalculatorTitleBar
        {
            get
            {
                if ((this.mUICalculatorTitleBar == null))
                {
                    this.mUICalculatorTitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUICalculatorTitleBar.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUICalculatorTitleBar;
            }
        }
        
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIItemWindow2 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow2(this);
                }
                return this.mUIItemWindow2;
            }
        }
        
        public UIItemWindow3 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow3(this);
                }
                return this.mUIItemWindow3;
            }
        }
        
        public UIItemWindow4 UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow4(this);
                }
                return this.mUIItemWindow4;
            }
        }
        
        public UIItemWindow5 UIItemWindow5
        {
            get
            {
                if ((this.mUIItemWindow5 == null))
                {
                    this.mUIItemWindow5 = new UIItemWindow5(this);
                }
                return this.mUIItemWindow5;
            }
        }
        
        public UIItemWindow6 UIItemWindow6
        {
            get
            {
                if ((this.mUIItemWindow6 == null))
                {
                    this.mUIItemWindow6 = new UIItemWindow6(this);
                }
                return this.mUIItemWindow6;
            }
        }
        
        public UIItem112Window UIItem112Window
        {
            get
            {
                if ((this.mUIItem112Window == null))
                {
                    this.mUIItem112Window = new UIItem112Window(this);
                }
                return this.mUIItem112Window;
            }
        }
        #endregion
        
        #region Fields
        private WinTitleBar mUICalculatorTitleBar;
        
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UIItemWindow2 mUIItemWindow2;
        
        private UIItemWindow3 mUIItemWindow3;
        
        private UIItemWindow4 mUIItemWindow4;
        
        private UIItemWindow5 mUIItemWindow5;
        
        private UIItemWindow6 mUIItemWindow6;
        
        private UIItem112Window mUIItem112Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "139";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIItem9Button
        {
            get
            {
                if ((this.mUIItem9Button == null))
                {
                    this.mUIItem9Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem9Button.SearchProperties[WinButton.PropertyNames.Name] = "9";
                    this.mUIItem9Button.WindowTitles.Add("Calculator");
                    Console.WriteLine("The friendly name of the control is " + this.mUIItem9Button.GetProperty(WinButton.PropertyNames.FriendlyName));

                    Console.WriteLine("If the control exits " + this.mUIItem9Button.GetProperty(WinButton.PropertyNames.Exists));
                    #endregion
                }
                return this.mUIItem9Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItem9Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "93";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIAddButton
        {
            get
            {
                if ((this.mUIAddButton == null))
                {
                    this.mUIAddButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIAddButton.SearchProperties[WinButton.PropertyNames.Name] = "Add";
                    this.mUIAddButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIAddButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIAddButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIItemWindow3 : WinWindow
    {
        
        public UIItemWindow3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "132";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIItem2Button
        {
            get
            {
                if ((this.mUIItem2Button == null))
                {
                    this.mUIItem2Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem2Button.SearchProperties[WinButton.PropertyNames.Name] = "2";
                    this.mUIItem2Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItem2Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItem2Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIItemWindow4 : WinWindow
    {
        
        public UIItemWindow4(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "133";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIItem3Button
        {
            get
            {
                if ((this.mUIItem3Button == null))
                {
                    this.mUIItem3Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem3Button.SearchProperties[WinButton.PropertyNames.Name] = "3";
                    this.mUIItem3Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItem3Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItem3Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIItemWindow5 : WinWindow
    {
        
        public UIItemWindow5(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "121";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIEqualsButton
        {
            get
            {
                if ((this.mUIEqualsButton == null))
                {
                    this.mUIEqualsButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIEqualsButton.SearchProperties[WinButton.PropertyNames.Name] = "Equals";
                    this.mUIEqualsButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIEqualsButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIEqualsButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIItemWindow6 : WinWindow
    {
        
        public UIItemWindow6(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "137";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIItem7Button
        {
            get
            {
                if ((this.mUIItem7Button == null))
                {
                    this.mUIItem7Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem7Button.SearchProperties[WinButton.PropertyNames.Name] = "7";
                    this.mUIItem7Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItem7Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItem7Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIItem112Window : WinWindow
    {
        
        public UIItem112Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "150";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinText UIItem112TextProperty
        {
            get
            {
                if ((this.mUIItem112Text == null))
                {
                    this.mUIItem112Text = new WinText(this);
                    #region Search Criteria
                    this.mUIItem112Text.SearchProperties[WinText.PropertyNames.Name] = "Result";
                    this.mUIItem112Text.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItem112Text;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIItem112Text;
        #endregion
    }
}
