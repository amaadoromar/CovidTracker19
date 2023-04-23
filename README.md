# CovidTracker19
UML design and C # and SQL programming of a Covid-19 patient tracking software.

# Covid-19 Patient Tracking Software

This is a software project developed using UML design, C# programming, and SQL database management to create a Covid-19 patient tracking software. The software allows users to add new suspected Covid-19 patients, update their state based on test results, and maintain a history of each patient's status changes. Additionally, the software provides statistics on the number of confirmed cases, active cases, recovered cases, and deaths.

# Usage

To use the software, follow these steps:

1 - Download the repository.

2 - Upload the SQL database file to your local database server.

3 - Update the SQL variable in the code to contain your database connection information. To do this, update all the matching lines that contain:

      static string sql = @"server=IP;user id=user;Password=pass;database=db";
      

Replace IP with the IP address of your database server, user with your database username, pass with your database password, and db with the name of the database  containing the Covid-19 patient data.

4 - Run the code. 

# Contribution

If you would like to contribute to the project, please fork the repository and make changes on your own branch. When you are ready, create a pull request for review.

# Informations and screenshots 

The graphical user interface (GUI) created using Windows Forms allows users to add and update patient data, view patient histories, and access statistics. The back-end of the software is powered by a SQL database that stores all the patient data and history.

UML informations : https://amaador.com/cproject/

![1](https://user-images.githubusercontent.com/71513920/233866320-383a1517-bcaf-4c6e-8d55-3d41dcadc10d.PNG)
![2](https://user-images.githubusercontent.com/71513920/233866353-b40c5a80-b0e1-400d-b123-99a195aa5ca5.PNG)
![4](https://user-images.githubusercontent.com/71513920/233866371-f3ba70d3-33aa-43ba-ad40-fd35bc105cc0.PNG)
![5](https://user-images.githubusercontent.com/71513920/233866378-569d2d6f-8930-4fc6-87aa-09c5869541bf.PNG)


