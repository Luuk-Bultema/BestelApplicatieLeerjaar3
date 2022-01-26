using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestelapplicatie.Classes
{

    class FactuurController
    {
        dcKassaDataContext db;
        List<order> lijst;
        

        public FactuurController(dcKassaDataContext db)
        {
            this.db = db;
            lijst = new List<order>();
        }

        /*
        public bool checkDate(DateTime date1, DateTime date2)
        {
            try
            {
                order Date = new order();
                Date.date = date1;
                Date.date = date2;
                return true;
            }
            catch
            {
                return false;
            }
           

        }
        */
        /*
        public List<order> orderophalen(DateTime date1, DateTime date2)
        {
            var datum1 = (from order in db.orders where order.date >= date1 select order);
        }
        */

        public List<order> geefLijst(DateTime date1)
        {
            var datum1 = (from order in db.orders where order.date >= date1 select order);
            return lijst;
        }
    }
}
