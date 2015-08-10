
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using AutomatedReportingSystem.Business.Interfaces;

namespace AutomatedReportingSystem.Business.Common
{
    public class CommonUtilities : ICommonUtilities
    {
        public IList<string> Split(string input)
        {
            return input.Split('\t').ToList();
        }

        public static string FormatDateToDisplayFromService(object dateTime)
        {
            string strDt = Convert.ToString(dateTime);
            if (strDt.Length == 0) return string.Empty;
            DateTime dt;
            DateTime.TryParse(strDt, out dt);
            if (dt == DateTime.MinValue)
            {
                
            }
            if (dt != DateTime.MinValue)

                return dt.ToString(ConfigurationManager.AppSettings["DisplayDateFormat"]);
            return string.Empty;
        }
    }
}
