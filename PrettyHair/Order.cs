using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class Order
    {
        public int quantity;

        public DateTime OrderDate { set; get; }
        public DateTime DeliveryDate { set; get; }
        public int WareNumber { set; get; }
        public int CustomerNumber { set; get;}
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 1)
                    quantity = 1;
                else
                    quantity = value;
            }
        }        

        public Order(int customerNumber, int wareNumber, int quantity, DateTime orderDate, DateTime deliveryDate)
        {
            CustomerNumber = customerNumber;
            WareNumber = wareNumber;
            quantity = 1;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
        }

        public Order(int customerNumber, int wareNumber, int quantity, DateTime orderDate, DateTime deliveryDate)
            : this(customerNumber, orderDate, deliveryDate, wareNumber)
        {
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return "ware: " + WareNumber;
        }
    } 
}
