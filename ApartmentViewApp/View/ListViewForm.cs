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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid;

namespace ApartmentViewApp
{
    public partial class ListViewForm : XtraForm, IListViewForm
    {
        private ListViewController controller;

        /* 인터페이스 프로퍼티 */
        public DateTime DEAL_YMD => deDEAL_YMD.DateTime;
        public object LAWD_CD => comboLAWD_CD.EditValue;
        public string ApartmentName
        {
            get { return txtApartmentName.Text; }
            set { txtApartmentName.Text = value; }
        }
        public SplashScreenManager splash
        {
            get { return splashScreenManager; }
            set { splashScreenManager = value; }
        }


        /* Controller 세팅 및 공통 인터페이스 기능 */
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

        /* 인터페이스 메소드 */
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


        /* 이벤트 */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            controller.Search();
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            controller.ExportExcel(gcList);
        }
        private void gvList_RowClick(object sender, RowClickEventArgs e)
        {
            if(e.Clicks > 1)
            {
                DataTable dtApartment = gcList.DataSource as DataTable;
                string apartmentName = $"{gvList.GetFocusedRowCellValue("ApartmentName")}";
                controller.LoadTrendViewForm(dtApartment, apartmentName);
            }
        }
        private void gvList_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName != "No")
                return;

            e.DisplayText = $"{e.ListSourceRowIndex + 1}";
        }

    }
}
