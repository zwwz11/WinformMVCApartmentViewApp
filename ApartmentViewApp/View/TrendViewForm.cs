using ApartmentViewApp.Common.Comparer;
using ApartmentViewApp.Controller;
using ApartmentViewApp.Model;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformMVCExample.CommonInterface;
using WinformMVCExample.Controller;

namespace ApartmentViewApp.View
{
    public partial class TrendViewForm : XtraForm, ITrendViewForm
    {
        private TrendViewController controller = null;

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

        public TrendViewForm()
        {
            InitializeComponent();

            deDEAL_YMD.DateTime = DateTime.Now;
        }
        public TrendViewForm(DataTable dtApartment) : this()
        {

        }
        void IControllerable.SetController(IController controller)
        {
            this.controller = controller as TrendViewController;
        }
        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }


        public void LoadChartView(DataTable dtApartment, List<string> distApartmentList)
        {
            chart.Series.Clear();
            foreach(string apartmentName in distApartmentList)
            {
                Series series = new Series(apartmentName, ViewType.Line);
                DataTable dtFilterApartment = dtApartment.AsEnumerable().Where(x => $"{x[nameof(Apartment.ApartmentName)]}" == apartmentName).CopyToDataTable();
                series.DataSource = dtFilterApartment;
                series.ArgumentScaleType = ScaleType.Qualitative;
                series.ArgumentDataMember = dtFilterApartment.Columns[nameof(Apartment.Deal)].ColumnName;
                series.ValueDataMembers.AddRange(new string[] { dtFilterApartment.Columns[nameof(Apartment.DealAmount)].ColumnName });
                chart.Series.Add(series);
            }

            XYDiagram diagram = chart.Diagram as XYDiagram;
            if (diagram != null)
            {
                diagram.AxisX.QualitativeScaleComparer = new StringDateComparer();
            }
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
    }
}
