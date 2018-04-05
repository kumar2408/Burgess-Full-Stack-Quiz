using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgess_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.quiz1();
            p.quiz2();
            p.quiz3();
            p.quiz4();
            p.quiz5();
            p.quiz6();
               

        }
        #region Task1
        public void quiz1()
        {

            Repo repo = new Repo();
            var headerlist = repo.Task1();
            Console.WriteLine("*** Task 1: Print orders");
            Console.WriteLine("-----------------------------------------------------------------");
            foreach (var header in headerlist)
            {
                Console.WriteLine("HeaderID=" + header.HeaderId);
                Console.WriteLine("Clinet=" + header.ClientName);
                foreach (var id in header.LineItemIds)
                {
                    LineItem item = repo.GetClientNameByID(id);
                    Console.WriteLine("{0}|{1}|{2}|{3}", header.LineItemIds.IndexOf(id) + 1, item.Date, item.LineItemName, item.Charge);

                }
                Console.WriteLine("-----------------------------------------------------------------");
            }
            
        }
        #endregion

        public void quiz2()
        {

            Repo repo = new Repo();
            var headerlist = repo.Task1();
            headerlist.Reverse();
            Console.WriteLine("*** Task 2: Print orders sorted descending by client name and line items sorted descending by Charges");
            Console.WriteLine("-----------------------------------------------------------------");
           
            foreach (var header in headerlist)
            {
                Console.WriteLine("HeaderID=" + header.HeaderId);
                Console.WriteLine("Clinet=" + header.ClientName);
                header.LineItemIds.Reverse();
                int i = 3;
                foreach (var id in header.LineItemIds)
                {
                    
                    LineItem item = repo.GetClientNameByID(id);
                    Console.WriteLine("{0}|{1}|{2}|{3}",i--, item.Date, item.LineItemName, item.Charge);

                }
                Console.WriteLine("-----------------------------------------------------------------");
            }
            
        }
        public void quiz3()
        {

            Repo repo = new Repo();
            var headerlist = repo.Task1();
            Console.WriteLine("Task3: Print lines ordered by date (ascending)");
            Console.WriteLine("-----------------------------------------------------------------");
            List<LineItem> x = new List<LineItem>();
            foreach (var header in headerlist)
            {
                foreach (var id in header.LineItemIds)
                {
                    LineItem item = repo.GetClientNameByID(id);
                    x.Add(new LineItem() {LineItemID = header.LineItemIds.IndexOf(id) + 1,LineItemName = item.LineItemName,Date = Convert.ToDateTime(item.Date),Charge = item.Charge});
                }
                
            }
            List<LineItem> SortedList = x.OrderBy(o => o.LineItemName).ToList();
            foreach (var aPart in SortedList)
            {
                Console.WriteLine(aPart.LineItemID +"|"+ aPart.Date +"|"+ aPart.LineItemName +"|"+ aPart.Charge);
            }


            Console.WriteLine("-----------------------------------------------------------------");
            
        }
        public void quiz4()
        {

            Repo repo = new Repo();
            var headerlist = repo.Task1();
            Console.WriteLine("*** Task 4: Print lines sorted by LineNumber where charge is greater than or equal 300.");
            Console.WriteLine("-----------------------------------------------------------------");
            List<LineItem> x = new List<LineItem>();
            foreach (var header in headerlist)
            {
                //Console.WriteLine("HeaderID=" + header.HeaderId);
                //Console.WriteLine("Clinet=" + header.ClientName);
                foreach (var id in header.LineItemIds)
                {
                    LineItem item = repo.GetClientNameByID(id);
                    //Console.WriteLine("{0}|{1}|{2}|{3}", header.LineItemIds.IndexOf(id) + 1, item.Date, item.LineItemName, item.Charge);
                    x.Add(new LineItem() { LineItemID = header.LineItemIds.IndexOf(id) + 1, LineItemName = item.LineItemName, Date = Convert.ToDateTime(item.Date), Charge = item.Charge });
                }

            }
            List<LineItem> SortedList = x.Where(o=>o.Charge>=300).OrderBy(c=>c.Charge).ToList();
            foreach (var aPart in SortedList)
            {
                Console.WriteLine(aPart.LineItemID + "|" + aPart.Date + "|" + aPart.LineItemName + "|" + aPart.Charge);
            }


            Console.WriteLine("-----------------------------------------------------------------");
           
        }
        public void quiz5()
        {

            Repo repo = new Repo();
            var headerlist = repo.Task1();
            Console.WriteLine("*** Task 5: Print count of line items per date.");
            Console.WriteLine("-----------------------------------------------------------------");
            List<LineItem> x = new List<LineItem>();
            foreach (var header in headerlist)
            {
               
                foreach (var id in header.LineItemIds)
                {
                    LineItem item = repo.GetClientNameByID(id);
                    x.Add(new LineItem() { LineItemID = header.LineItemIds.IndexOf(id) + 1, LineItemName = item.LineItemName, Date = Convert.ToDateTime(item.Date), Charge = item.Charge });
                }

            }

            List<DateTime> distinctDateTimes = x.Select(a => a.Date).Distinct().ToList();
            foreach (var date in distinctDateTimes)
            {
                Console.WriteLine(date+"|"+x.Where(a=>a.Date==date).Count());
            }


            Console.WriteLine("-----------------------------------------------------------------");
            
        }

        public void quiz6()
        {

            Repo repo = new Repo();
            var headerlist = repo.Task1();
            Console.WriteLine("*** Task 5: Print count of line items per date.");
            Console.WriteLine("-----------------------------------------------------------------");
            List<LineItem> x = new List<LineItem>();
            foreach (var header in headerlist)
            {

                foreach (var id in header.LineItemIds)
                {
                    LineItem item = repo.GetClientNameByID(id);
                    x.Add(new LineItem() { LineItemID = header.LineItemIds.IndexOf(id) + 1, LineItemName = item.LineItemName, Date = Convert.ToDateTime(item.Date), Charge = item.Charge });
                }

            }

            List<DateTime> distinctDateTimes = x.Select(a => a.Date).Distinct().ToList();
            foreach (var date in distinctDateTimes)
            {
                Console.WriteLine(date + "|" + x.Where(a => a.Date == date).Sum(a=>a.Charge));
            }


            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }


    }
}
