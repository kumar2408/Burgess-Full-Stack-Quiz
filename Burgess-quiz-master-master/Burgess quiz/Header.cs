using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgess_quiz
{

    public class Header
    {    // Created Header Section
        public string HeaderId { get; set; }
        public string ClientName { get; set; }
        public List<int> LineItemIds { get; set; }
       
    }
}


