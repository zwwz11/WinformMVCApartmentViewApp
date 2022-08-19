﻿using DevExpress.XtraEditors;
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
    interface IListViewForm : IControllerable, IMessageable
    {
        DateTime DEAL_YMD { get; }
        object LAWD_CD { get; }
        string ApartmentName { get; set; }
        SplashScreenManager splash { get; set; }

        void LoadGridView(DataTable dtApartment);
        void SetLAWDComboBox(DataTable dtLAWD);
    }
}
