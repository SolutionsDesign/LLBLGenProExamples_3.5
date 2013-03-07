LLBLGen Pro Complex binding example
======================================================

This example shows how to setup a winforms form using complex databinding to get a grid which is easy to edit
due to the combo-boxes filled with related entity data. 

The form shows the orders for a given customer and lets you specify the Employee and the Shipper using combo boxes
in the grid, instead of having to specify ID's. 

Requirements:
--------------
VS.NET, SqlServer, Northwind database.
Please change the connection string in the Northwind.GUI's App.config file. 

Notes:
------------
* The EmployeeEntity is extended with a partial class stored in EmployeeEntityProperties.cs
  This file contains the definition for the FullName property, which simply returns the full name of the Employee
  and which is used in the databinding scenario as the display member for the combobox in the Employee column.
  
* The _ordersDesignerCollection collection instance is used for designing the grid. It's not used at runtime. This 
  illustrates how you can setup your form at design time and bind different data (but of the same types) at runtime.
  
* The orders are loaded once, so if you want to re-load them, you've alter the code in the load orders button click handler

* As changes are stored in entity objects inside the customers' Orders collections, you can add a save button which saves
  all changes in 1 go, by simply saving recursively the entity collection bound to the combo box for customers. 
  
