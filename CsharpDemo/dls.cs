using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace pay
{
    class Program
    {
        static string url = "http://119.29.0.61:8000/dls";
        static string param = "{\"dir\":\"/\"}";
        public static void Main(string[] args)
        {
           String result= PostMoths(url, param);
            // string error_code = Json(result);
             Debug.WriteLine(result);
            // Debug.WriteLine(error_code);
        }
       
        public static string PostMoths(string url, string param)
        {
            string strURL = url;
            String username = "admin";
            String password = "TvvRvHkyr9b6ls1I";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("UTF-8").GetBytes(username + ":" + password));
            System.Net.HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            string paraUrlCoded = param;
            byte[] payload;
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            System.Net.HttpWebResponse response;
            response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.Stream s;
            s = response.GetResponseStream();
            string StrDate = "";
            string strValue = "";
            StreamReader Reader = new StreamReader(s, Encoding.UTF8);
            while ((StrDate = Reader.ReadLine()) != null)
            {
                strValue += StrDate + "\r\n";
            }
            return strValue;
        }
       
    }
}
