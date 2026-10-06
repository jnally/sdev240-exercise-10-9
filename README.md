# sdev240-exercise-10-9

<img width="1072" height="193" alt="build" src="https://github.com/user-attachments/assets/e072645e-76b4-4e21-99f1-2daa9e741efc" />

<img width="1072" height="108" alt="run" src="https://github.com/user-attachments/assets/81ea9b7a-e1aa-45d8-b8fe-626f17e3e365" />

Assignment Instructions

Summary
Create an abstract class named Salesperson. Fields include firstName and lastName; the Salesperson constructor requires both these values. Include properties for the fields. Include a method called GetName that returns a string that holds the Salesperson’s full name—the first and last names separated by a space.

Create an interface named ISellable that contains two methods: SalesSpeech() and MakeSale().

Create two child classes of Salesperson: RealEstateSalesperson and GirlScout. The RealEstateSalesperson class contains fields for the following:

TotalValueSold - The total value sold in dollars (an int initialized to 0)

TotalCommissionEarned - Total commission earned (a double initialized to 0)

CommissionRate - The commission rate (a double required as the last argument to the class constructor, after first name and last name).

The GirlScout class includes a field (TotalBoxes of type int) to hold the number of boxes of cookies sold, which is initialized to 0. Include properties for every field. In each RealEstateSalesperson and GirlScout class, implement SalesSpeech() to display an appropriate one- or two-sentence sales speech that the objects of the class could use. In the RealEstateSalesperson class, implement the MakeSale() method to accept an integer dollar value for a house, add the value to the RealEstateSalesperson’s total value sold, and compute the total commission earned. In the GirlScout class, implement the MakeSale() method to accept an integer representing the number of boxes of cookies sold and add it to the total field.

Write a program named SalespersonDemo that instantiates RealEstateSalesperson and GirlScout objects. Demonstrate that each object can use a SalesSpeech() method appropriately. Also, use a MakeSale() method two or three times with each object, and display the final contents of each object’s data fields.

In order to prepend the $ to currency values, the program will need to use the CultureInfo.GetCultureInfo method. In order to do this, include the statement using System.Globalization; at the top of your program and format the output statements as follows: WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));
