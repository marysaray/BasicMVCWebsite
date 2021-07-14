# Introduction to Model View Controller with ASP.NET Core.

### MVC Version 3.1
*Overview of ASP.NET Core MVC Resource:* https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1


    Creating Process:
    
        * Controller : Interface
            - Create the default controller
            - Controller suffix is expected on controller name
            - ex: HomeController
        * Action : Get Data
            - Create an action
            - Controller action
            - Public method in the controller
            - Typically returns IActionResult
        * View : Display Associated Content
            - Create a view
            - By default view name must match action and be in specific folder
            - /Views/ControllerName/ActionName
            - Visual Studio Razor View Template
            
Layout Pages Resource: https://docs.microsoft.com/en-us/aspnet/core/mvc/views/layout?view=aspnetcore-3.1            
                        
    Layouts:
        - Reduce code redundancy
        - Consistent theme
        - Defined in_ViewStart.cshtml
        
ViewData and ViewBag:

    * Views and Controllers both have access
        - Pass data from the controller to a View
        - Set <title> on a layout page
    * ViewData and ViewBag are similiar
        - ViewData is a dictionary
        - ViewBag is a dynamic object
    * Simple but no complile time checking
    
Linking Pages:

    Html Helpers:
        * Older ASP.NET MVC Convention
        * Can generate HTML/CSS markup
        - ex: @Html.ActionLink("Home Page", "Index", "Home")
        
    Tag Helpers:
        * Readable
        * Core syntax
        - ex: <a asp-controller="Home" asp-action="Index">Home Page</a>
   
## AlmostEmpty3-1StarterCode
This website has more starter code than the empty template for an ASP.NET Core MVC website.
Having a little more content allows for focusing on what makes a basic MVC website functional,
allowing the student to build a basic website themselves.
