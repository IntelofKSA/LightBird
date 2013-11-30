using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBird
{
    /// <summary>공지사항 하나의 정보를 저장합니다.</summary>
    public class NoticeObject
    {
        public readonly string link;
        public readonly string title;
        public readonly string time;
        public readonly string author;

        public NoticeObject(string link, string title, string time, string author)
        {
            this.link = link;
            this.title = title;
            this.time = time;
            this.author = author;
        }

        public NoticeObject(string str)
        {
            string[] data = str.Split(new string[] { "%%%" }, StringSplitOptions.RemoveEmptyEntries);
            if (data.Length != 4) return;

            link = data[0];
            title = data[1];
            time = data[2];
            author = data[3];
        }
    }
}
