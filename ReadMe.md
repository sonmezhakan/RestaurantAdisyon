# RestaurantAdisyon Project 

This is a restaurant billing project. The project is developed following the N-tier architecture. Additionally, the initial goal of the project is to build a Windows Forms application. It adheres to the SOLID Principles for a well-organized structure. Microsoft SQL is used as the database. I plan to make further additions as I enhance my skills in .NET technology in the future.

## SOLID Principles

In object-oriented programming, SOLID principles are design patterns used to make software design more understandable, flexible, and sustainable.

1. Single Responsibility Principle,
2. Open/Closed Principle
3. Liskov Substitution Principle
4. Interface Segregation Principle
5. Dependency Inversion Principle

For more detailed information [GitHub Pages](https://github.com/sonmezhakan/SOLID/tree/master).

## NTier Architecture

NTier Architecture ensures the development of a project by dividing its responsibilities through layers. Each layer has its own set of responsibilities, making the application sustainable, extensible, and more suitable for teamwork. By breaking down our code into smaller structures, we enhance maintainability and updatability. NTier Architecture fundamentally consists of some commonly used layers. These include:

1. Business Layer(BLL)
2. Data Layer(DAL)
3. Entity Layer
4. Presentation Layer

### 1.Business Layer(BLL)

The user's requests are implemented in conjunction with the Business Layer (BLL). This layer encapsulates the fundamental business logic of the application.

### 2.Data Layer(DAL)

The Data Layer enables us to access the database and perform various operations related to it.

### 3.Entity Layer

This layer facilitates the association of objects used within the application with tables in the database. The Entity Layer is generally supported by Object-Relational Mapping (ORM) tools.

ORM serves as an interface handling the differences between objects and relational databases. It maps the data in the database to objects, managing the relationships between these objects.

### 4.Presentation Layer

This layer interacts with users and involves creating the visual interfaces of applications using front-end technologies.

In addition to the basic layers mentioned above, depending on your project, you can create additional layers to make the project more extensible.

## Technologies

- .Net
- MsSql

## Libraries

- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/)
- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/)
- [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/)