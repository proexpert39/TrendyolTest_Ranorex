﻿///////////////////////////////////////////////////////////////////////////////
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
    ///The VerifyMandatoryFieldsExists recording.
    /// </summary>
    [TestModule("6b75094d-ce25-4cde-b9db-b40c572b2d83", ModuleType.Recording, 1)]
    public partial class VerifyMandatoryFieldsExists : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TrendyolTestRepository repository.
        /// </summary>
        public static TrendyolTestRepository repo = TrendyolTestRepository.Instance;

        static VerifyMandatoryFieldsExists instance = new VerifyMandatoryFieldsExists();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyMandatoryFieldsExists()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyMandatoryFieldsExists Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'trendyol'.", repo.trendyol.SelfInfo, new RecordItemIndex(0));
            repo.trendyol.Self.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='') on item 'trendyol.RegisterPage.RegisterEmailInput'.", repo.trendyol.RegisterPage.RegisterEmailInputInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.trendyol.RegisterPage.RegisterEmailInputInfo, "Value", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='') on item 'trendyol.RegisterPage.RegisterPasswordInput'.", repo.trendyol.RegisterPage.RegisterPasswordInputInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.trendyol.RegisterPage.RegisterPasswordInputInfo, "Value", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='false') on item 'trendyol.RegisterPage.MarketingEmailCheckboxDiv'.", repo.trendyol.RegisterPage.MarketingEmailCheckboxDivInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.trendyol.RegisterPage.MarketingEmailCheckboxDivInfo, "TagValue", "false");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='false') on item 'trendyol.PersonalDataCheckboxDiv'.", repo.trendyol.PersonalDataCheckboxDivInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.trendyol.PersonalDataCheckboxDivInfo, "TagValue", "false");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'trendyol.RegisterPage.RegisterButton'.", repo.trendyol.RegisterPage.RegisterButtonInfo, new RecordItemIndex(5));
            repo.trendyol.RegisterPage.RegisterButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Visible='true') on item 'trendyol.ErrorBoxWrapper'.", repo.trendyol.ErrorBoxWrapperInfo, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.trendyol.ErrorBoxWrapperInfo, "Visible", "true", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
