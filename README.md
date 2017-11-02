# ASPNETKata
Engage with ASP.NET MVC

## ASP.NET MVC Tasks
We're going to explore how we would use ASP.NET MVC to build an application that uses MVC:

1. We'll use a Person Model
1. We'll use a Person View and a Person List View to properly display our data
1. We'll use a Person Controller to control the interaction between our view and model

### Step 1
Fork and clone this repo

### Step 2
Add a Model called `Person`

This is just a `POCO` ([Plain Old CLR Object](https://en.wikipedia.org/wiki/Plain_old_CLR_object)), so just create a normal class called `Person`.

### Step 3
Add a Controller called `PersonController`

This will create a `PersonController.cs` file with default Controller implementation boiler plate code ready to go.

### Step 4
Add a List View for displaying your `Person`.

This gives us the default view for our Person Controller and the view we'll use for diplaying the list of people from our model.

### Step 5
Connect Everything Together

Use your controller to initialize a list of people and pass that list to your List People view.

### Step 6
Use Dapper and SQL for your Model

Do the steps above for the Product and grab that data from your localhost SQL server.

### Step 7
Make a pull request

**Good luck!**

## Ractive Tasks
Once this pull request has been accomplished, we're going to expand on it. We'll use Ractive to display our data with JavaScript.
