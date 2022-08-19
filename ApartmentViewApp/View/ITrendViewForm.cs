using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformMVCExample.CommonInterface;

namespace ApartmentViewApp.View
{
    interface ITrendViewForm : IControllerable, IMessageable
    {
        DateTime DEAL_YMD { get; }
        object LAWD_CD { get; }
        string ApartmentName { get; set; }
        SplashScreenManager splash { get; set; }

        void LoadChartView(DataTable dtApartment, List<string> distApartmentList);
        void SetLAWDComboBox(DataTable dtLAWD);
    }
}
