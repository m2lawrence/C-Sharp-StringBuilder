// String Builder

using System;
using System.Text; //for StringBuilder.
//Without this, you would need to fully qualify the StringBuilder class as System.Text.StringBuilder.
namespace BuildName
{
	class BuildName
	{
		public static void Main(string[] args)
		{
			StringBuilder name = new StringBuilder();  //Object created to hold the string.
			string buffer;  //A string is created named buffer that will be used to get information from the user.
			//This information is obtained by using the ReadLine method in Console.
			int marker = 0; 
			
			Console.Write("\nEnter your first name: ");
			buffer = Console.ReadLine();
			
			if (buffer != null) 
			{
				name.Append(buffer);
				marker = name.Length;
				//The length of the first name is placed in a variable named marker, that will be used to determine where to place the middle name.
			}
			
			Console.Write("\nEnter your last name: ");                
			buffer = Console.ReadLine();  //Information is obtained by using the ReadLine method in Console.
			
			if (buffer != null) 
			{
				name.Append(" ");
				name.Append(buffer);
				//The last name is obtained second. This is appended to the name object right after a space is appended.
			}
			
			Console.Write("\nEnter your middle name: ");              
			buffer = Console.ReadLine();
			
			if (buffer != null) 
			{
				name.Insert(marker+1, buffer);
				name.Insert(marker+buffer.Length+1, " ");
				//Finally, the middle name is obtained and inserted into the middle of name using the Insert method. 
				//The marker saved earlier is used to determine where to insert the middle name.
			}
			
			Console.WriteLine("\n\nFull name: {0}", name);
			
			//Mikes stats:
			Console.WriteLine("\n\nInfo about StringBuilder string:"); 
			Console.WriteLine("value: {0}", name);
			Console.WriteLine("Capacity: {0}", name.Capacity);  //the current capacity that the name object can hold.
			Console.WriteLine("Maximum Capacity: {0}", name.MaxCapacity);  //the maximum value that this can be extended to.
			Console.WriteLine("Length: {0}", name.Length);  //the current length of the value is stored in name.
			Console.ReadKey(true); //pause.
		}
	}
}