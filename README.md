# Executing-SSIS-Package-from-ASP.NET-App
Execute SSIS package using Microsoft.SqlServer.Dts.Runtime DLL
1.	Add the DLL “Microsoft.SqlServer.ManagedDTS” to the GAC of the computer on which the solution is deployed.
This is done by enabling “Microsoft SQL Server Data Tools” in the Microsoft Visual Studio installation wizard or 
by installing SQL Server Data Tools on the server from: https://msdn.microsoft.com/en-us/mt186501.aspx
2.	On IIS, create a separate application.
   These are the steps to create the new application pool for SSIS package.
     1.	Right click on Application Pools on the left hand side tree view and select ‘Add Application Pool.’

 
     2. Select the newly created app pool from the list of application pools and click on ‘Advanced Settings’ on the right most section of the IIS window. Select the properties as follows.
       a. Set “Enable 32-Bit Applications” to true.
       b. On the Identity property value, select “custom account” and specify the corresponding credentials that can have access to the Production database.
       c. Leave all other properties as it is.

