# Inversion of Control

## Tasks

Apply the changes accomplished in your Inversion of Control project to your ASPNETKata, including:

* Add a class library for your Dapper Product Repository so that you can move Dapper from your Controller
* Move your Product model to your class library
* Add inversion of control via. Unity for your Dapper Product Repository and your `MySQLConnection`
* Move your connection string to your `.config` file
* Have your `ProductController` use a constructor for passing in an `IProductRepository` for accessing data

By the end of this task, your project should:

* Have no reference to `using Dapper` within your main project
* Have no connection strings within your source code; it should be located in your `.config` file
* Have no Product class within your `Models` folder in your main project
