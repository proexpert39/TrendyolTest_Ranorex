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
    ///The CloseBrowser recording.
    /// </summary>
    [TestModule("528ab128-e5c7-4d0e-acf9-bd225d141d89", ModuleType.Recording, 1)]
    public partial class CloseBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TrendyolTestRepository repository.
        /// </summary>
        public static TrendyolTestRepository repo = TrendyolTestRepository.Instance;

        static CloseBrowser instance = new CloseBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseBrowser()
        {
            BrowserPID = "-1";
            isLoggedIn = "false";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseBrowser Instance
        {
            get { return instance; }
        }

#region Variables

        string _BrowserPID;

        /// <summary>
        /// Gets or sets the value of variable BrowserPID.
        /// </summary>
        [TestVariable("d51ab651-28b4-45ea-90b1-01941df24bbf")]
        public string BrowserPID
        {
            get { return _BrowserPID; }
            set { _BrowserPID = value; }
        }

        string _isLoggedIn;

        /// <summary>
        /// Gets or sets the value of variable isLoggedIn.
        /// </summary>
        [TestVariable("2f082654-d187-4a65-a3bc-a72a7ef6239d")]
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

            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'trendyol'.", repo.trendyol.SelfInfo, new RecordItemIndex(0));
                Validate.Exists(repo.trendyol.SelfInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Application", "(Optional Action)\r\nClosing application containing item 'trendyol'.", repo.trendyol.SelfInfo, new RecordItemIndex(1));
                Host.Current.CloseApplication(repo.trendyol.Self, new Duration(0));
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
