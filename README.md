# REST JSON wrapper for a SOAP service

## Instructions
  To get the service up and running in your machine:
   * You have to configure the connection string in web.config for your machine's SQL server.
   * Run "update-database" command on project command prompt.
   * Send a and b as params and authorization token in header to the any of "/api/calculator/add", "/api/calculator/divide", "/api/calculator/multiply", "/api/calculator/subtract" endpoints to get the response.
   
## Features
   * Rest service has an authorization system. You need a bearer token to send requests. In order to get the token you need to post the username and password (username=client password=123 grant_type=password) to "/token" endpoint in body with "application/x-www-form-urlencoded" content type.
   * All requests to the REST service and SOAP service are logged in database.
   * Unit tests are included in project. 
   * Singleton design pattern is used in the project.
