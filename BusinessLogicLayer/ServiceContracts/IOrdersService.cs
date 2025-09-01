using Basboosify.OrdersMicroservice.BusinessLogicLayer.DTO;
using Basboosify.OrdersMicroservice.DataAccessLayer.Entities;
using MongoDB.Driver;

namespace Basboosify.OrdersMicroservice.BusinessLogicLayer.ServiceContracts;

public interface IOrdersService
{
    /// <summary>
    /// retrieves all orders
    /// </summary>
    /// <returns>returns list of orderreponse objects</returns>
    Task<List<OrderResponse?>> GetOrders();

    /// <summary>
    /// returns orders by condition
    /// </summary>
    /// <param name="filter">expression that represents condition to check</param>
    /// <returns>returns list of orderResponse objects that match the filter</returns>
    Task<List<OrderResponse?>> GetOrdersByCondition(FilterDefinition<Order> filter);


    /// <summary>
    /// returns order by condition
    /// </summary>
    /// <param name="filter">expression that represents condition to check</param>
    /// <returns>returns orderResponse object that match the filter</returns>
    Task<OrderResponse?> GetOrderByCondition(FilterDefinition<Order> filter);

    /// <summary>
    /// inserts order into the collection using orders repo
    /// </summary>
    /// <param name="orderAddRequest">order to add</param>
    /// <returns> returns orderResponse object that contains order details after inserting or returns null if unsuccessful</returns>
    Task<OrderResponse?> AddOrder(OrderAddRequest orderAddRequest);

    /// <summary>
    /// update order into the collection using orders repo
    /// </summary>
    /// <param name="orderAddRequest">order to addupdateparam>
    /// <returns> returns orderResponse object that contains order details after updating or returns null if unsuccessful</returns>
    Task<OrderResponse?> UpdateOrder(OrderUpdateRequest orderUpdateRequest);

    /// <summary>
    /// deletes an order based on id
    /// </summary>
    /// <param name="orderId">order to search for and delte</param>
    /// <returns>true if deleted false if not</returns>
    Task<bool> DeleteOrder(Guid orderId);
}
