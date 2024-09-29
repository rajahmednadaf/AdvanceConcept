using DataStore.DBContext;

namespace DataStore
{
    public class DataStoreMain
    {
        public DataStoreMain()
        {
            
        }

        public void TestGroupByQuery()
        {
            using (var context = new ApplicationDBContext())
            {
                // Assuming YourDbContext is set up correctly with DbSets
                var customerOrderSummary = from o in context.Orders
                                           join c in context.Customers on o.CustomerId equals c.CustomerId
                                           group o by new { c.CustomerId, c.CustomerName } into grouped
                                           select new
                                           {
                                               CustomerId = grouped.Key.CustomerId,
                                               CustomerName = grouped.Key.CustomerName,
                                               OrderCount = grouped.Count(),
                                               TotalAmount = grouped.Sum(x => x.Amount)
                                           };

                var customerSummary = customerOrderSummary.ToList();
                foreach (var summary in customerSummary)
                {
                    Console.WriteLine($"Customer: {summary.CustomerName}, Orders: {summary.OrderCount}, Total Amount: {summary.TotalAmount:C}");
                }
            }
        }
    }
}
