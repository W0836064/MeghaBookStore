Date: 27-10-2023
Time: 1:17pm

I have just gone through the file and started my work by creating a project using ASP.NET Core Web App with the Model-View-Controller (MVC) template. 
I named the project "MeghaBookStore" and selected the location on my desktop. I'm using ASP.NET Core 5.0 for this project. 
Following the instructions provided in the file, I'm now in the process of setting up my project.

Date: 27-10-2023
Time: 1:47pm

Following the instructions in the provided file, I've carefully reviewed all the contents and explored how everything functions. 
I've examined the default folders, including Controllers, Models, and Views, along with their respective subfolders.
In the "StartUp.cs" file, I made changes to the "AddDefaultIdentity" and "Run" options as indicated in the instructions.

Now, I'm moving on to Part 1.1, which involves setting up the project and thoroughly inspecting the default folders and their subfolders,
while also reviewing the code snippets provided in the file. 

Date: 27-10-2023
Time: 2:10pm

In Part 1.2, I'm making changes in the "Home" controller by adding two breakpoints in the "IActionResult" methods - "Index" and "Privacy."
After adding these breakpoints, I'm running the application.

Next, I'm testing the website by clicking on the "Home" and "Privacy" links to ensure they are working properly.

Date: 27-10-2023
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

Date: 27-10-2023
Time: 2:46pm

In Part 1.4, I'm starting by adding three new projects to the solution, named "MeghaBooks.DataAccess," "MeghaBooks.Models," and "MeghaBooks.Utility."

Then, I copy the "data" folder and paste it into the ".DataAccess" project, and delete the original file. After that, I install the "Microsoft.EntityFrameworkCore.Relational" and "Microsoft.EntityFrameworkCore.SqlServer" packages.
I also remove the migration and add the package reference to the "DataAccess" folder.

I delete the "Identity.EntityFrameworkCore" from the packages and install it again, making sure to modify the namespace to "MeghaBooks.DataAccess." Additionally, I delete the class from the three projects.

Next, I move the models to the "MeghaBooks.Models" project and delete the original ones.

I proceed to modify the "Views/Shared/Error.cshtml" file by adding the project references to ".DataAccess" and ".Models." 
I also rename the "Models" folder to "ViewModels" and change the namespace of "ErrorViewModel.cs" to "MeghaBookStore.Models.ViewModels."

During this process, I encounter an error and work on resolving it before continuing to create the project.

Date: 28-10-2023
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

Date:28-10-2023
Time: 3:12pm
Completed 

Assignment Part 2

Date:31-10-2023
Time: 6:12pm

