Software Engineering Problem - Version 1
Source Control Overview
Your team is tasked with the development of the next great open-source distributed version control system designed to handle everything from small to exceptionally large projects with speed and efficiency.

Some of your competitors are:
• https://github.com/
• https://bitbucket.org/
• https://gitlab.com/

Requirements:
The requirements for the first version of the application are simple. 
Hint: Read the requirements and check the Your Tasks section before you begin implementation.

 • Create a basic and simplified registration and login.
• Every user who is signed in can create repositories.
• Repositories can be public or private
• Repository owners can add other registered users as contributors. They can also remove them from the list of contributors.
• Every user can see all the public repositories, all his private repositories, and additionally, all the private repositories to which he/she can contribute
• Every user can create issues in the public repositories. Only contributors can create issues in private repositories
• Only contributors can create commits in both public and private repositories
• A commit should contain a list of modifications. Each modification must include a filename, file differences, and modification type (Added/ Modified/Deleted). Hint: It is sufficient to store the file differences as text.
 • An issue should have a description, tags, and status (Open/ On Hold/Closed)
• When viewing the list of repositories, commits, and issues, the most recent entries should be on top.
• The users should be able to search in the list of repositories, commits, and issues by title. 
• The users should be able to filter the list of commits by author.
• The users should be able to filter the list of issues by status
• The users can edit their issues. The repository owners can edit issues created by the other users.
ALL
• The users can delete their repositories and issues.
• The users can add pull requests to a repository.
• The repository owner can accept or reject your pull request.
• The pull request should include a list of commits from a repository that you own.
• If the repository owner accepts the pull request, the list of associated commits should be added to the repository.
• When viewing the list of pull requests, the most recent entries should be on top.
• Only the pull requests that are not resolved should be displayed


Technology stack
The solutions architect has chosen the following technologies:
• ASP.NET Core 6.0 with C#
• Entity Framework Core
• MS SOL Server
• React v18


Your Tasks:
As part of the developer team that will be implementing the application features, you have been assigned to complete the following tasks:
1. Create the application database model
• Implement the entities with the correct data types and their relations
• Add indexes and column constraints
• Use Entity Framework Core

2. Create the Web API endpoints
• Create the controllers
• Create the endpoints (controller actions)
• Ensure adequate routes, route parameters, query parameters, and request models
• Validate the endpoint input models
• Do NOT implement the endpoints. Just throw a Not Implemented Exception
• Use ASP.NET Core 6.0

3. Create a repository management page
• Implement the CRUD endpoints for the repositories
ALL
• List the repositories, the most recent on top
• Add a section for repository creation
• Add a delete option for each repository list item.
• Add a search input and implement a server-side search by repository title.
• Do not bother with authentication/authorization. Mock the repository author data.
• Use React

Scoring
1. Entity Framework Database Model -40 points
2.ASP.NET Web API Endpoints - 30 points
3. React Repository Management - 30 points

If your file size is too large, please delete the bin, obj, and node_modules folders.
Drag and Drop File:
Add File
