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
        SplashScreenManager splash { get; set; }

        void LoadChartView(DataTable dtApartmentByName, string apartmentName);
    }
}
