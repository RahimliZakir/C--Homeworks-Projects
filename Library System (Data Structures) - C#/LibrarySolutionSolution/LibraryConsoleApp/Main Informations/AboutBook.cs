using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp.Main_Informations
{
    class AboutBook
    {
        public AboutBook()
        {

        }

        public AboutBook(string aName, string aAuthorName, int aPublishDate, int aPageCount)
        {
            this.Name = aName;
            this.AuthorName = aAuthorName;
            this.PublishDate = aPublishDate;
            this.PageCount = aPageCount;
        }

        private int pagecount;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PublishDate { get; set; }
        public int PageCount { 
            get
            {
                return pagecount;
            } 
            set 
            {
                if (value < 10)
                {
                    throw new Exception("Kitabın səhifə sayı 10-dan aşağı ola bilməz!");
                }
                pagecount = value;
            }
        }

        public override string ToString()
        {
            return $"{Name}, {AuthorName}, {PublishDate}, {PageCount}";
        }
    }
}
