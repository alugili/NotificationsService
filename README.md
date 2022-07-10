# Notifications Service Code Management System Extension

## Motiviation 
Todo: need more discussion!

## Requirements </br>
  Prototype: Visual Studio 2022 / ASP.NET CORE / C# 10 </br>
  Architecture: PlantUML with Visual Studio Code : More info https://marketplace.visualstudio.com/items?itemName=jebbs.plantuml
 
   Other tools:
   https://www.docker.com/products/docker-desktop/

## NotificationsService project

### How to build the project?</br>
Clone and Open the solution file "NotificationService.sln" with VS2022 and press F5!
 
### How to open the architecture diagrams?</br>
Open the wsd files with VSCode and use the PlantUML extension to generate the Diagrams view.

### Project structure</br>
Based on Clean Architecture of Uncle Bob. 

![alt text](https://github.com/alugili/NotificationsService/blob/main/Prototype_VisualStudio.png?raw=true)
 
```

C:.
├───docs
│   └───diagrams  // Context, Container, Componenets Diagrams
│       ├───Application  // App Diagrams
│       ├───ClassDiagrams // Auto generated classes Diagrams
│       ├───Domain 
│       ├───Infrastructure
│       └───NotificationAPI
└───src
    ├───Application
    │   └───UseCases
    │       ├───Bitbucket
    │       └───Jira
    ├───Domain
    ├───Infrastructure
    └───NotificationAPI
        ├───Commands
        │   ├───Bitbucket
        │   └───Jira
        ├───Controllers
        └───Properties

```

## Architecture based on C4 Model : https://c4model.com/ <br>

**Context Diagram**
![alt text](https://github.com/alugili/NotificationsService/blob/main/docs/diagrams/SDK_Fix_Checkin_ContextView.png?raw=true)

**ContainersDiagram**
![alt text](https://github.com/alugili/NotificationsService/blob/main/docs/diagrams/SDK_Fix_Checkin_ContainerView.png?raw=true)

**Components Diagram**
![alt text](https://github.com/alugili/NotificationsService/blob/main/docs/diagrams/SDK_Fix_Checkin_ComponenetView.png?raw=true)

**Dynamic diagram**
![alt text](https://github.com/alugili/NotificationsService/blob/main/docs/diagrams/ClassesDiagram_Underwork.png?raw=true)




