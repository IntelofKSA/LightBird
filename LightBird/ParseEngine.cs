using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GaonnuriAPIUtil;

namespace LightBird
{
    /// <summary>PNotice의 결과물을 파싱하는 기능을 제공합니다.</summary>
    public static class ParseEngine
    {
        /// <summary>공지사항 정보를 저장합니다.</summary>
        private static List<NoticeObject> notices;

        /// <summary>유효한 이전 소스를 저장합니다.</summary>
        private static string oldstr;

        /// <summary>공지사항 정보를 가져옵니다.</summary>
        public static List<NoticeObject> Notices
        {
            get { return notices; }
        }

        /// <summary>공지사항 정보를 파싱합니다.</summary>
        /// <param name="str">파싱할 문자열</param>
        /// <param name="isUpdated">추가된 공지사항이 있는지 여부</param>
        /// <returns>성공 여부</returns>
        public static bool Parse(string str, out bool isUpdated)
        {
            isUpdated = false;

            if (str == "UNKNOWN_RESPONSE") return false;
            if (oldstr != str) isUpdated = true;
            oldstr = str;

            notices = new List<NoticeObject>();
            string[] data = str.Split(new string[] { "###" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in data)
            {
                NoticeObject o = new NoticeObject(s);
                if (o == null) return false;
                notices.Add(o);
            }
            return true;
        }
    }
}
