using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_5._1
{
   public abstract class libaryItem
    {
        protected string title { get; set; }
        protected string author { get; set; }
        protected int publicationYear { get; set; }

        public libaryItem(string title, string author, int publicationYear)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
        }
    }
}
