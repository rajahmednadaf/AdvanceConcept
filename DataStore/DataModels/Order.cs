﻿namespace DataStore.DataModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
    }
}
