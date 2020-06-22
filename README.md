# LeagueOfHeroes
Check the reviews of your fav heroes.

##Decisions
1. **Seed Data**
_Data is seeded by json files in data/seed and thru migrations since with that approeach we can trigger migrations from startup at launch_

2.**Repository pattern**
_this alows a separate data access logic organized and consumed thru interfaces_

3. **Auto mapper*
_In order to hide entities from the view, automappers 'maps' the entity and the viewmodel with explicit configuration and easy use_

4. **Async methods**
_Since is one of the best approach to manage concurrency and improve the performance when data scalates_

5. **Parallel processing at Median calculation*
_Each hero median is calculate in a different thread to take care of the performance when the data scalates*

6. **Connection strings**
_When development env, change to defaultconnection in startup otherwise will point to cloud database_

7. **Net core 3.1, Mysql 8.0.20 and Bootstrap 4.3.1**
_Net core 3.1 used since it is the latest version and supports multiplatform, Bootstrap used since offers great functionality and is easy to use_

##Project Structure
**All in one monolithic MVC application architecture**
_All the logic of the application is into a single project_

* Data Access layer
_Data folder contains subfolders for Entities, Migrations, Repositories, Seed and Aplication Context._

* Business Logic
_Services folder contains subfolder with interfaces and implementation of the services that handles all the logic in the application_

* User Interface Layer
_Views folder contains subfolders for all the screens in the application_

##Deployment

**Pushing code to staging branch will trigger a pipeline in Azure DevOps that will be ready to release manually trigering the release pipeline and publish the new version to the [site] (https://dev.azure.com/ajuarezdev/LeagueOfHeroes) **

-Azure DevOps Project: [here] (https://dev.azure.com/ajuarezdev/LeagueOfHeroes)


https://dev.azure.com/ajuarezdev/LeagueOfHeroes
