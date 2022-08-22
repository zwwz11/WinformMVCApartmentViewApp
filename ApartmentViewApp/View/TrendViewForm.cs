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

        public readonly DataTable dtApartmentByName;
        public readonly string apartmentName;
        public SplashScreenManager splash
        {
            get { return splashScreenManager; }
            set { splashScreenManager = value; }
        }

        public TrendViewForm()
        {
            InitializeComponent();
        }
        public TrendViewForm(DataTable dtApartmentByName, string apartmentName) : this()
        {
            this.dtApartmentByName = dtApartmentByName;
            this.apartmentName = apartmentName;
        }
        void IControllerable.SetController(IController controller)
        {
            this.controller = controller as TrendViewController;
        }
        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }


        public void LoadChartView(DataTable dtApartmentByName, string apartmentName)
        {
            chart.Series.Clear();
            
            Series series = new Series(apartmentName, ViewType.Line);
            series.DataSource = dtApartmentByName;
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.ArgumentDataMember = dtApartmentByName.Columns[nameof(Apartment.Deal)].ColumnName;
            series.ValueDataMembers.AddRange(new string[] { dtApartmentByName.Columns[nameof(Apartment.DealAmount)].ColumnName });
            chart.Series.Add(series);

            XYDiagram diagram = chart.Diagram as XYDiagram;
            if (diagram != null)
            {
                diagram.AxisX.QualitativeScaleComparer = new StringDateComparer();
            }
        }

        private void TrendViewForm_Load(object sender, EventArgs e)
        {
            controller.Load(dtApartmentByName, apartmentName);
        }
    }
}
