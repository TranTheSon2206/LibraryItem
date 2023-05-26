using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_5._1
{
    public class magazine : libaryItem
    {
        protected int amountmaking { get; set; }

        public magazine(string title, string author, int pubicationYear, int amountmaking) : base(title, author, pubicationYear)
        {
            this.amountmaking = amountmaking;
        }
        public override string ToString()
        {
            return "Type: " + GetType().Name + ",Title: " + title + ",by Auhthor: " + author + ",Publication Year: " + publicationYear+",Amount: "+amountmaking;
        }
    }
}
