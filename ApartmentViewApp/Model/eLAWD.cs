using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentViewApp.Model
{
    class eLAWD
    {

        public enum eArea
        {
            eLAWD_CD_BUSAN
        }

        public enum eLAWD_CD_BUSAN
        {
            강서구 = 26440,
            금정구 = 26410,
            기장군 = 26710,
            남구 = 26290,
            동구 = 26170,
            동래구 = 26260,
            진구 = 26230,
            북구 = 26320,
            사상구 = 26530,
            사하구 = 26380,
            서구 = 26140,
            수영구 = 26500,
            연제구 = 26470,
            영도구 = 26200,
            중구 = 26110,
            해운대구 = 26350,
        }

        static public DataTable GetLAWD_CDToTable(eArea area)
        {
            DataTable dtLAWD = new DataTable();
            dtLAWD.Columns.Add("Code");
            dtLAWD.Columns.Add("CodeName");

            switch (area)
            {
                case eArea.eLAWD_CD_BUSAN:
                    List<eLAWD_CD_BUSAN> list = Enum.GetValues(typeof(eLAWD_CD_BUSAN)).OfType<eLAWD_CD_BUSAN>().ToList();
                    list.ForEach(code => dtLAWD.Rows.Add(new object[] { code.GetHashCode(), code.ToString() }));
                    break;

            }

            return dtLAWD;
        }
    }
}
