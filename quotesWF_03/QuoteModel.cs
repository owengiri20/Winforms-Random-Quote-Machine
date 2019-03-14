using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quotesWF_03
{
    public class QuoteModel
    {
        public QuoteDetails quoteDetails;

        public class QuoteDetails
        {
            public List<string> quoteContent;
            public List<string> quoteAuthor;

        }
    }

   
}
