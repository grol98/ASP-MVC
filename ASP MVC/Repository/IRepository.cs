using ASP_MVC.Models;

namespace ASP_MVC.Repository
{
    public interface IRepository
    {
        public void AddOrder(Order order);
        public IEnumerable<Order> GetOrders { get; } 
    }
}
