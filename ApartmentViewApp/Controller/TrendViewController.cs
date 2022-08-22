using ApartmentViewApp.Common.Utill;
using ApartmentViewApp.Model;
using ApartmentViewApp.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WinformMVCExample.Controller;

namespace ApartmentViewApp.Controller
{
    class TrendViewController : IController
    {
        private ITrendViewForm view = null;

        public TrendViewController(ITrendViewForm view)
        {
            this.view = view;
            this.view.SetController(this);
        }
        public void Load(DataTable dtApartmentByName, string apartmentName)
        {
            view.LoadChartView(dtApartmentByName, apartmentName);
        }
    }
}
