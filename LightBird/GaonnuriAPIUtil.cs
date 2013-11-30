using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

/* Gaonnuri API Library for C#
 * 
 * Copyright (c) 2013. Intel of KSA Students Union.
 * 
 * Programmer: Sam Brad Jo
 * 
 * Version: 1.00.0000
 * Date: 2013-11-30
 * 
 * Released Under the MIT License
 */

namespace GaonnuriAPIUtil
{
    /// <summary>API가 서버로 요청을 보낼때 사용하는 정보를 저장합니다.</summary>
    public class GaonnuriWebQuery
    {
        /// <summary>요청하는 데이터입니다.</summary>
        private NameValueCollection source;

        /// <summary>요청 데이터를 초기화합니다.</summary>
        public GaonnuriWebQuery()
        {
            source = new NameValueCollection();
        }

        /// <summary>지정된 키와 값을 요청 데이터에 추가합니다.</summary>
        /// <param name="key">추가할 키</param>
        /// <param name="value">추가할 값</param>
        public void Add(string key, string value)
        {
            source.Add(key, value);
        }

        /// <summary>지정된 키에 해당하는 과목을 요청 데이터에서 제거합니다.</summary>
        /// <param name="key">제거할 키</param>
        public void Remove(string key)
        {
            source.Remove(key);
        }

        /// <summary>HttpEncode된 데이터를 반환합니다.</summary>
        public override string ToString()
        {
            return string.Join("&", Array.ConvertAll(source.AllKeys, item => string.Format("{0}={1}",
                HttpUtility.UrlEncode(item), HttpUtility.UrlEncode(source[item]))));
        }
    }

    /// <summary>Gaonnuri 서버와 연결하기 위한 기능을 제공합니다.</summary>
    public static class ServerConnection
    {
        /// <summary>기본 서버 주소를 지정합니다.</summary>
        public const string SERVER_URL = "http://gaonnuri.ksain.net";

        /// <summary>주어진 url로 data를 POST 형식으로 요청합니다.</summary>
        /// <param name="url">URL</param>
        /// <param name="query">POST 형식으로 요청할 키, 값 쌍</param>
        /// <returns>POST 결과 값</returns>
        public static string PostData(string url, GaonnuriWebQuery query)
        {
            byte[] postBytes = query == null ? null : Encoding.UTF8.GetBytes(query.ToString());
            try
            {
                HttpWebRequest WebRequest = (HttpWebRequest)HttpWebRequest.Create(SERVER_URL + url);
                WebRequest.Method = "POST";
                WebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                WebRequest.ContentLength = postBytes.Length;
                using (Stream stream = WebRequest.GetRequestStream())
                    stream.Write(postBytes, 0, postBytes.Length);
                HttpWebResponse WebResponse = (HttpWebResponse)WebRequest.GetResponse();
                using (StreamReader sr = new StreamReader(WebResponse.GetResponseStream()))
                    return sr.ReadToEnd();
            }
            catch (WebException e)
            {
                HttpWebResponse WebResponse = (HttpWebResponse)e.Response;
                if (WebResponse == null) return "UNKNOWN_RESPONSE";
                using (StreamReader sr = new StreamReader(WebResponse.GetResponseStream()))
                    return sr.ReadToEnd();
            }
        }

        /// <summary>주어진 url로 data를 GET 형식으로 요청합니다.</summary>
        /// <param name="url">URL</param>
        /// <param name="query">GET 형식으로 요청할 키, 값 쌍</param>
        /// <returns>GET 결과 값</returns>
        public static string GetData(string url, GaonnuriWebQuery query)
        {
            try
            {
                HttpWebRequest WebRequest = (HttpWebRequest)HttpWebRequest.Create(SERVER_URL + url + 
                    (query == null ? "" : ("?" + query.ToString())));
                WebRequest.Method = "GET";
                HttpWebResponse WebResponse = (HttpWebResponse)WebRequest.GetResponse();
                using (StreamReader sr = new StreamReader(WebResponse.GetResponseStream(), Encoding.UTF8))
                    return sr.ReadToEnd();
            }
            catch (WebException e)
            {
                HttpWebResponse WebResponse = (HttpWebResponse)e.Response;
                if (WebResponse == null) return "UNKNOWN_RESPONSE";
                using (StreamReader sr = new StreamReader(WebResponse.GetResponseStream()))
                    return sr.ReadToEnd();
            }
        }
    }
}