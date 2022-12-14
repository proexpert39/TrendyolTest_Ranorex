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
    ///The AddToCart recording.
    /// </summary>
    [TestModule("b26515fe-4cd1-4099-b3c7-e6127a6c7083", ModuleType.Recording, 1)]
    public partial class AddToCart : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TrendyolTestRepository repository.
        /// </summary>
        public static TrendyolTestRepository repo = TrendyolTestRepository.Instance;

        static AddToCart instance = new AddToCart();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddToCart()
        {
            ProductName = "iphone 11";
            CartProductsCount = "0";
            CardProductsCountAfter = "0";
            CardProductsCountBefore = "0";
            SearchKeyword = "iphone 11";
            ProductName_Cart = "";
            CartUrl = "https://www.trendyol.com/sepet";
            BodyInnerText = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddToCart Instance
        {
            get { return instance; }
        }

#region Variables

        string _ProductName;

        /// <summary>
        /// Gets or sets the value of variable ProductName.
        /// </summary>
        [TestVariable("54006aca-5f1b-49fc-b755-569d2461c6ca")]
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        string _CartProductsCount;

        /// <summary>
        /// Gets or sets the value of variable CartProductsCount.
        /// </summary>
        [TestVariable("d77b2691-f09a-4daa-ac62-ed340843a803")]
        public string CartProductsCount
        {
            get { return _CartProductsCount; }
            set { _CartProductsCount = value; }
        }

        string _CardProductsCountAfter;

        /// <summary>
        /// Gets or sets the value of variable CardProductsCountAfter.
        /// </summary>
        [TestVariable("995aee8e-cefa-46cc-b86f-34cffd6710c0")]
        public string CardProductsCountAfter
        {
            get { return _CardProductsCountAfter; }
            set { _CardProductsCountAfter = value; }
        }

        string _CardProductsCountBefore;

        /// <summary>
        /// Gets or sets the value of variable CardProductsCountBefore.
        /// </summary>
        [TestVariable("eb4b8d0f-29d7-49dc-8b57-9495aa05422a")]
        public string CardProductsCountBefore
        {
            get { return _CardProductsCountBefore; }
            set { _CardProductsCountBefore = value; }
        }

        string _SearchKeyword;

        /// <summary>
        /// Gets or sets the value of variable SearchKeyword.
        /// </summary>
        [TestVariable("b58a28c9-300f-4a38-b309-12cbb2ab20e2")]
        public string SearchKeyword
        {
            get { return _SearchKeyword; }
            set { _SearchKeyword = value; }
        }

        string _ProductName_Cart;

        /// <summary>
        /// Gets or sets the value of variable ProductName_Cart.
        /// </summary>
        [TestVariable("beec0769-561f-4887-a0c4-b666e37939cd")]
        public string ProductName_Cart
        {
            get { return _ProductName_Cart; }
            set { _ProductName_Cart = value; }
        }

        string _CartUrl;

        /// <summary>
        /// Gets or sets the value of variable CartUrl.
        /// </summary>
        [TestVariable("e43a21ba-5499-4059-97c8-44d0b96a499f")]
        public string CartUrl
        {
            get { return _CartUrl; }
            set { _CartUrl = value; }
        }

        string _BodyInnerText;

        /// <summary>
        /// Gets or sets the value of variable BodyInnerText.
        /// </summary>
        [TestVariable("430061e4-0e8d-4a26-9a21-2f8d11333e6a")]
        public string BodyInnerText
        {
            get { return _BodyInnerText; }
            set { _BodyInnerText = value; }
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

            // Add to cart the product
            Report.Log(ReportLevel.Info, "Section", "Add to cart the product", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'trendyol.AddToCartButton'.", repo.trendyol.AddToCartButtonInfo, new RecordItemIndex(1));
            repo.trendyol.AddToCartButton.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
