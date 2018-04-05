using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgess_quiz
{

    public class Repo
    {
        #region Initializing HeaderList
        List<Header> HeaderList = new List<Header>() 
            {
            new Header(){HeaderId="249e1bd0-0b6c-4dce-8d72-e16f20b1b49c",ClientName="Client1",LineItemIds=new List<int>{1,2,3}},
            new Header(){HeaderId="ea9560cc-e38b-481e-9630-3ca03e5b46a2",ClientName="Client2",LineItemIds=new List<int>{3,4,5}},
            new Header(){HeaderId="afaf2070-8fb7-492d-b7c2-b2ca7ed80844",ClientName="Client3",LineItemIds=new List<int>{2,4}},
            };
        #endregion

        List<LineItem> LineItemList = new List<LineItem>()
           {
               new LineItem(){ LineItemID = 1,LineItemName = "Item1",Date = Convert.ToDateTime("2/21/2017 12:00:00 AM"),Charge = 100},
               new LineItem(){ LineItemID = 2,LineItemName = "Item2",Date = Convert.ToDateTime("2/22/2017 12:00:00 AM"),Charge = 200},
               new LineItem(){ LineItemID = 3,LineItemName = "Item3",Date = Convert.ToDateTime("2/23/2017 12:00:00 AM"),Charge = 300},
               new LineItem(){ LineItemID = 4,LineItemName = "Item4",Date = Convert.ToDateTime("2/24/2017 12:00:00 AM"),Charge = 400},
               new LineItem(){ LineItemID = 5,LineItemName = "Item5",Date = Convert.ToDateTime("2/25/2017 12:00:00 AM"),Charge = 500}
           };
        public List<Header> Task1()
        {
            return HeaderList.ToList();

        }

        public LineItem GetClientNameByID(int id)
        {
            return LineItemList.Where(a => a.LineItemID == id).SingleOrDefault();

        }
    }
}
