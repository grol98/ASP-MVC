using ASP_MVC.Models;

namespace ASP_MVC.Repository
{
    public class OrderRepository : IRepository
    {
        private ApplicationContext dbcontext;
        public OrderRepository(ApplicationContext context) 
        {
            dbcontext = context;
        }

        IEnumerable<Order> IRepository.GetOrders => dbcontext.Orders.ToList();

        public void AddOrder(Order order)
        {
            long ticks = DateTime.UtcNow.Ticks;
            string orderNumber = Convert.ToString(ticks, 16).ToUpper();
            order.Number = orderNumber;
            dbcontext.Orders.Add(order);
            dbcontext.SaveChanges();
        }
    }
}