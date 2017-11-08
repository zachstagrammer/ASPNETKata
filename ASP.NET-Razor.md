# ASP.NET MVC

## Tasks

We're going to explore how we would use ASP.NET MVC to build an application that uses MVC:

1. We'll use a Person Model
1. We'll use a Person View and a Person List View to properly display our data
1. We'll use a Person Controller to control the interaction between our view and model

### Step 1

Add a Model called `Person`

This is just a `POCO` ([Plain Old CLR Object](https://en.wikipedia.org/wiki/Plain_old_CLR_object)), so just create a normal class called `Person`.

### Step 2

Add a Controller called `PersonController`

This will create a `PersonController.cs` file with default Controller implementation boiler plate code ready to go.

### Step 3

Add a List View for displaying your `Person`.

This gives us the default view for our Person Controller and the view we'll use for diplaying the list of people from our model.

### Step 4

Connect Everything Together

Use your controller to initialize a list of people and pass that list to your List People view.

### Step 5

Use Dapper and SQL for your Model

Do the steps above for the Product and grab that data from your localhost SQL server.

Make sure that you have Index, Create, Edit, Details, and Delete views for your Product.