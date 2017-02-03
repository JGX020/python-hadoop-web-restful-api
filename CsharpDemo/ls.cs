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
        static string url = "http://119.29.0.61:8000/ls";
        public static void Main(string[] args)
        {
            string result = HttpGet(url, "");
           // string error_code = Json(result);
            Debug.WriteLine(result);
           // Debug.WriteLine(error_code);
        }
        public static string HttpGet(string Url, string postDataStr)
        {
            string retString = "";
            String username = "admin";
            String password = "TvvRvHkyr9b6ls1I";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("UTF-8").GetBytes(username + ":" + password));
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
                request.Headers.Add("Authorization", "Basic " + encoded);
                request.Method = "GET";
                request.ReadWriteTimeout = 5000;
                request.ContentType = "text/html;charset=UTF-8";
                request.KeepAlive = false;
                request.ServicePoint.ConnectionLimit = 100;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                response.Close();
            }
            catch (Exception err)
            {
                //异常消息
                Console.WriteLine(err);
                System.Diagnostics.Trace.WriteLine(err);
            }
            //返回响应数据
            return retString;
        }
    }
}
