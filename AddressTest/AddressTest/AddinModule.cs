using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using AddinExpress.MSO;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace AddressTest
{
    /// <summary>
    ///   Add-in Express Add-in Module
    /// </summary>
    [GuidAttribute("EA1F8CB4-D656-4E53-88DC-C629BC99FDAB"), ProgId("AddressTest.AddinModule")]
    public class AddinModule : AddinExpress.MSO.ADXAddinModule
    {
        public AddinModule()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            // Please add any initialization code to the AddinInitialize event handler
        }

        private ADXRibbonTab adxRibbonTab1;
        private ADXRibbonGroup adxRibbonGroup1;
        private ADXRibbonButton adxRibbonButtonEdit;
        private ADXRibbonButton adxRibbonButton1;
 
        #region Component Designer generated code
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
        /// <summary>
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.adxRibbonTab1 = new AddinExpress.MSO.ADXRibbonTab(this.components);
            this.adxRibbonGroup1 = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.adxRibbonButtonEdit = new AddinExpress.MSO.ADXRibbonButton(this.components);
            this.adxRibbonButton1 = new AddinExpress.MSO.ADXRibbonButton(this.components);
            // 
            // adxRibbonTab1
            // 
            this.adxRibbonTab1.Caption = "Address Test";
            this.adxRibbonTab1.Controls.Add(this.adxRibbonGroup1);
            this.adxRibbonTab1.Id = "adxRibbonTab_04b52d71c4a9414798ec41c0c5c78532";
            this.adxRibbonTab1.IdMso = "TabNewMailMessage";
            this.adxRibbonTab1.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose;
            // 
            // adxRibbonGroup1
            // 
            this.adxRibbonGroup1.Caption = "Address Test";
            this.adxRibbonGroup1.Controls.Add(this.adxRibbonButtonEdit);
            this.adxRibbonGroup1.Id = "adxRibbonGroup_3615b0860eaa4941b1d8dc6aca92cf90";
            this.adxRibbonGroup1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonGroup1.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose;
            // 
            // adxRibbonButtonEdit
            // 
            this.adxRibbonButtonEdit.Caption = "Edit";
            this.adxRibbonButtonEdit.Id = "adxRibbonButton_20ad843d8fc64963be8514e38a316df9";
            this.adxRibbonButtonEdit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonButtonEdit.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose;
            this.adxRibbonButtonEdit.Size = AddinExpress.MSO.ADXRibbonXControlSize.Large;
            this.adxRibbonButtonEdit.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxRibbonButtonEdit_OnClick);
            // 
            // adxRibbonButton1
            // 
            this.adxRibbonButton1.Caption = "Edit w/o resolve";
            this.adxRibbonButton1.Id = "adxRibbonButton_44100c1062ef4510a0ea9afd87130287";
            this.adxRibbonButton1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonButton1.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose;
            this.adxRibbonButton1.Size = AddinExpress.MSO.ADXRibbonXControlSize.Large;
            // 
            // AddinModule
            // 
            this.AddinName = "AddressTest";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaOutlook;

        }
        #endregion
 
        #region Add-in Express automatic code
 
        // Required by Add-in Express - do not modify
        // the methods within this region
 
        public override System.ComponentModel.IContainer GetContainer()
        {
            if (components == null)
                components = new System.ComponentModel.Container();
            return components;
        }
 
        [ComRegisterFunctionAttribute]
        public static void AddinRegister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXRegister(t);
        }
 
        [ComUnregisterFunctionAttribute]
        public static void AddinUnregister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXUnregister(t);
        }
 
        public override void UninstallControls()
        {
            base.UninstallControls();
        }

        #endregion

        public static new AddinModule CurrentInstance 
        {
            get
            {
                return AddinExpress.MSO.ADXAddinModule.CurrentInstance as AddinModule;
            }
        }

        public Outlook._Application OutlookApp
        {
            get
            {
                return (HostApplication as Outlook._Application);
            }
        }

        private void adxRibbonButtonEdit_OnClick(object sender, IRibbonControl control, bool pressed)
        {
            Outlook.Inspector inspector = null;
            Outlook.MailItem mailItem = null;
            try
            {
                inspector = OutlookApp.ActiveInspector();
                if (null != inspector)
                {
                    mailItem = (Outlook.MailItem)inspector.CurrentItem;
                    EditForm form = new EditForm(mailItem);
                    form.ShowDialog();
                }
            }
            finally
            {
                if (null != mailItem)
                {
                    Marshal.ReleaseComObject(mailItem);
                }
                if (null != inspector)
                {
                    Marshal.ReleaseComObject(inspector);
                }
            }
        }


    }
}

