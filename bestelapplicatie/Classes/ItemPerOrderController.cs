using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestelapplicatie.Classes
{
    class ItemPerOrderController
    {
        //onderstaande geef je mee zodat die in heel de class beschibaar is, want een variabele stopt na de laatste acculade
        dcKassaDataContext db;
        //geef je mee zodat je bestaande database verbinding ook in deze klasse kan gebruiken
        public ItemPerOrderController(dcKassaDataContext db)
        {
            //hiermee koppel je de variabele die je door krijgt aan de globale variabele, je houdt dezelfde databaseverbinding
            this.db = db;
        }
        /*
        public bool createItemPerOrder(int iAmount, int iOrderID, int iProductID)
        {
            try
            {
                itemperorder myIPO = new itemperorder();
                myIPO.amount = iAmount;
                myIPO.orderID = iOrderID;
                myIPO.productID = iProductID;
                db.itemperorders.InsertOnSubmit(myIPO);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        */
        //list is datatype -itemperorder
        //bool gebruik je bij boolean en geeft waarde mee try, catch en return true, return false
        public bool createItemPerOrders(List<itemperorder> myIPOs, order myOrder)
        {
            try
            {
                foreach (itemperorder myIPO in myIPOs)
                {
                    //hiermee koppel je lijst van itemperorders naar order
                    myIPO.orderID = myOrder.orderID;
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteItemPerOrders(itemperorder myIPOs)
        {
            try
            {
                //myIPOS geef je mee omdat hij anders niet weet wat je wilt verwijderen
                db.itemperorders.DeleteOnSubmit(myIPOs);
                //data daadwerkelijk doorvoeren naar database
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

