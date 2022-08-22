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
        /// <summary>
        /// SplashScreenManager Show/Close를 위한 변수
        /// </summary>
        SplashScreenManager splash { get; set; }

        /// <summary>
        /// Chart에 아파트 이름으로 필터된 데이터 바인딩
        /// </summary>
        /// <param name="dtApartmentByName">아파트 이름으로 필터된 테이블</param>
        /// <param name="apartmentName">아파트 이름</param>
        void LoadChartView(DataTable dtApartmentByName, string apartmentName);
    }
}
