# _Best Restaurants_

#### By _**Ryan Ashby, Andy Plymate, Chase Stokes_**

#### _A webpage that allows the user to list restaurants by cuisines._

## Technologies Used

* _C#_
* _Markdown_
* _HTML5_
* _CSS_
* _Razor_
* _Bootstrap_

## Description

_A webpage that allows users to enter different restaurants, and list them by their cuisine type._

_The models used were thoroughly tested and use Object Oriented Programming best practices._

## Setup/Installation Requirements
* _Requires VSCode and MySql_

* _You can find the github repository [here](https://github-repo)_
* _Click the code button, and copy the https link_
* _In your in git bash or your preferred git terminal navigate to the directory you would like to store the project_
* _Enter: "git clone" followed by the https link_
* _Now that the repository is cloned to your computer, right click on the folder and click open with vs code_

_**In order to access a usable version of the sql database you will need to do the following:**_

* _Create a file named appsettings.json in the ToDoList directory_
* _The file should contain this block of code except with your own username and password for the server(brackets around private information not included):_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=[Your Id Goes Here];pwd=[Your Password Here];"
  }
}
```
* _Open MySQL and log into your server_
* _In the "Navigator" panel select the "Administration" tab._
* _Select "Data Import/Restore"_
* _Select "Import from self-contained file" navigate to to the BestRestaurants directory you cloned above and select best\_restaurants.sql_
* _In "Default Schema to be Imported to" select new and name the schema best\_restaurants_
* _NOTE: Make sure you name the file best\_restaurants or else the project won't locate the correct database_
* _Click Start Import_
* _The schema has now been added! You may need to refresh your databases to see the newly imported database_

* _Now in your terminal run "dotnet restore" to download csproj dependencies._
 * _Once all of the above is completed you can view the project on your local server by running "dotnet run"_


## Known Bugs

* _No known bugs_

## License - [MIT](https://opensource.org/licenses/MIT)

_If you run into any problems or find a bug, would like to reach me for a separate reason, feel free to send me an email at example@gmail.com with details of your issue._

Copyright (c) _2022_ _Ryan Ashby, Andy Plymate, Chase Stokes_