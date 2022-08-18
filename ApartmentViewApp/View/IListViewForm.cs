using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformMVCExample.CommonInterface;

namespace ApartmentViewApp.View
{
    interface IListViewForm : IMessageable, IControllerable
    {
        DateTime DEAL_YMD { get; }
        object LAWD_CD { get; }

        void LoadGridView(DataTable dtApartment);
        void SetLAWDComboBox(DataTable dtLAWD);
    }
}
