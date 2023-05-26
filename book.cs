using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_5._1
{
   public class book : libaryItem
    {
        protected string category {get;set;}

        public book(string title, string author, int pubicationYear, string category) : base(title, author,pubicationYear)
        {
            this.category = category;
        }
        public override string ToString()
        {
             return ("Type:"+GetType().Name+", Title: "+title+", by Auhthor:"+author+", Publication Year:"+publicationYear+", Category: "+category);
        }
    }
}
