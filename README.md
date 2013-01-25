Develop an initial prototype version of the Bird Count application.  The prototype application will allow entry of the bird count data and will store the information in a relational database.  The application will also display summary count numbers based upon user request.

Detailed Problem Specification:

The initial bird count application must provide the following functionality:

1.	The application will read information from the Birds database and write information to that database.  You may find the database in the Databases section of the course.

2.	The application will allow entry of the following information:

a.	Region where the birds were observed
i.	 A list of regions should be retrieved from the database and the user should be able to choose from the list.
b.	Date of count
c.	Birder (person doing the count)
i.	A list of birders should be retrieved from the database and the user should be able to choose from the list.
d.	Bird (e.g., robin, blue jay, towhee)
i.	A list of birds should be retrieved from the database and the user should be able to choose from the list.
e.	Number of birds observed

 
3.	The application will save the information entered to the database when the user signals that they have completed their entry.


4.	The application will, upon user request, display a total count of birds for a specified date, region, bird and birder combination.  

a.	The user should be able to pick from a list of valid values for region, for bird, for birder and for date.  The list of valid values for each should be retrieved from the database. An example of a valid user request would be a count of robins done by John Smith on September 21, 2008 in the Northwest region.

b.	Additionally, the user should be able to specify “All” for the date, region, bird or birder as well as a valid value for each of those data elements.  So an example of a valid user request would be a count of all birds for the Northwest region on counted on September 21, 2008.
