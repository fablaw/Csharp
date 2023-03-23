using System;
//using System.Collections.Generic;

public class Program
{
	public class Person
	{
		public string FirstName {get;set;}
		public int Age {get;set;}
		public string LastName {get;set;}

		public Person(string firstName, int age)
		{
			FirstName=firstName;
			Age=age;
		}

		public string GetFullName()
		{
			return FirstName+" "+LastName;
		}
	}

	public static void Main()
	{
		Person first=new Person("Steve", 35);
		Console.WriteLine(first.FirstName+" "+first.Age);
		Console.WriteLine("First person is {0}. He is {1} years old.", first.FirstName, first.Age);

		first.LastName="Jobs";
		Console.WriteLine(first.GetFullName());

		first.LastName="Gates";
		first.FirstName="Bill";
		Console.WriteLine(first.GetFullName());
	}
}
