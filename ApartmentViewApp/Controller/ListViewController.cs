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
using WinformMVCExample.CommonInterface;
using WinformMVCExample.Controller;

namespace ApartmentViewApp.Controller
{
    class ListViewController : IController
    {
        private readonly string targetURL = ConfigurationManager.AppSettings["TargetURL"];
        private readonly string serviceKey = ConfigurationManager.AppSettings["ServiceKey"];
        private DataTable dtApartment = new DataTable();

        private IListViewForm view = null;

        public ListViewController(IListViewForm view)
        {
            this.view = view;
            view.SetController(this);
            view.SetLAWDComboBox(eLAWD.GetLAWD_CDToTable(eLAWD.eArea.eLAWD_CD_BUSAN));
            
            SetApartmentTableColumns();
            Search();
        }
        public void Search()
        {
            try
            {
                string xmlString = string.Empty;
                ApartmentRequestParam param = new ApartmentRequestParam();
                param.PageNo = "1";
                param.NumOfRows = "10000";
                param.LAWD_CD = $"{view.LAWD_CD}";
                param.DEAL_YMD = view.DEAL_YMD.ToString("yyyyMM");

                string url = GetTargetURL(param);

                WebClient client = new WebClient();
                using (Stream data = client.OpenRead(url))
                using (StreamReader reader = new StreamReader(data))
                {
                    xmlString = reader.ReadToEnd();
                }

                List<Apartment> apartmentList = new List<Apartment>();

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(xmlString);
                XmlNodeList list = xml.GetElementsByTagName("item");
                foreach (XmlNode node in list)
                {
                    Apartment apartment = new Apartment();
                    apartment.ApartmentName = node["아파트"].InnerText;
                    apartment.BuildYear = node["건축년도"].InnerText;
                    apartment.AreaForExclusiveUse = node["전용면적"].InnerText;
                    apartment.Floor = node["층"].InnerText;
                    apartment.DealYear = node["년"].InnerText;
                    apartment.DealMonth = node["월"].InnerText;
                    apartment.DealDay = node["일"].InnerText;
                    apartment.Dong = node["법정동"].InnerText;
                    apartment.DealAmount = node["거래금액"].InnerText;
                    apartment.Jibun = node["지번"].InnerText;
                    apartment.RegionalCode = node["지역코드"].InnerText;
                    apartment.CancelDealDay = node["해제사유발생일"].InnerText;
                    apartment.CancelDealType = node["해제여부"].InnerText;
                    apartmentList.Add(apartment);
                }

                DataTable dtApartment = GetParseApartmentToTable(apartmentList);
                view.LoadGridView(dtApartment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private DataTable GetParseApartmentToTable(List<Apartment> apartmentList)
        {
            dtApartment.Clear();

            foreach (Apartment apartment in apartmentList)
            {
                DataRow row = dtApartment.NewRow();
                row[nameof(Apartment.ApartmentName)] = apartment.ApartmentName;
                row[nameof(Apartment.BuildYear)] = apartment.BuildYear;
                row[nameof(Apartment.AreaForExclusiveUse)] = apartment.AreaForExclusiveUse;
                row[nameof(Apartment.Floor)] = apartment.Floor;
                row[nameof(Apartment.DealYear)] = apartment.DealYear;
                row[nameof(Apartment.DealMonth)] = apartment.DealMonth;
                row[nameof(Apartment.DealDay)] = apartment.DealDay;
                row[nameof(Apartment.Dong)] = apartment.Dong;
                row[nameof(Apartment.DealAmount)] = apartment.DealAmount;
                row[nameof(Apartment.Jibun)] = apartment.Jibun;
                row[nameof(Apartment.RegionalCode)] = apartment.RegionalCode;
                row[nameof(Apartment.CancelDealDay)] = apartment.CancelDealDay;
                row[nameof(Apartment.CancelDealType)] = apartment.CancelDealType;
                row["Dear"] = $"{apartment.DealYear}-{int.Parse(apartment.DealMonth):00}-{int.Parse(apartment.DealDay):00}";
                dtApartment.Rows.Add(row);
            }

            return dtApartment;
        }
        private void SetApartmentTableColumns()
        {
            dtApartment.Columns.Add(nameof(Apartment.ApartmentName));
            dtApartment.Columns.Add(nameof(Apartment.BuildYear));
            dtApartment.Columns.Add(nameof(Apartment.AreaForExclusiveUse));
            dtApartment.Columns.Add(nameof(Apartment.Floor));
            dtApartment.Columns.Add(nameof(Apartment.DealYear));
            dtApartment.Columns.Add(nameof(Apartment.DealMonth));
            dtApartment.Columns.Add(nameof(Apartment.DealDay));
            dtApartment.Columns.Add(nameof(Apartment.Dong));
            dtApartment.Columns.Add(nameof(Apartment.DealAmount));
            dtApartment.Columns.Add(nameof(Apartment.Jibun));
            dtApartment.Columns.Add(nameof(Apartment.RegionalCode));
            dtApartment.Columns.Add(nameof(Apartment.CancelDealDay));
            dtApartment.Columns.Add(nameof(Apartment.CancelDealType));
            dtApartment.Columns.Add("Dear");
        }
        private string GetTargetURL(ApartmentRequestParam param)
        {
            return $"{targetURL}?serviceKey={serviceKey}&pageNo={param.PageNo}&numOfRows={param.NumOfRows}&LAWD_CD={param.LAWD_CD}&DEAL_YMD={param.DEAL_YMD}";
        }
    }
}
