using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentViewApp.Model
{
    class Apartment
    {
        /// <summary>
        /// 아파트
        /// </summary>
        public string ApartmentName { get; set; }
        /// <summary>
        /// 건축년도
        /// </summary>
        public string BuildYear { get; set; }
        /// <summary>
        /// 층
        /// </summary>
        public string Floor { get; set; }
        /// <summary>
        /// 전용면적
        /// </summary>
        public string AreaForExclusiveUse { get; set; }
        /// <summary>
        /// 지번
        /// </summary>
        public string Jibun { get; set; }
        /// <summary>
        /// 동
        /// </summary>
        public string Dong { get; set; }
        /// <summary>
        /// 지역코드
        /// </summary>
        public string RegionalCode { get; set; }
        /// <summary>
        /// 거래금액
        /// </summary>
        public string DealAmount { get; set; }
        /// <summary>
        /// 거래(년)
        /// </summary>
        public string DealYear { get; set; }
        /// <summary>
        /// 거래(월)
        /// </summary>
        public string DealMonth { get; set; }
        /// <summary>
        /// 거래(일)
        /// </summary>
        public string DealDay { get; set; }
        /// <summary>
        /// 해제여부
        /// </summary>
        public string CancelDealType { get; set; }
        /// <summary>
        /// 해제사유발생일
        /// </summary>
        public string CancelDealDay { get; set; }

    }
}
