Name: Megha Panchani
Project: Assignment2 Part 4
Date:2023-11-21
Updated Time:5:11pm


--------------------------
Assignment 1
---------------------------

Date: 2023-10-27
Time: 1:17pm(started)

I have just gone through the file and started my work by creating a project using ASP.NET Core Web App with the Model-View-Controller (MVC) template. 
I named the project "MeghaBookStore" and selected the location on my desktop. I'm using ASP.NET Core 5.0 for this project. 
Following the instructions provided in the file, I'm now in the process of setting up my project.

Date: 2023-10-27
Time: 1:47pm

Following the instructions in the provided file, I've carefully reviewed all the contents and explored how everything functions. 
I've examined the default folders, including Controllers, Models, and Views, along with their respective subfolders.
In the "StartUp.cs" file, I made changes to the "AddDefaultIdentity" and "Run" options as indicated in the instructions.

Now, I'm moving on to Part 1.1, which involves setting up the project and thoroughly inspecting the default folders and their subfolders,
while also reviewing the code snippets provided in the file. 

Date: 2023-10-27
Time: 2:10pm

In Part 1.2, I'm making changes in the "Home" controller by adding two breakpoints in the "IActionResult" methods - "Index" and "Privacy."
After adding these breakpoints, I'm running the application.

Next, I'm testing the website by clicking on the "Home" and "Privacy" links to ensure they are working properly.

Date: 2023-10-27
Time: 2:17pm

In Part 1.3, First, I visit bootswatch.com and select the "Quartz" theme, then download it. 
Afterward, I go to the "wwwroot" folder and replace the "bootstrap.css" file with the downloaded one. I also replace the "site.css" file with the provided one from Blackboard.

In the "View/Shared/_layout.cshtml" file, I rename the file to "bootstrap.css" and modify the "nav" class from "navbar-light" to "navbar-dark" and "bg-white" to "bg-primary." 
I remove the "text-dark" class from "nav-item" and add it to the footer class.

I make similar changes in the "_LoginPartial.cshtml" file by removing the "text-dark" class from "nav-item."

After making these changes, I run the project and notice the theme has successfully changed.
Then, I proceed to add the 3rd party tools mentioned in the file by including their links in the "_layout.cshtml" file in both the stylesheet and script sections.

I also add a dropdown navbar after the "Privacy" link, labeling it as "Content Management." Upon refreshing the page, I can see the "Content Management" dropdown with options like "Action," "Another action," and "Something else here." 
I review the page to confirm the changes.

Date: 2023-10-27
Time: 2:46pm

In Part 1.4, I'm starting by adding three new projects to the solution, named "MeghaBooks.DataAccess," "MeghaBooks.Models," and "MeghaBooks.Utility."

Then, I copy the "data" folder and paste it into the ".DataAccess" project, and delete the original file. After that, I install the "Microsoft.EntityFrameworkCore.Relational" and "Microsoft.EntityFrameworkCore.SqlServer" packages.
I also remove the migration and add the package reference to the "DataAccess" folder.

I delete the "Identity.EntityFrameworkCore" from the packages and install it again, making sure to modify the namespace to "MeghaBooks.DataAccess." Additionally, I delete the class from the three projects.

Next, I move the models to the "MeghaBooks.Models" project and delete the original ones.

I proceed to modify the "Views/Shared/Error.cshtml" file by adding the project references to ".DataAccess" and ".Models." 
I also rename the "Models" folder to "ViewModels" and change the namespace of "ErrorViewModel.cs" to "MeghaBookStore.Models.ViewModels."

During this process, I encounter an error and work on resolving it before continuing to create the project.

Date: 2023-10-28
Time: 2:19pm 

I've decided to start a new project since I encountered some errors while working on the Models part, and it was a bit challenging to fix them. This time, I'm following the same steps I did before, and things are progressing smoothly.

Continue of new project.I've also adjusted the "using" statement for data in the "Startup.cs" file, resolving all three errors one by one and running the application.

In the "MeghaBooks.Utility" project, I'm creating the "SeedData" and naming it "SD.cs." I'm modifying the class properties to be part of a public static class named "SD."

To ensure everything works together, I'm adding project references for "Utility" into the main project and also adding project references for "Models" and "Utility" into the "DataAccess" project.

Additionally, I'm creating a "Customer" area within the "Areas" folder. In the "Startup.cs" file, I'm changing the route in the endpoints by adding "area=Customer" to the pattern.

I'm moving the "HomeController.cs" to the "Areas/Customer/Controller" folder, and I've removed the Models and Data from the controller. In "HomeController.cs," I'm adding "Area("Customer")." 
I'm also relocating the "Views/Home" and modifying the "HomeController" namespace to match the changes.

I'm now copying the "ViewImport" and "Viewstart" files and pasting them into the "Customer" area. I'm also modifying the "_ViewStart.cshtml" file. Then, I run the application to ensure it works correctly.

Next, I'm creating a new folder called "Admin" within the "Area." I delete the "Data" and "Model" folders, along with the "Controller" folder. After doing this, I run the application again, and it's working perfectly.

To keep things updated, I'm pushing the code changes to the GitHub repository.

Date:2023-10-28
Time: 3:12pm
Completed 

-------------------------
Assignment Part 2
--------------------------

Date:2023-10-31
Time: 6:12pm(started)
 Time:6:51pm(completed)

 Going through the file and start Part2.1 Creating the DB . Modifying the database from appsettings.json and ue the NutPackage Manager Console for adding the migration (AddDefaultIdentityMigration). And change the default project file into the DataAccess and run .
 Adding the new migration (Read Me) with the same step.Now updating the database through PM console.
 Adding the category class file into the .Models and modify the code with given. Now , its time to add migration (AddCategoryToDb) and adding the one statement in the application Dbcontext and updating the database again and push into the github.


 Date: 2023-11-1
 Time: 5:06pm
 Time: 5:55pm

Now creating the Repository folder in .DataAccess inside creating one new folder IRepository . Creating the Irepository class file into the IRepository in that class adding the CRUD method and using statement .
Creating the new class(Repository.cs) in Repository folder. Adding the using statement and implementing the code in error word ,code generate automatically. And modifying the code with given folder.
Creating the CategoryRepository.cs  and ICategoryRepository.cs in Repository and IRepository folder.Modifying the code and ading the using statement . Need to add public interface in ICategory.cs same to apply implement coding .So as per i could run 
because i create an error so i am trying ot solve and error is building .So , now again doing the same step to follow the 2.1 part. And now succesfully I run the code .Push into the GITHUB.


Date: 2023-11-1
Time: 5:59pm
Time: 6:51pm

Creating the interface ISP_Call.cs in IRepository folder.Installing the Dapper through IDisposable .Adding the new class SP_Call in Repository . Adding the using statement of ISP.Updating the SP using the implementation.
Now, Creating the new interface IUnitOfWork.cs and UnitOfWork.cs in Repository and IRepository folder.Modifying the code.Registering into Start.up.Push into GitHub.


Date: 2023-11-1
Time: 6:52pm
Time: 7:11pm

Adding the MVCcontroller(CategoryController.cs) in Areas/Admin/Controller .Modifying the code in IUnitOfWork. Adding the new folder in Areas/View through Add Razor View with Category. 
Copying the given file assignment 2 (Viewtxt) and paste into Category/Index.cshtml .Run the application. In _Layout.cshtml changing the privacy intoo category and changing into the dropdown menu .
Modifying the font category/Index .Delete . And Push the code .


Date: 2023-11-1
Time: 7:15pm
Time: 8:27pm

In wwwroot/js and creating new js(Category.js) adding the javascript from the assignment 2 folder.In index.cshtml add the @section call.Run the application. Add the RazorView pf Upsert.cshtml in category.
Adding the coding as per given class , columns and all.Creating the partial view for edit and back View/Shared add partialView and enter the _CreateAndBackToListButton  and click the partial view and okay.
Now it that file adding the class  making the button of Submit and Index. Adding the asp-action.Following the method creating the _EditAndBackToListButton and adding the @model statement .
Push into the GitHub.


Date:2023-11-6
Time: 6:30pm
Time: 7:02pm

In  Upsert.cshtml adding the asp-action.Modifying the @title and run the application again.Also add the @section call script in Upsert.cshtml.adding the POST method in the CategoryController.cs.
Save method added. removing the _DbSaveChanges method and also moving the UnitOfWork_Save . Now run the application checked the project its running properly.Adding the API in categorycontroller.cs .
Implementing the category.js of HTTP Delete.Adding the delete functionality in category.js .Follow the code given . Run the application is working as per rquirement . Pushing the code into GitHub.


----------------------------
Assignment Part 3
----------------------------

******************
Section 1
******************

Date:2023-11-15
Time: 6:28pm(Started)
Time:7:03pm(Completed)

Starting the 3.1 CoverType CRUD
I have start my creating the CoverType.cs in Modal folder and doing same method mention in the other modal class.Adding the CoverTypeRepository and ICoverTypeRepository in Repository and IRepository and 
following the same method we have done in previous part. Now adding the CoverType in UnitWork and IUnitwork.And its time to create the migration and database.Creating the migration from tool and 
select MeghaBooks.DataAccess and adding the statement in PM Console - add migration AddCoverTypeToDb and upadten the Database with code update-database.
Performing  the CRUD operation for CoverType adding the NavBar, Action Method in Layout.html. Adding the Product Controller in Area/Admin/Controller.
Creating the Index and Upsert after creating the folder(CoverType)in the View.And copying the code from the CategoryController and pasting in the CoverTypeController. And I run the application and i get the error it was only showing the 
LOading in CoverType and the create was not working and taking back to the Repository.cs and it was solved afetr adding again the migration (add migration CoverTypeToDb-2).I completed the covertype and pushing the code to github .




Date:2023-11-16
Time: 3:04pm
Time:3:41pm

Starting 3.2 Product CRUD(1)
Adding the new class Product.cs in the Model Folder and adding the code given in file. Also, adding the product in the ApplicationDbContext.cs file. Adding the migration from the NutPackage and written the PM Console 
command - add-migration addProductToDb and updating database using update-database command. By mistake, i add the migration (addProductToDb-1) and showing the Product table in the SQL Server Object Explorer. And updating the Product.cs and now again  adding the new migration (addValidationToProduct) and update the database.
Now creating the IProductRepository interface and ProductRepository class in IRepository and Repository class. And also adding the product statement in IunitWork and UnitWork. Puch the code into GitHub.



******************
 Section2
******************

Date:2023-11-16
Time:3:44pm
Time: 4:10pm

Starting 3.2 Product CRUD(2)
Now Creating the ProductController in Area/Admin/Controller.Applying the same method provide in the file. By interface, installing the Microsoft.AspNetCore.Hoasting.Creating the ViewModel(ProductVM) in in model folder/Views.
Same, Installing the Microsoft.AspNetCore.Mvc.ViewFeatures package clicking the SelectLisItem doing the interface.Modifying the ProductController.cs iActionResult and UpsertCall and including the Microsofet.AspNetCore.Mvc.Rendering .
Commenting the UpsertPost . Including the category and covertype in API Call.Adding the index.cshtml clicking the index in productController.cs .Copy/paste the category.js into product.js and modifying the some statement.
Creating the product.js and now adding the link code in the _Layout.cshtml.  Run the Application.


********************
Section3 
********************

Date: 2023-11-16
Time:4:15pm
Time:6:09pm

Starting 3.2 Product CRUD(3)
Creating the Upsert in Area/Admin/Views/Product and copying the code from the CoverType and pasting into Product and now as per the instruction creating the in tiny.cloud by using the school id. and using the API key
Using the API key <script src="https://cdn.tiny.cloud/1/ux02gk5hno4omj9v6ax7akm331jeigeue38nulwiudu0jg2x/tinymce/6/tinymce.min.js" referrerpolicy="origin"></script> And adding the Sweet alert Msg . Run the Application and
the create new prouct table was displying in browser.Creating  the new folder and subfolder for images/products . In ProductController.cs  uncomment the Upsert code.And run the apllication and genrate the error while creating the product table
in covertype the option was showing of category so, error was solved by , Product/Upsert - modifying the statement category into covertype and update the database again Run the appliaction.push the code.



---------------------------
Assignment 2 Part 4
---------------------------

Date: 2023-11-21
Time: 3:45pm(Started)
Time: 5:11pm(Completed)

Firstly, figuring out the code and where to add. Adding the image url code from the given file in Area/Admin/Controller/View/Product in Upsert.cshtml. So, In Area/Customer/Views/Home in index.cshtml modifying the whole code,
as per given file in that index.cshtml it is about the product model to display the image of book , url link, color and all. Now, editing the ProductController.cs from Area/Admin/Controllers Adding the Getall and delete code
and tally the code from given code.

I get the error in ProductController.cs because adding the using statementthe IO and after again run the code and application starts running .And also adding the downloading 3 images in wwwroots/images/products.
Test the application and create the category,covertype and product and add the images. Successfully the BookCover showing in the Home page . Push the code to GitHUb.


