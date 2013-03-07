******************************************************************
LLBLGen Pro remoting example READ-ME FILE
******************************************************************

Example Description
-------------------
- A VS.NET Solution that Shows how to implement a remoting solution with LLBLGenPro Adapter TemplateSet. The example
utilizes LLBLGen Pro's ultrafast remoting serialization feature
- The example is built against the famous Northwind database.
You may download it from Microsoft Download Center, if you don't have it already.

Folders:
--------
1. GUI: A Windows application acting as the client of the remoted service.
2. DAL: Contains the LLBLGen Pro generated code.
3. Interfaces: A library which defines the Service Interface which acts as the service contract and is referenced at the Service and the client.
4. RemotingService: the service application. 

The LLBLGen Pro project file, northwind.llblgenproj, has been included as well. 

How to Install
--------------
1. Use Visual Studio 2008 to open and build the solution found in the root folder: "\SD.LLBLGen.Pro.Examples.remoting.sln"
2. Please adjust the connection string to meet your environment in the app.config file of the RemotingService project.  

How To Run:
-----------
After building the solution, you should run the RemotingService console application. This starts the remoting service and you'll
then be able to connect to the service with the client. After the service was started, you should run the client to access the
service.

More about LLBLGen Pro & Remoting
------------------------------------
Please check ".NET Remoting support" in the LLBLGen Pro Help manual, in the following path:
"Using the generated code -> Adapter -> Distributed Systems -> .NET remoting support"

Help and support
----------------
LLBLGen Pro Help
LLGLGen Pro Reference Manual
http://www.llblgen.com/tinyforum