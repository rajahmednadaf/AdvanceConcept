namespace AdvanceConsept.CutomException
{
    public class OrderProcessor
    {
        public void ProcessOrder(int orderId)
        {
            // Simulate an error where the order ID is invalid
            if (orderId <= 0)
            {
                throw new CustomErrorException(1001, "Invalid Order ID. The order ID must be greater than zero.");
            }

            // Proceed with order processing logic
        }
    }
}
