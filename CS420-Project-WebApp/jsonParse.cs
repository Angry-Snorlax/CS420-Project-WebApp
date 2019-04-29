using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CS420_Project_WebApp
{
    public class JsonParse
{
        public static string title;
        public static string fCurCodeTitle;
        public static string fCurCode;
        public static string fCurNameTitle;
        public static string fCurName;
        public static string toCurCodeTitle;
        public static string toCurCode;
        public static string toCurNameTitle;
        public static string toCurName;
        public static string excRateTitle;
        public static string excRate;
        public static string lastRefTitle;
        public static string lastRef;
        public static string timeTitle;
        public static string time;

        public JsonParse(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o)
        {
            title = a;
            fCurCodeTitle = b;
            fCurCode = c;
            fCurNameTitle = d;
            fCurName = e;
            toCurCodeTitle = f;
            toCurCode = g;
            toCurNameTitle = h;
            toCurName = i;
            excRateTitle = j;
            excRate = k;
            lastRefTitle = l;
            lastRef = m;
            timeTitle = n;
            time = o;
        }
        public string Display()
        {
            return excRate;
        }
}
}
