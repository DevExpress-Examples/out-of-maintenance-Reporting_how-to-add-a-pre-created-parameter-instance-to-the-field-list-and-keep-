using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.Parameters;

namespace Parameters {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Parameter parameter = new Parameter();
            parameter.Name = "MyDateTimeParameter";
            parameter.Type = typeof(DateTime);
            xrDesignPanel1.Report.Parameters.Add(parameter);
            AddField(parameter, "MyParameter");
        }

        private void AddField(IComponent objeto, string desiredName) {
            IDesignerHost host = xrDesignPanel1.GetService(typeof(IDesignerHost)) as IDesignerHost;
            if (host != null) {
#pragma warning disable CS0612 // Type or member is obsolete
                DesignToolHelper.AddToContainer(host, objeto, desiredName);
#pragma warning restore CS0612 // Type or member is obsolete
            }
        }
    }
}
