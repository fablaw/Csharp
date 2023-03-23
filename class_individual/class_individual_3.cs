using System;

public class Program
{
	public class Individual
  {
    public string Id{get;set;}

    public Individual(string id)
    {
      	Id=id;
    }

    public void GetId()
    {
      	Console.WriteLine("The ID is {0}.", Id);
    }
	}
  public class Person : Individual
  {
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string PostalAdd{get;set;}
    public int PhoneNum{get;set;}
    public string EmailAdd{get;set;}

    public Person(string id, string firstName, string lastName): base(id)
    {
      	FirstName=firstName;
      	LastName=lastName;
    }

    public void GetAllInfo()
    {
      	Console.WriteLine("First name: {0};\nLast name: {1};\nPostal addresse: {2};\nPhone number: {3};\nEmail addresse: {4}",FirstName, LastName, PostalAdd, PhoneNum, EmailAdd);
    }
    public void Salutations()
    {
      	Console.WriteLine("Salut {0} {1}! Comment vas-tu?", FirstName, LastName);
    }
  }
  public class Lettre
  {
    public string Expéditeur{get;set;}
    public string Destinataire{get;set;}
		public DateTime DateEnvoi {get;set;}
		public string Sujet {get;set;}
		public string CorpsLettre {get;set;}
		public string Signature {get;set;}
		public string EmailExpé{get;set;}
		public string EmailDest{get;set;}

		public Lettre(Person per1, Person per2)
		{
			Expéditeur=per1.FirstName;
			Destinataire=per2.FirstName;
			EmailExpé=per1.EmailAdd;
			EmailDest=per2.EmailAdd;
		}
		public string GetSendDate()
		{
			return DateEnvoi.ToString("d");
    	}
		public void GetTrace()
		{
			Console.WriteLine("This letter was sent from {0}:{1} to {2}:{3} on {4}.", Expéditeur, EmailExpé, Destinataire, EmailDest, GetSendDate());
		}
	}
	public static void Main()
	{
		Individual first=new Individual("S001");
		Console.WriteLine("==================================");
		Person perA=new Person("S001", "Jim", "Pearson");
		perA.Salutations();
		perA.PostalAdd="123, rue Mouffard";
		perA.PhoneNum=33456;
		perA.EmailAdd="jimp@gmail.com";
		perA.GetAllInfo();
		Console.WriteLine("==================================");
		Person perB=new Person("S002", "Jean", "Dubois");
		perB.Salutations();
		perB.PostalAdd="13, rue Batignole";
		perB.PhoneNum=34321;
		perB.EmailAdd="jeanb@gmail.com";
		perB.GetAllInfo();
		Console.WriteLine("==================================");
		Lettre letter1=new Lettre(perA, perB);
		letter1.DateEnvoi=new DateTime(2019,5,20);
		letter1.Sujet="Football game sat night";
		letter1.CorpsLettre="Are you going to the football game this sat night?";
		letter1.Signature="J";
		letter1.GetTrace();
	}
}
