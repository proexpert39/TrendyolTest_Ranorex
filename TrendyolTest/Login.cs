///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TrendyolTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Login recording.
    /// </summary>
    [TestModule("da7341ca-6f1c-4ead-88ac-c34a680560cd", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TrendyolTestRepository repository.
        /// </summary>
        public static TrendyolTestRepository repo = TrendyolTestRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            InputEmail = "alperenkumcu@gmail.com";
            InputPassword = "23mSBg9nC&v9nnR";
            isLoggedIn = "false";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _InputEmail;

        /// <summary>
        /// Gets or sets the value of variable InputEmail.
        /// </summary>
        [TestVariable("3e12afe3-7283-47a2-8aa1-4bffa4c6d145")]
        public string InputEmail
        {
            get { return _InputEmail; }
            set { _InputEmail = value; }
        }

        string _InputPassword;

        /// <summary>
        /// Gets or sets the value of variable InputPassword.
        /// </summary>
        [TestVariable("dd158856-b362-4024-997b-e58850145375")]
        public string InputPassword
        {
            get { return _InputPassword; }
            set { _InputPassword = value; }
        }

        string _isLoggedIn;

        /// <summary>
        /// Gets or sets the value of variable isLoggedIn.
        /// </summary>
        [TestVariable("9f5fb931-f342-4e1e-ae07-038803516458")]
        public string isLoggedIn
        {
            get { return _isLoggedIn; }
            set { _isLoggedIn = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // Go to Login Page
            Report.Log(ReportLevel.Info, "Section", "Go to Login Page", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'trendyol.LoginButton'.", repo.trendyol.LoginButtonInfo, new RecordItemIndex(1));
            Validate.Exists(repo.trendyol.LoginButtonInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'trendyol.LoginButton'.", repo.trendyol.LoginButtonInfo, new RecordItemIndex(2));
            repo.trendyol.LoginButton.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'trendyol.LoginButton'.", repo.trendyol.LoginButtonInfo, new RecordItemIndex(3));
            repo.trendyol.LoginButton.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'trendyol'.", repo.trendyol.SelfInfo, new RecordItemIndex(4));
            repo.trendyol.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            // Email input
            Report.Log(ReportLevel.Info, "Section", "Email input", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'trendyol.LoginPage.LoginEmailInput'.", repo.trendyol.LoginPage.LoginEmailInputInfo, new RecordItemIndex(7));
            Validate.Exists(repo.trendyol.LoginPage.LoginEmailInputInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'trendyol.LoginPage.LoginEmailInput'.", repo.trendyol.LoginPage.LoginEmailInputInfo, new RecordItemIndex(8));
            repo.trendyol.LoginPage.LoginEmailInput.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'trendyol.LoginPage.LoginEmailInput'.", repo.trendyol.LoginPage.LoginEmailInputInfo, new RecordItemIndex(9));
            repo.trendyol.LoginPage.LoginEmailInput.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$InputEmail'.", new RecordItemIndex(10));
            Keyboard.Press(InputEmail);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$InputEmail) on item 'trendyol.LoginPage.LoginEmailInput'.", repo.trendyol.LoginPage.LoginEmailInputInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.trendyol.LoginPage.LoginEmailInputInfo, "Value", InputEmail);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            Delay.Duration(1000, false);
            
            // Password input
            Report.Log(ReportLevel.Info, "Section", "Password input", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'trendyol.LoginPage.LoginPasswordInput'.", repo.trendyol.LoginPage.LoginPasswordInputInfo, new RecordItemIndex(15));
            Validate.Exists(repo.trendyol.LoginPage.LoginPasswordInputInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'trendyol.LoginPage.LoginPasswordInput'.", repo.trendyol.LoginPage.LoginPasswordInputInfo, new RecordItemIndex(16));
            repo.trendyol.LoginPage.LoginPasswordInput.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'trendyol.LoginPage.LoginPasswordInput'.", repo.trendyol.LoginPage.LoginPasswordInputInfo, new RecordItemIndex(17));
            repo.trendyol.LoginPage.LoginPasswordInput.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$InputPassword'.", new RecordItemIndex(18));
            Keyboard.Press(InputPassword);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(19));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$InputPassword) on item 'trendyol.LoginPage.LoginPasswordInput'.", repo.trendyol.LoginPage.LoginPasswordInputInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.trendyol.LoginPage.LoginPasswordInputInfo, "Value", InputPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(1000, false);
            
            // Click Login Button
            Report.Log(ReportLevel.Info, "Section", "Click Login Button", new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'trendyol.LoginPage.LoginBtn'.", repo.trendyol.LoginPage.LoginBtnInfo, new RecordItemIndex(23));
            repo.trendyol.LoginPage.LoginBtn.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'trendyol.LoginPage.LoginBtn'.", repo.trendyol.LoginPage.LoginBtnInfo, new RecordItemIndex(24));
            repo.trendyol.LoginPage.LoginBtn.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(25));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'trendyol'.", repo.trendyol.SelfInfo, new RecordItemIndex(26));
            repo.trendyol.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // Validate if logged in
            Report.Log(ReportLevel.Info, "Section", "Validate if logged in", new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'trendyol.MyAccountButton'.", repo.trendyol.MyAccountButtonInfo, new RecordItemIndex(28));
            Validate.Exists(repo.trendyol.MyAccountButtonInfo);
            Delay.Milliseconds(100);
            
            setLoggedIn(null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", isLoggedIn, new RecordItemIndex(30));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
