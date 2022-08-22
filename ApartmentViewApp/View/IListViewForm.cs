using DevExpress.XtraEditors;
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
        /// <summary>
        /// 거래일자(년)
        /// </summary>
        DateTime DEAL_YMD { get; }
        /// <summary>
        /// 부산 지역코드
        /// </summary>
        object LAWD_CD { get; }
        /// <summary>
        /// 아파트 명
        /// </summary>
        string ApartmentName { get; set; }
        /// <summary>
        /// SplashScreenManager Show/Close를 위한 변수
        /// </summary>
        SplashScreenManager splash { get; set; }

        /// <summary>
        /// GridControl에 거래일자로 조회한 데이터 바인딩
        /// </summary>
        /// <param name="dtApartment">GridControl.DataSource에 바인딩 시킬 테이블</param>
        void LoadGridView(DataTable dtApartment);
        /// <summary>
        /// 부산 지역코드 ComboBox에 세팅
        /// </summary>
        /// <param name="dtLAWD">ComboBox의 DataSource에 바인딩 시킬 테이블</param>
        void SetLAWDComboBox(DataTable dtLAWD);
    }
}
