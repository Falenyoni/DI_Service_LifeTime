### Dependency Injection Lifetimes in .NET Core

##Dependency Injection Service Lifetimes

1. Transient  
 * Its the safest one,
 * It means whenever we want any implementation, create a new object and give that new object,
 * you never have to re-use an existing object every time a service is requested a new implementation is created


2. Scoped
* It depends on the HTTP Request
* Whenever an HTTP Request is sent to the server that time for that scope on lifetime will be created
* And then the same object or same service is used whenever in that request the service is requested
* Say for one single page load we are calling a service 10 times it will only create that object once and it will that same object 10 times in that one request
* But then if the next request comes in then a new implementation is created.

3. Singleton
* One implementation is created for the lifetime of the application
* So once the application starts we create an object of that service or implementation and that is used for all the upcoming requests unless you restart the application

** The scoped is one of the most recommended approaches for web applications, because of that a service will be created on each request 

