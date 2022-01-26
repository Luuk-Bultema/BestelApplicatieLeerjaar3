using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestelapplicatie.Classes
{

    class OrderController
    {
        //importeren database
        dcKassaDataContext db;

        public OrderController (dcKassaDataContext db)
        {
            //instantieren database
            this.db = db;
        }
        public order createOrder(customer selCustomer)
        {
           /* try
            {*/
                //instantieren entiteit order object van maken
                order myOrder = new order();
                // order vullen met data, de datum en klant id
                myOrder.date = DateTime.Now;
                myOrder.customerID = selCustomer.customerID;
                //data toevoegen aan database
                db.orders.InsertOnSubmit(myOrder);
                //data daadwerkelijk doorvoeren naar database
                db.SubmitChanges();
                return myOrder;
            /*}
            catch
            {
                return null;
            }*/
        }

        public List<order> getAllOrders()
        {
            return db.orders.ToList();
        }

        public bool EditOrderCustomer(order myOrder, customer myCustomer)
        {
            try
            {
              //waarom doe je haal je niet eerst order op uit database, order myorder...
              //koppelen bestaande order aan bestaande customer
                myOrder.customer = myCustomer;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteOrder(order myOrder)
        {
            try
            {
                db.itemperorders.DeleteAllOnSubmit(myOrder.itemperorders);
                db.orders.DeleteOnSubmit(myOrder);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    
   
}
