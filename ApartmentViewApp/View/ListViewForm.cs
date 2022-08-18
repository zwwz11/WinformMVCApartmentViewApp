using ApartmentViewApp.Controller;
using ApartmentViewApp.View;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WinformMVCExample.Controller;
using WinformMVCExample.CommonInterface;
using ApartmentViewApp.Model;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Controls;

namespace ApartmentViewApp
{
    public partial class ListViewForm : XtraForm, IListViewForm
    {
        private ListViewController controller;
        private string targetURL = string.Empty;
        private string serviceKey = string.Empty;

        public DateTime DEAL_YMD { get { return deDEAL_YMD.DateTime; } }
        public object LAWD_CD { get { return comboLAWD_CD.EditValue; } }

        public ListViewForm()
        {
            InitializeComponent();
            deDEAL_YMD.DateTime = DateTime.Now;
        }

        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }
        void IControllerable.SetController(IController controller)
        {
            this.controller = controller as ListViewController;
        }
        public void LoadGridView(DataTable dtApartment)
        {
            gcList.DataSource = dtApartment;
        }
        public void SetLAWDComboBox(DataTable dtLAWD)
        {
            foreach (DataRow row in dtLAWD.Rows)
            {
                ImageComboBoxItem item = new ImageComboBoxItem();
                item.Description = $"{row["CodeName"]}";
                item.Value = $"{row["Code"]}";
                comboLAWD_CD.Properties.Items.Add(item);
            }
            comboLAWD_CD.SelectedIndex = 0;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            controller.Search();
        }

        private void gvList_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName != "No")
                return;

            e.DisplayText = $"{e.ListSourceRowIndex + 1}";
        }
    }
}
