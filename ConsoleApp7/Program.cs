using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace ConsoleApp7
{
   class Program
   {
      static void Main(string[] args)
      {
        // Output two WriteLine statements that display those two 
          //  variables with proper labels(My name is ..., I am from...) using String Interpolation.


         String name = "Jacob Thomas";
         String locationOfDev = "Rexburg, ID";

         Console.WriteLine("My name is "+name+", I am from " +locationOfDev+".");
         DateTime dateTime = DateTime.UtcNow.Date;
         Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));

         DateTime christmas = new DateTime(2019, 12, 24);
              
         int christmasTime = (int)(christmas - dateTime).TotalDays;
         Console.WriteLine("There are " + christmasTime + " days until Christmas");

         double width, height, woodLength, glassArea;
         string widthString, heightString;

         Console.WriteLine("Please enter the length of the wood.");
         widthString = Console.ReadLine();
         width = double.Parse(widthString);

         Console.WriteLine("Please enter the are of the glass.");
         heightString = Console.ReadLine();
         height = double.Parse(heightString);

         woodLength = 2 * (width + height) * 3.25;
         glassArea = 2 * (width * height);

         Console.WriteLine("The length of the wood is " +
         woodLength + " feet");
         Console.WriteLine("The area of the glass is " +
         glassArea + " square metres");
         

         Console.WriteLine("Press any key to quit.");
         Console.ReadKey();
      }
   }
}
