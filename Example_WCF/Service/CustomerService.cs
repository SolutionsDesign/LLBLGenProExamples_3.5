using System;
using System.Collections.Generic;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.WCF.DatabaseSpecific;
using SD.LLBLGen.Pro.Examples.WCF.EntityClasses;
using SD.LLBLGen.Pro.Examples.WCF.HelperClasses;
using SD.LLBLGen.Pro.Examples.WCF.FactoryClasses;
using System.ServiceModel;
using SD.LLBLGen.Pro.Examples.WCF.ServiceInterface;
using System.Data;

namespace SD.LLBLGen.Pro.Examples.WCF.Service
{
	/// <summary>
	/// The implementation of our Northwind service. This service is started by the Host application. 
	/// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class NorthwindService : INorthwindService
    {
        #region INorthwindService Members
        /// <summary>
        /// Gets the number of customers in the database.
        /// </summary>
        /// <returns>the number of customers found in the database</returns>
        public int GetNumberOfCustomers()
        {
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // simply obtain the count of the customerid and return that.
                return (int)adapter.GetScalar(CustomersFields.CustomerId, AggregateFunction.CountRow);
            }
        }


        /// <summary>
        /// Gets various order statistics from the orders table
        /// </summary>
        /// <param name="averageOrderPrice">The average order price.</param>
        /// <param name="highestOrderPrice">The higest order price.</param>
        /// <param name="numberOfOrders">The number of orders.</param>
        /// <param name="orderIdWithHighestPrice">The order id with highest price.</param>
        /// <remarks>No error checking is applied to this routine, it's for illustrating the framework functionality.</remarks>
        public void GetOrderStatistics(out decimal averageOrderPrice, out decimal highestOrderPrice, out int numberOfOrders, out int orderIdWithHighestPrice)
        {
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // get all order prices using a dynamic list.
                ResultsetFields orderPricesFields = new ResultsetFields(2);
                orderPricesFields.DefineField(OrderDetailsFields.OrderId, 0, "OrderId");
                orderPricesFields.DefineField(OrderDetailsFields.ProductId, 1, "OrderPrice", "", AggregateFunction.Sum);
                orderPricesFields[1].ExpressionToApply = (OrderDetailsFields.Quantity * OrderDetailsFields.UnitPrice);
                IGroupByCollection groupBy = new GroupByCollection();
                groupBy.Add(orderPricesFields[0]);

                // fetch in a datatable, orderid + the order price.
                DataTable orderPrices = new DataTable();
                adapter.FetchTypedList(orderPricesFields, orderPrices, null, 0, null, true, groupBy);

                // calculate average order price and which customer has the most expensive order
                averageOrderPrice = 0.0M;
                highestOrderPrice = 0.0M;
                orderIdWithHighestPrice = 0;
                for (int i = 0; i < orderPrices.Rows.Count; i++)
                {
                    decimal currentOrderPrice = (decimal)orderPrices.Rows[i]["OrderPrice"];
                    if (currentOrderPrice > highestOrderPrice)
                    {
                        highestOrderPrice = currentOrderPrice;
                        orderIdWithHighestPrice = (int)orderPrices.Rows[i]["OrderId"];
                    }
                    averageOrderPrice += currentOrderPrice;
                }
                averageOrderPrice = averageOrderPrice / orderPrices.Rows.Count;
                numberOfOrders = orderPrices.Rows.Count;
            }
        }

        /// <summary>
        /// Gets the order and customer with highest price.
        /// </summary>
        /// <param name="orderID">The orderId of the order with the highest price</param>
        /// <returns>
        /// OrderEntity with the highest price with its related CustomerEntity assigned to it
        /// </returns>
        /// <remarks>No error checking is applied to this routine, it's for illustrating the framework functionality.</remarks>
        public IEntity2 GetOrderAndCustomerWithHighestPrice(int orderId)
        {
            OrdersEntity highestOrder = null;

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // get order with highest price. Pull customer also in 1 go  using a prefetch path
                IPrefetchPath2 prefetchPathCustomer = new PrefetchPath2((int)EntityType.OrdersEntity);
                prefetchPathCustomer.Add(OrdersEntity.PrefetchPathCustomers);
                highestOrder = new OrdersEntity(orderId);
                adapter.FetchEntity(highestOrder, prefetchPathCustomer);
            }
            return highestOrder;
        }


        /// <summary>
        /// Gets the customer with the most orders and also the customers' number of orders.
        /// </summary>
        /// <param name="numberOfOrders">The number of orders.</param>
        /// <returns>the CustomerEntity with the most orders and also the number of orders of this customer</returns>
        /// <remarks>No error checking is applied to this routine, it's for illustrating the framework functionality.</remarks>
        public IEntity2 GetCustomerWithMostOrdersAndNumberOfOrders(out int numberOfOrders)
        {
            CustomersEntity toReturn = null;
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // create a list to obtain the customerid + # of orders. We'll just fetch the 1st row, ordering on the # of orders. 
                ResultsetFields orderCustomerFields = new ResultsetFields(2);
                orderCustomerFields.DefineField(OrdersFields.CustomerId, 0, "CustomerId");
                orderCustomerFields.DefineField(OrdersFields.OrderId, 1, "NumberOfOrders", "", AggregateFunction.Count);
                GroupByCollection groupBy = new GroupByCollection();
                groupBy.Add(orderCustomerFields[0]);
                SortExpression sorter = new SortExpression();
                sorter.Add(new SortClause(orderCustomerFields[1], null, SortOperator.Descending));

                // now fetch the list, specify to fetch just 1 row, ordered descending on amount
                DataTable orderCustomer = new DataTable();
                adapter.FetchTypedList(orderCustomerFields, orderCustomer, null, 1, sorter, true, groupBy);
                numberOfOrders = (int)orderCustomer.Rows[0]["NumberOfOrders"];

                // we'll assume the data was there, so there is a row.
                toReturn = new CustomersEntity(orderCustomer.Rows[0]["CustomerId"].ToString());
                adapter.FetchEntity(toReturn);
            }
            return toReturn;
        }


        /// <summary>
        /// Gets all customer entities
        /// </summary>
        /// <returns>entity collection with all customers</returns>
        public IEntityCollection2 GetAllCustomers()
        {
            EntityCollection toReturn = new EntityCollection( new CustomersEntityFactory());
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // simply fetch all customer entities into the collection.
                adapter.FetchEntityCollection(toReturn, null);
            }
            return toReturn;
        }


        /// <summary>
        /// Gets all customers who have bought the product with the product id specified.
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns>an entity collection with 0 or more customers who have purchased the product with the id specified</returns>
        /// <remarks>The filter constructed inside this method could also be formulated on the client and then be passed into this method, which could
        /// be a different approach: more logic onto the client and a smaller API on the service. That kind of method could then also replace GetAllCustomers.</remarks>
        public IEntityCollection2 GetAllCustomersFilteredOnProduct(int productId)
        {
            // construct filter, which will span multiple entities.
            RelationPredicateBucket filterBucket = new RelationPredicateBucket();

            // Start with the entity you want to retrieve...
            filterBucket.Relations.Add(CustomersEntity.Relations.OrdersEntityUsingCustomerId);
            filterBucket.Relations.Add(OrdersEntity.Relations.OrderDetailsEntityUsingOrderId);
            filterBucket.Relations.Add(OrderDetailsEntity.Relations.ProductsEntityUsingProductId); // ... and end with the entity you want to use in your filter...

            // create the predicate 'Product.ProductId == value', we will fill in the value later.
            filterBucket.PredicateExpression.Add(ProductsFields.ProductId == productId);

            ////////////////
            // Another way of doing the same query is through the FieldCompareSetPredicate class. The amount of data in Northwind is fairly small,
            // so the filter with the relations will perform rather quickly. However with loads of data in the database, a FieldCompareSetPredicate class
            // can be much more efficient. See the documentation (Filtering and Sorting) for details about this class.
            ///////////////

            EntityCollection customers = new EntityCollection(new CustomersEntityFactory());

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // fetch the customers with the filter specified.
                adapter.FetchEntityCollection(customers, filterBucket);
            }

            return customers;
        }


        /// <summary>
        /// Gets a collection of Products sorted by the passed in filed name, and direction of sort.
        /// </summary>
        /// <param name="sortOnField">field name to sort upon</param>
        /// <param name="direction">direction of sort</param>
        /// <returns>a sorted products collection</returns>
        /// <remarks>Shows how to use message parameters to specify sorting.
        /// </remarks>
        public IEntityCollection2 GetProductsSortedBy(string sortOnField, SortOperator direction)
        {
            EntityCollection toReturn = new EntityCollection(new ProductsEntityFactory());

            ProductsEntity product = new ProductsEntity();
			SortExpression sorter = null;
			IEntityField2 sortField = product.Fields[sortOnField];
			if(sortField != null)
			{
				sorter = new SortExpression(new SortClause(sortField, null, direction));
			}

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // fetch all products, sorted on the sort expression passed in
                adapter.FetchEntityCollection(toReturn, null, 0, sorter);
            }
            return toReturn;        
        }


        /// <summary>
        /// Gets the numer of times product was sold.
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns>the number of times the product was sold.</returns>
        public int GetNumerOfTimesProductWasSold(int productId)
        {
            if (productId == 0)
            {
                return 0;
            }

            int toReturn = 0;
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // get scalar for amount of times this product is sold.
                object scalarValue = adapter.GetScalar(
                        OrderDetailsFields.Quantity, null, AggregateFunction.Sum, (OrderDetailsFields.ProductId == productId));
                if (scalarValue != DBNull.Value)
                {
                    toReturn = (int)scalarValue;
                }
            }
            return toReturn;
        }


        /// <summary>
        /// Removes the order and the order detail rows of this order from the database.
        /// </summary>
        /// <param name="toRemove">order to remove.</param>
        /// <returns>true if the remove was successful, false otherwise</returns>
        public bool RemoveOrder(IEntity2 toRemove)
        {
            bool toReturn = false;
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.StartTransaction(IsolationLevel.ReadCommitted, "order removal");
                try
                {
                    // LLBLGen Pro doesn't have cascading deletes, as those aren't always possible (multiple paths from A to B), plus
					// deletes are always explicit in LLBLGen Pro so no surprises which aren't recoverable.
                    // first remove the orderdetail rows of this order
                    adapter.DeleteEntityCollection(((OrdersEntity)toRemove).OrderDetails);

                    // remove the order itself
                    toReturn = adapter.DeleteEntity((OrdersEntity)toRemove);

                    // done. Commit the work.
                    adapter.Commit();
                    toReturn = true;
                }
                catch
                {
                    // exception occured. Rollback transaction
                    adapter.Rollback();
                    // simply rethrow the exception
                    throw;
                }
            }

            return toReturn;
        }


        /// <summary>
        /// Gets the customer entity + orders + order details for the customer of the customer id passed in.
        /// </summary>
        /// <param name="customerId">The customer id.</param>
        /// <returns>Customer entity with its order entities + order details entities per order for the customer passed in.</returns>
        public IEntity2 GetCustomerWithFullOrders(string customerId)
        {
            // fetch customer, orders and order details in one go with a prefetch path.
            CustomersEntity toReturn = new CustomersEntity(customerId);
            PrefetchPath2 path = new PrefetchPath2((int)EntityType.CustomersEntity);
            // add orders to the path, specify to sort the orders on order id ascending.
            path.Add(CustomersEntity.PrefetchPathOrders, 0, null, null, new SortExpression(OrdersFields.OrderId | SortOperator.Ascending))
                    .SubPath.Add(OrdersEntity.PrefetchPathOrderDetails);
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntity(toReturn, path);
            }

            return toReturn;
        }


        /// <summary>
        /// Saves the customer passed in. 
        /// </summary>
        /// <param name="toSave">customer To save.</param>
        /// <param name="recursive">if set to true, the contained entities inside the customer are also saved, e.g. orders and order details, in one transaction</param>
        /// <returns>true if succeeded, false otherwise</returns>
        public bool SaveCustomer(IEntity2 toSave, bool recursive)
        {
            bool toReturn = false;
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                toReturn = adapter.SaveEntity((CustomersEntity)toSave, false, recursive);
            }
            return toReturn;
        }


        /// <summary>
        /// Gets the customer entity with the id specified
        /// </summary>
        /// <param name="customerId">The customer id.</param>
        /// <returns>customer entity with the id specified.</returns>
        public IEntity2 GetCustomer(string customerId)
        {
            CustomersEntity toReturn = new CustomersEntity(customerId);
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntity(toReturn);
            }

            return toReturn;
        }


        /// <summary>
        /// Saves the orders passed in
        /// </summary>
        /// <param name="orders">The orders.</param>
        public void SaveOrders(IEntityCollection2 orders)
        {
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.SaveEntityCollection(orders, false, true);
            }
        }

        #endregion
    }
}
