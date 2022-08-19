﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentViewApp.Common.Comparer
{
    class StringDateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
}
