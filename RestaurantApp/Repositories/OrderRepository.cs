using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public class OrderRepository : IRepository<Order>
{
    private List<Order> _orders;

    public OrderRepository(List<Order> orders)
    {
        _orders = orders;
    }

    public Order GetOne(int id)
    {
        var order = _orders.SingleOrDefault(x => x.Id == id);

        if (order == null)
        {
            throw new Exception("Order not found");
        }
        return order;
    }

    public void Post(Order entity)
    {
        _orders.Add(entity);
    }

    public void Delete(int id)
    {
        var order = GetOne(id);

        _orders.Remove(order);
    }
}