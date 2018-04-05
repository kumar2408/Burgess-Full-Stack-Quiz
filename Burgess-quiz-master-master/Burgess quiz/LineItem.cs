using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgess_quiz
{
   public class LineItem
    {
        public int LineItemID { get; set; }
        public DateTime Date { get; set; }
        public string LineItemName { get; set; }
        public int Charge { get; set; }
       

    }
}
