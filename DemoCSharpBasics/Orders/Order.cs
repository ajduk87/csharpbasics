using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Orders
{
    public class Order
    {
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public void AddOrderItem(OrderItem orderItem) 
        {
            OrderItems.Add(orderItem);
        }

        public double CalculateBill() 
        {
            double bill = 0.0;

            foreach (OrderItem orderItem in OrderItems)
            {
                bill = bill + orderItem.Value;
            }

            return bill;
        }
    }
}
