using System;
using System.Collections.Generic;
using System.Text;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Interfaces
{
	/// <summary>
	/// Service interface which is implemented by our service and which is utilized by the client so we don't have to
	/// reference the service assembly in the client to know the API specifics of the service.
	/// </summary>
	public interface IService
	{
		/// <summary>
		/// Gets the number of customers in the database.
		/// </summary>
		/// <returns>the number of customers found in the database</returns>
		int GetNumberOfCustomers();
		/// <summary>
		/// Gets various order statistics from the orders table
		/// </summary>
		/// <param name="averageOrderPrice">The average order price.</param>
		/// <param name="highestOrderPrice">The higest order price.</param>
		/// <param name="numberOfOrders">The number of orders.</param>
		/// <param name="orderIdWithHighestPrice">The order id with highest price.</param>
		void GetOrderStatistics(out decimal averageOrderPrice, out decimal highestOrderPrice, out int numberOfOrders, out int orderIdWithHighestPrice);
		/// <summary>
		/// Gets the order and customer with highest price.
		/// </summary>
		/// <param name="orderID">The orderId of the order with the highest price</param>
		/// <returns>
		/// OrderEntity with the highest price with its related CustomerEntity assigned to it
		/// </returns>
		OrderEntity GetOrderAndCustomerWithHighestPrice(int orderId);
		/// <summary>
		/// Gets the customer with the most orders and also the customers' number of orders.
		/// </summary>
		/// <param name="numberOfOrders">The number of orders.</param>
		/// <returns>the CustomerEntity with the most orders and also the number of orders of this customer</returns>
		CustomerEntity GetCustomerWithMostOrdersAndNumberOfOrders(out int numberOfOrders);
		/// <summary>
		/// Gets all customer entities
		/// </summary>
		/// <returns>entity collection with all customers</returns>
		EntityCollection<CustomerEntity> GetAllCustomers();
		/// <summary>
		/// Gets all customers who have bought the product with the product id specified.
		/// </summary>
		/// <param name="productId">The product id.</param>
		/// <returns>an entity collection with 0 or more customers who have purchased the product with the id specified</returns>
		EntityCollection<CustomerEntity> GetAllCustomersFilteredOnProduct(int productId);
		/// <summary>
		/// Gets the products sorted by the passed in sorter.
		/// </summary>
		/// <param name="sorter">The sorter.</param>
		/// <returns>returns the products based on the passed in sort expression</returns>
		EntityCollection<ProductEntity> GetProductsSortedBySortExpression(SortExpression sorter);
		/// <summary>
		/// Gets the numer of times product was sold.
		/// </summary>
		/// <param name="productId">The product id.</param>
		/// <returns>the number of times the product was sold.</returns>
		int GetNumerOfTimesProductWasSold(int productId);
		/// <summary>
		/// Removes the order and the order detail rows of this order from the database.
		/// </summary>
		/// <param name="toRemove">order to remove.</param>
		/// <returns>true if the remove was successful, false otherwise</returns>
		bool RemoveOrder(OrderEntity toRemove);
		/// <summary>
		/// Gets the customer entity + orders + order details for the customer of the customer id passed in.
		/// </summary>
		/// <param name="customerId">The customer id.</param>
		/// <returns>Customer entity with its order entities + order details entities per order for the customer passed in.</returns>
		CustomerEntity GetCustomerWithFullOrders(string customerId);
		/// <summary>
		/// Saves the customer passed in. 
		/// </summary>
		/// <param name="toSave">customer To save.</param>
		/// <param name="recursive">if set to true, the contained entities inside the customer are also saved, e.g. orders and order details, in one transaction</param>
		/// <returns>true if succeeded, false otherwise</returns>
		bool SaveCustomer(CustomerEntity toSave, bool recursive);
		/// <summary>
		/// Gets the customer entity with the id specified
		/// </summary>
		/// <param name="customerId">The customer id.</param>
		/// <returns>customer entity with the id specified.</returns>
		CustomerEntity GetCustomer(string customerId);
		/// <summary>
		/// Saves the orders passed in
		/// </summary>
		/// <param name="orders">The orders.</param>
		void SaveOrders(EntityCollection<OrderEntity> orders);
	}
}
