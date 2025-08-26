using Basboosify.OrdersMicroservice.DataAccessLayer.Entities;
using MongoDB.Driver;

namespace Basboosify.OrdersMicroservice.DataAccessLayer.RepositoryContracts;

public interface IOrdersRepository
{
    /// <summary>
    /// Rtrieves all orders from the data source asynchronously.
    /// </summary>
    /// <returns>Returns all orders from the order collection</returns>
    Task<IEnumerable<Order>> GetOrders();

    /// <summary>
    /// Retrieves all orders based on the specified condition asynchronously.
    /// </summary>
    /// <param name="filter">the condition to filter orders</param>
    /// <returns>return a colletion of matching orders</returns>
    Task<IEnumerable<Order?>> GetOrdersByCondition(FilterDefinition<Order> filter);

    /// <summary>
    /// retrieves an order based on the specified condition asynchronously
    /// </summary>
    /// <param name="filter">the condition to filter orders</param>
    /// <returns>returns matching order</returns>
    Task<Order?> GetOrderByCondition(FilterDefinition<Order> filter);

    /// <summary>
    /// adds a new order to the data source asynchronously.
    /// </summary>
    /// <param name="order">the order to be added</param>
    /// <returns>returns the added obj or null if unsucessful</returns>
    Task<Order?> AddOrder(Order order);

    /// <summary>
    /// updates an existing order in the data source asynchronously.
    /// </summary>
    /// <param name="order">the order to be updated</param>
    /// <returns>returns the updated order or null if not found</returns>
    Task<Order?> UpdateOrder(Order order);


    /// <summary>
    /// deltes an order from the data source asynchronously.
    /// </summary>
    /// <param name="orderId">the order based on id we need to delete</param>
    /// <returns>returns true ir deleted, false otherwise</returns>
    Task<bool> DeleteOrder(Guid orderId);
}
