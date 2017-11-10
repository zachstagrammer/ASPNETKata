# Inversion of Control

## Tasks

Apply the changes accomplished in your Inversion of Control project to your ASPNETKata.

**Note:** as you complete steps, you should make commits for the changes made, unless it doesn't make sense to do so. For example, **DO NOT** commit your connection string to Git.

### Step 1

Move your connection string to your `.config` file and remove it from Git

1. Make a copy of your `Web.config` file and call it `Web copy.config`
    * This copy is like breadcrumbs to lead people to seek out the actual file
1. Move your `Web.config` file out of your working directory (perhaps move it to your Desktop temporarily)
1. Commit the "deletion" of that file from Git
    * We don't want to store the secure connection string in Git, since this is currently in a public repository
1. Open your `.gitignore` file and add `Web.config` somewhere near the top
    * The `.gitignore` is purely a text file, so just add in the text: `Web.config`. Now, a file matching that name will be ignored by Git
1. Move your `Web.config` file back into your working directory
    * If you run `git status`, you'll see this file doesn't show up as "added" or "modified". Because it's ignored, you don't have to worry about committing sensitive information.
1. Add your connection string to your `Web.config` file.

### Step 2

Add a class library for your Dapper Product Repository so that you can move Dapper from your Controller.

* I would advise creating a brand new class library, but if you decide to link an existing project, make sure the project type is a class library or you'll get runtime errors

1. Call the new class library `ASPNETKata.Shared` (or link existing class library)
1. Copy the `IProductRepository`, `DapperProductRepository`, and `Product` files from your Inversion of Control project into the `ASPNETKata.Shared` folder
1. Add these existing files to your class library
1. Navigate to the list of references in your `ASPNETKata` project and add a reference to your class library

### Step 3

Remove the `Product.cs` model from your main project

* There should be no reference to your `Product.cs` anywhere in your Models folder or in the `ASPNETKata.Models` namespace. You'll be referencing the Product class from your Class Library

### Step 4

Add inversion of control via. Unity:

1. Downgrade `Unity.Mvc` to the most advanced `3` version. Something like this: `3.x.x`
1. Register your `IProductRepository` interface with your `DapperProductRepository` class
1. Register the `IDbConnection` interface with the `MySQLConnection` class

All code for accomplishing this should be in your Inversion of Control projects.

### Step 5

Add a constructor for your `ProductController` and a `private readonly` property to store your `IProductRepository`. Should look something like this:

```csharp
private readonly IProductRepository repo;

public ProductController(IProductRepository repo)
{
    this.repo = repo;
}
```

This allows Unity to set the `repo` to an instance of your `DapperProductRepository`

### Step 6

Confirm that everything is done. By the end of the above tasks, your project should:

* Have no reference to `using Dapper` within your main project
* Have no connection strings within your source code; it should be located in your `.config` file
* Have no Product class within your `Models` folder in your main project
