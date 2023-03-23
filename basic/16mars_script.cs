using System;
					
public class Program
{
	public static void Main()
	{
		string aFriend="Maria";
		Console.WriteLine(aFriend);
		Console.WriteLine("Hello "+aFriend+"!");
		Console.WriteLine($"Hello 'say' {aFriend}!");
		string bFriend="Sage";
		Console.WriteLine($"My friends are {aFriend} and {bFriend}.");
		Console.WriteLine(aFriend.Length);
		Console.WriteLine(bFriend.Length.GetType());
		Console.WriteLine($"The name {aFriend} has {aFriend.Length} letters.");
		Console.WriteLine($"The name {bFriend} has {bFriend.Length} letters.");
		string greeting="   Hello World!   ";
		Console.WriteLine($"[{greeting}]"); 
		Console.WriteLine($"[{greeting.TrimStart()}]"); //to remove empty spaces before caracters
		Console.WriteLine($"[{greeting.TrimEnd()}]"); //to remove empty spaces after caracters
		Console.WriteLine($"[{greeting.Trim()}]"); //to remove empty spaces before and after caracters
		Console.WriteLine($"[{greeting.Replace(" ", "")}]"); //to replace all empty spaces within the string
	}
}
using System;
					
public class Program
{
	public static void Main()
	{
		int counter=0;
		while (counter<10)
		{
			Console.WriteLine($"Hello World! The counter is {counter}.");
			counter++;
		}
		counter=23;
		do 
		{
			Console.WriteLine($"The counter is {counter}.");
			counter++;
		}
		while (counter<25);
		for (counter=0; counter<10; counter=counter+2)
		{
			Console.WriteLine($"Hello World! The new counter is {counter}.");
		}
		for (int row=1; row<11; row++)
		{
			Console.WriteLine($"The row is {row}.");
		}
		for (char column='a'; column<'k'; column++)
		{
			Console.WriteLine($"The column is {column}"); //increment of character from a to z
		}
		for (int row=1; row<11; row++)
		{
			for (char column='a'; column<'k'; column++)
			{
				Console.WriteLine($"The cell is ({row},{column})");
			}
		}
	}
}
using System;
					
public class Program
{
	public static void Main()
	{
		/*for (int i=600000000; i<700000000; i++)
		{
			Console.WriteLine("0"+i);
		} */
		List<int> numbers = new List<int>();
		for (int i=600000000; i<700000000; i++)
		{
			numbers.Add(i);
		}
		Random rnd=new Random();
		HashSet<int> selectNum = new HashSet<int>();
		while (selectNum.Count <11)
		{
			int rand = rnd.Next(numbers.Count);
			selectNum.Add(rand);
		}
		foreach (int j in selectNum)
		{
			Console.WriteLine("0"+j);
		}
	}
}
using System;
					
public class Program
{
	public static void Main()
	{
		/*for (int i=600000000; i<700000000; i++)
		{
			Console.WriteLine("0"+i);
		} */
		string input="Bonjour, toto";
		if  (!input.Contains(" "))
		{
			Console.WriteLine("Informer illisible"); 
		}
		else if ((input.Length <250) || (!input.ToLower().Contains("bonjour")))
		{
			if (input.ToLower().Contains("bonjour"))
			{
				Console.WriteLine("Informer l'utilisateur: Moins de 250 caractères");
			}
			else 
			{
				Console.WriteLine("Informer l'utilisateur: Soyez Poli");
			}
		}
		else
		{
			string output=input.ToLower().Replace("bonjour","Coucou");
			Console.WriteLine(output);
		}
		var names= new List<string>{"Jean-Baptiste","Ana","Felipe"};
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}
		Console.WriteLine();
		names.Add("Maria");
		names.Add("Bill");
		names.Remove("Ana");
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}
		Console.WriteLine($"My name is {names[0]}.");
		Console.WriteLine($"I've added {names[2]} and {names[names.Count-1]} to the list.");
		Console.WriteLine($"The list has {names.Count} people in it.");
		var index=names.IndexOf("Felipe");
		if (index!=-1)
		{
			Console.WriteLine($"The name {names[index]} is at index {index}.");
		}
		else
		{
			//var notFound=names.IndexOf("Not Found");
			Console.WriteLine($"When an item is not found, IndexOf returns {index}.");
		}
		names.Sort();
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}
		
		var fnum = new List<int>{1,1};
		int d = fnum[fnum.Count-1];
		int e = fnum[fnum.Count-2];
		int f = 0;
		for (int i=0; i<18; i++)
		{
			f = d+e;
			fnum.Add(f);
			d = e;
			e = f;
		}
		foreach (int j in fnum)
		{
			Console.WriteLine(j);
		}
		var fnum = new List<int>{1,1};
		for (int i=0;i<18;i++)
		{
			int val1 = fnum[fnum.Count-1];
			int val2 = fnum[fnum.Count-2];
			fnum.Add(val1+val2);
		}
		foreach (int j in fnum)
		{
			Console.WriteLine(j);
		}
	}
}
using System;
//using System.Collections.Generic;
					
public class Program
{
	public class Person
	{
		public string Name {get;set;}
		public int Age {get;set;}
		
		public Person(string name, int age)
		{
			Name=name;
			Age=age;
		}
	}
	
	public static void Main()
	{
		Person first=new Person("Job", 35);
		Console.WriteLine(first.Name+" "+first.Age);
		Console.WriteLine("First personne is {0}. He is {1} years old.", first.Name, first.Age);
	}
}
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
using System;
using System.Collections.Generic;
					
public class Program
{
	public class Lettre
	{
		public string Expéditeur {get;set;}
		public string Destinataire {get;set;}	
		public DateTime DateEnvoi {get;set;}
		public string Sujet {get;set;}
		public string CorpsLettre {get;set;}
		public string Signature {get;set;}
		
		public Lettre(string expéditeur, string destinataire)
		{
			Expéditeur=expéditeur;
			Destinataire=destinataire;
		}
		public string GetSubjetContain()
		{
			return Sujet+": "+CorpsLettre;
		}
		public string GetSignature()
		{
			return $"This letter was signed by {Signature}";
		}
		public string GetSendDate()
		{
			return DateEnvoi.ToString("d");
		}
		public string GetSenderRecipient()
		{
			return $"This letter was sent to {Destinataire} by {Expéditeur}";
		}
		public string GetSummary()
		{
			return GetSenderRecipient()+" on "+GetSendDate()+" and signed by "+Signature;
		}
		public int NumberChar()
		{
			return Expéditeur.Replace(" ","").Length;
		}
		public int TotalChar()
		{
			var total=GetSendDate().Length+Expéditeur.Length+Destinataire.Length+Sujet.Length+CorpsLettre.Length+Signature.Length;
			return total;
		}
	}
	public static string SameSender(string a,string b)
	{
		if (a==b)
		{
			return "Both letters have the same sender.";
		}
		return "Both letters do not have the same sender.";
	}
	public static void DayDifference(DateTime a, DateTime b)
	{
		var diffOfDays= a-b;
		Console.WriteLine($"The difference in days between sending dates is {Math.Abs(diffOfDays.Days)} days.");
	}
	public static void BigLetters(List<Lettre> listeLettre)
	{
		foreach (var item in listeLettre)
		{
			if (item.TotalChar()>50)
			{
				Console.WriteLine(item.GetSubjetContain()+". "+item.GetSummary());
			}
		}
	}
	public static void Main()
	{
		Lettre first=new Lettre("Lee", "Yu");
		first.DateEnvoi= new DateTime(2017,8,24);
		first.Sujet="Urgent";
		first.CorpsLettre="Please reply immediately!";
		first.Signature="L";
		
		Console.WriteLine(first.GetSenderRecipient());
		Console.WriteLine(first.GetSubjetContain());
		Console.WriteLine(first.GetSendDate());
		Console.WriteLine(first.GetSignature());
		Console.WriteLine(first.GetSummary());
		Console.WriteLine($"There are {first.NumberChar()} characters in the sender's name.");
		Console.WriteLine($"There are {first.TotalChar()} characters in this letter.");
		
		Console.WriteLine("=====================================================");
		
		Lettre second=new Lettre("Lee", "Liao");
		second.DateEnvoi= new DateTime(2018,12,4);
		second.Sujet="Note";
		second.CorpsLettre="Notes for today";
		second.Signature="P";
		
		Console.WriteLine(second.GetSenderRecipient());
		Console.WriteLine(second.GetSubjetContain());
		Console.WriteLine(second.GetSendDate());
		Console.WriteLine(second.GetSignature());
		Console.WriteLine(second.GetSummary());
		Console.WriteLine($"There are {second.TotalChar()} characters in this letter.");
		
		Console.WriteLine("======================================================");
		Console.WriteLine(SameSender(first.Expéditeur, second.Expéditeur));
		DayDifference(first.DateEnvoi,second.DateEnvoi);
		
		Console.WriteLine("=====================================================");
		var listeLettre=new List<Lettre>{first,second};
		Lettre third=new Lettre("Jan","Tim");
		third.DateEnvoi=new DateTime(2019,5,21);
		third.Sujet="See attachment";
		third.CorpsLettre="Please see attachment";
		third.Signature="J";
		listeLettre.Add(third);
		
		Lettre forth=new Lettre("Jim","Tom");
		forth.DateEnvoi=new DateTime(2019,8,21);
		forth.Sujet="Football game Sat night";
		forth.CorpsLettre="Please let me know if you're going";
		forth.Signature="J";
		listeLettre.Add(forth);	
		
		Lettre fifth=new Lettre("Johan","Kim");
		fifth.DateEnvoi=new DateTime(2020,5,21);
		fifth.Sujet="Dinner Party";
		fifth.CorpsLettre="Can you confirm the date and time?";
		fifth.Signature="J";
		listeLettre.Add(fifth);
		
		BigLetters(listeLettre);
	}
}
using System;
					
public class Program
{
	public class Meubles
	{
		public string Matière{get;set;}
		public double Hauteur{get;set;}
		public double Longeur{get;set;}
		public double Largeur{get;set;}
		public double Poids{get;set;}
		public bool Plié{get;set;}
		public int PosX{get;set;}
		public int PosY{get;set;}
		
		public Meubles(string matière, double hauteur, double longeur, double largeur, double poids)
		{
			Matière=matière;
			Hauteur=hauteur;
			Longeur=longeur;
			Largeur=largeur;
			Poids=poids;
		}
		public string Plier()
		{
			if (Plié == true)
			{
				return "Le meuble est déjà plié.";
			}
			Plié=true;
			return "Le meuble sera plié.";
		}
		public string Déplier()
		{
			if (Plié == true)
			{
				Plié=false;
				return "Le meuble sera déplié.";
			}
			return "Le meuble est déjà déplié.";
		}
		public string Déplacer(int newPosX, int newPosY)
		{
			if ((newPosX==PosX) && (newPosY==PosY))
			{
				return "Le meuble ne peut pas être déplacé.";
			}
			double distA=newPosX-PosX;
			double distB=newPosY-PosY;
			double distC=Math.Round(Math.Sqrt(Math.Pow(distA, 2.0)+Math.Pow(distB,2.0)),2);
			PosX=newPosX;
			PosY=newPosY;
			return $"La nouvelle position du meuble est ({newPosX},{newPosY}). La distance de déplacement est {distC}.";
		}
		public string PasserPorte(double hauteurPorte, double longeurPorte)
		{
			if ((hauteurPorte>Hauteur+5) && (longeurPorte>Longeur+5))
			{
				return "Le meuble peut passer la porte.";
			}
			return "Le meuble ne peut pas passer la porte.";
		}
	}
	public static void Main()
	{
		Meubles a=new Meubles("bois", 15.0, 5.0, 5.0, 45.0);
		a.Plié=true;
		a.PosX=15;
		a.PosY=-5;
		
		Console.WriteLine(a.Plier());
		Console.WriteLine(a.Déplier());
		Console.WriteLine(a.Déplacer(20,-5));
		Console.WriteLine(a.PasserPorte(8.0,2.0));
		Console.Write(a.Plié+" "+a.PosX+" "+a.PosY);
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public class Lettre
	{
		public string Expéditeur {get;set;}
		public string Destinataire {get;set;}	
		public DateTime DateEnvoi {get;set;}
		public string Sujet {get;set;}
		public string CorpsLettre {get;set;}
		public string Signature {get;set;}
		
		public Lettre(string expéditeur, string destinataire)
		{
			Expéditeur=expéditeur;
			Destinataire=destinataire;
		}
		public string GetSubjetContain()
		{
			return Sujet+": "+CorpsLettre;
		}
		public string GetSignature()
		{
			return $"This letter was signed by {Signature}";
		}
		public string GetSendDate()
		{
			return DateEnvoi.ToString("d");
		}
		public string GetSenderRecipient()
		{
			return $"This letter was sent to {Destinataire} by {Expéditeur}";
		}
		public string GetSummary()
		{
			return GetSenderRecipient()+" on "+GetSendDate()+" and signed by "+Signature+".";
		}
		public int NumberChar()
		{
			return Expéditeur.Replace(" ","").Length;
		}
		public int TotalChar()
		{
			var total=GetSendDate().Length+Expéditeur.Length+Destinataire.Length+Sujet.Length+CorpsLettre.Length+Signature.Length;
			return total;
		}
		public void TotalWords()
		{
			string total=Sujet+" "+CorpsLettre+" "+Signature;
			char[] separators=new char[]{' ','.','?',','};
			string[] words=total.Split(separators, StringSplitOptions.RemoveEmptyEntries);
			Console.WriteLine($"The number of words in this letter is {words.Count()}.");
		}
	}
	public static string SameSender(string a,string b)
	{
		if (a==b)
		{
			return "Both letters have the same sender.";
		}
		return "Both letters do not have the same sender.";
	}
	public static void DayDifference(DateTime a, DateTime b)
	{
		var diffOfDays= a-b;
		Console.WriteLine($"The difference in days between sending dates is {Math.Abs(diffOfDays.Days)} days.");
	}
	public static void LongLetters(List<Lettre> listeLettre)
	{
		foreach (var item in listeLettre)
		{
			if (item.TotalChar()>50)
			{
				Console.WriteLine(item.GetSubjetContain()+" "+item.GetSummary());
			}
		}
	}
	public static void DateRange(List<Lettre> listeLettre)
	{
		var dateList=new List<DateTime>{};
		foreach (var item in listeLettre)
		{
			dateList.Add(item.DateEnvoi);
		}
		DateTime maxDate=dateList.Max();
		DateTime minDate=dateList.Min();
		Console.WriteLine($"These letters were sent between {minDate.ToString("d")} and {maxDate.ToString("d")}.");
	}
	public static void Main()
	{
		Lettre first=new Lettre("Lee", "Yu");
		first.DateEnvoi= new DateTime(2017,8,24);
		first.Sujet="Urgent";
		first.CorpsLettre="Please reply immediately!";
		first.Signature="L";
		
		/*Console.WriteLine(first.GetSenderRecipient());
		Console.WriteLine(first.GetSubjetContain());
		Console.WriteLine(first.GetSendDate());
		Console.WriteLine(first.GetSignature());
		Console.WriteLine(first.GetSummary());
		Console.WriteLine($"There are {first.NumberChar()} characters in the sender's name.");
		Console.WriteLine($"There are {first.TotalChar()} characters in this letter.");
		
		Console.WriteLine("=====================================================");*/
		
		Lettre second=new Lettre("Lee", "Liao");
		second.DateEnvoi= new DateTime(2018,12,4);
		second.Sujet="Note";
		second.CorpsLettre="Notes for today";
		second.Signature="P";
		
		/*Console.WriteLine(second.GetSenderRecipient());
		Console.WriteLine(second.GetSubjetContain());
		Console.WriteLine(second.GetSendDate());
		Console.WriteLine(second.GetSignature());
		Console.WriteLine(second.GetSummary());
		Console.WriteLine($"There are {second.TotalChar()} characters in this letter.");
		
		Console.WriteLine("======================================================");*/
		Console.WriteLine(SameSender(first.Expéditeur, second.Expéditeur));
		DayDifference(first.DateEnvoi,second.DateEnvoi);
		
		Console.WriteLine("=====================================================");
		var listeLettre=new List<Lettre>{first,second};
		Lettre third=new Lettre("Jan","Tim");
		third.DateEnvoi=new DateTime(2019,5,21);
		third.Sujet="See attachment";
		third.CorpsLettre="Please see attachment.";
		third.Signature="J";
		listeLettre.Add(third);
		
		Lettre forth=new Lettre("Jim","Tom");
		forth.DateEnvoi=new DateTime(2019,8,21);
		forth.Sujet="Football game Sat night";
		forth.CorpsLettre="Please let me know if you're going.";
		forth.Signature="J";
		listeLettre.Add(forth);	
		
		Lettre fifth=new Lettre("Johan","Kim");
		fifth.DateEnvoi=new DateTime(2020,5,21);
		fifth.Sujet="Dinner Party";
		fifth.CorpsLettre="Can you confirm the date and time?";
		fifth.Signature="J";
		listeLettre.Add(fifth);
		
		LongLetters(listeLettre);
		Console.WriteLine("=====================================================");
		DateRange(listeLettre);
		forth.TotalWords();
	}
}
using System;
					
public class Program
{
	public class Meubles
	{
		public string Matière{get;set;}
		public double Hauteur{get;set;}
		public double Longeur{get;set;}
		public double Largeur{get;set;}
		public double Poids{get;set;}
		public int PosX{get;set;}
		public int PosY{get;set;}
		
		public Meubles()
		{
		}
		public string Déplacer(int newPosX, int newPosY)
		{
			if ((newPosX==PosX) && (newPosY==PosY))
			{
				return "Le meuble reste sur sa position actuelle.";
			}
			double distA=newPosX-PosX;
			double distB=newPosY-PosY;
			double distC=Math.Round(Math.Sqrt(Math.Pow(distA, 2.0)+Math.Pow(distB,2.0)),2);
			PosX=newPosX;
			PosY=newPosY;
			return $"La nouvelle position du meuble est ({newPosX},{newPosY}). La distance de déplacement est {distC}.";
		}
		public string PasserPorte(double hauteurPorte, double largeurPorte)
		{
			if ((hauteurPorte>Hauteur+5) && (largeurPorte>Longeur+3))
			{
				return "Le meuble peut passer la porte.";
			}
			return "Le meuble ne peut pas passer la porte.";
		}
	}
	public class ChaisePliante : Meubles
	{
		public int Pieds{get;set;}
		public bool Plié{get;set;}
		
		public ChaisePliante(string matière, double hauteur, double longeur, double largeur, double poids, int pieds)
		{
			Matière=matière;
			Hauteur=hauteur;
			Longeur=longeur;
			Largeur=largeur;
			Poids=poids;
			Pieds=pieds;
		}
		public void Plier()
		{
			if (Plié)
			{
				Console.WriteLine("La chaise pliante est déjà pliée.");
			}
			else
			{
				Plié=true;
			}
		}
		public void Déplier()
		{
			if (Plié)
			{
				Plié=false;
			}
			else
			{
				Console.WriteLine("La chaise pliante est déjà dépliée.");
			}
		}
	}
	public static void Main()
	{
		Meubles a=new Meubles();
		a.Matière="bois";
		a.Hauteur=15.0;
		a.Longeur=5.0;
		a.Largeur=5.0;
		a.Poids=45.0;
		a.PosX=15;
		a.PosY=-5;
		
		Console.WriteLine(a.Déplacer(20,10));
		Console.WriteLine(a.PasserPorte(8.0,2.0));
		Console.WriteLine("Position actuelle:("+a.PosX+","+a.PosY+").");
		Console.WriteLine(a.Déplacer(20,10));
		
		Console.WriteLine("================================================");
		ChaisePliante b=new ChaisePliante("bois", 8.0, 3.0, 3.0, 25.0, 4);
		b.Plié=true;
		b.Plier();
		b.Déplier();
		Console.WriteLine(b.Déplacer(10,8));
		Console.WriteLine(b.PasserPorte(15.0,8.0));
		Console.WriteLine("Etat plié actuel:"+b.Plié+". Position actuelle:("+b.PosX+","+b.PosY+").");
	}
}
using System;
					
public class Program
{
	public class Meubles
	{
		public string Matière{get;set;}
		public double Hauteur{get;set;}
		public double Longeur{get;set;}
		public double Largeur{get;set;}
		public double Poids{get;set;}
		public int PosX{get;set;}
		public int PosY{get;set;}
	
		public Meubles(string matière, double hauteur, double longeur, double largeur, double poids)
		{
		Matière=matière;
		Hauteur=hauteur;
		Longeur=longeur;
		Largeur=largeur;
		Poids=poids;
		}
		public string Déplacer(int newPosX, int newPosY)
		{
			if ((newPosX==PosX) && (newPosY==PosY))
			{
				return "Le meuble reste sur sa position actuelle.";
			}
			double distA=newPosX-PosX;
			double distB=newPosY-PosY;
			double distC=Math.Round(Math.Sqrt(Math.Pow(distA, 2.0)+Math.Pow(distB,2.0)),2);
			PosX=newPosX;
			PosY=newPosY;
			return $"La nouvelle position du meuble est ({newPosX},{newPosY}). La distance de déplacement est {distC}.";
		}
		public string PasserPorte(double hauteurPorte, double largeurPorte)
		{
			if ((hauteurPorte>Hauteur+5) && (largeurPorte>Longeur+3))
			{
				return "Le meuble peut passer la porte.";
			}
			return "Le meuble ne peut pas passer la porte.";
		}
	}
	public class ChaisePliante : Meubles
	{
		public bool Plié{get;set;}
		public int Pieds{get;set;}
	
		public ChaisePliante(string matière, double hauteur, double longeur, double largeur, double poids, bool plié, int pieds) : base(matière, hauteur, longeur, largeur, poids)
		{
		Plié=plié;
		Pieds=pieds;
		}
		public void Plier()
		{
			if (Plié)
			{
				Console.WriteLine("La chaise pliante est déjà pliée.");
			}
			else
			{
				Plié=true;
			}
		}
		public void Déplier()
		{
			if (Plié)
			{
				Plié=false;
			}
			else
			{
				Console.WriteLine("La chaise pliante est déjà dépliée.");
			}
		}
	}
	public class Fauteuil : ChaisePliante
	{
		public double EpaisseurCoussin{get;set;}
		public bool? AccoudoirPlié{get;set;}
		
		public Fauteuil(string matière, double hauteur, double longeur, double largeur, double poids, bool plié, int pieds) : base(matière, hauteur, longeur, largeur, poids, plié, pieds)
		{
		}
		public void PlierAccoudoir()
		{
			if (AccoudoirPlié != null)
			{
				if (AccoudoirPlié==true)
				{
					Console.WriteLine("Les accoudoirs sont déjà pliés.");
				}
				else
				{
					AccoudoirPlié=true;
				}
			}
			else
			{
				Console.WriteLine("L'attribut 'AccoudoirPlié' n'est pas désigné.");
			}
		}
		public void DéplierAccoudoir()
		{
			if (AccoudoirPlié != null)
			{
				if (AccoudoirPlié==true)
				{
					AccoudoirPlié=false;
				}
				else
				{
					Console.WriteLine("Les accoudoirs sont déjà dépliés.");
				}
			}
			else
			{
				Console.WriteLine("L'attribut 'AccoudoirPlié' n'est pas désigné.");
			}
		}
	}
	public static void Volume(ChaisePliante x)
	{
		double vol=x.Hauteur*x.Largeur*x.Longeur;
		Console.WriteLine($"La volume est {vol}.");
	}
	public static void Main()
	{
		Meubles a=new Meubles("bois",15.0,5.0,5.0,45.0);
		a.PosX=15;
		a.PosY=-5;
		
		Console.WriteLine(a.Déplacer(20,10));
		Console.WriteLine(a.PasserPorte(8.0,2.0));
		Console.WriteLine("Position actuelle:("+a.PosX+","+a.PosY+").");
		Console.WriteLine(a.Déplacer(20,10));
		
		Console.WriteLine("================================================");
		ChaisePliante b=new ChaisePliante("métal", 8.0, 3.0, 3.0, 25.0, true, 4);
		b.Plier();
		b.Déplier();
		Console.WriteLine(b.Déplacer(10,8));
		Console.WriteLine(b.PasserPorte(15.0,8.0));
		Console.WriteLine("Etat plié actuel:"+b.Plié+". Position actuelle:("+b.PosX+","+b.PosY+").");
		
		Console.WriteLine("================================================");
		Fauteuil c=new Fauteuil("bois et cuir", 16.0, 5.0, 5.0, 40.0, false, 4);
		c.PlierAccoudoir();
		c.AccoudoirPlié=true;
		c.PlierAccoudoir();
		c.DéplierAccoudoir();
		c.DéplierAccoudoir();
		c.PosX=28;
		c.PosY=-15;
		Console.WriteLine(c.Déplacer(10,8));
		Console.WriteLine("Etat plié actuel:"+c.Plié+". Position actuelle:("+c.PosX+","+c.PosY+").");
		
		Console.WriteLine("===============================================");
		Meubles d=new ChaisePliante("plastique", 10.0, 2.5, 3.5, 35.7, false, 4); //d takes only all attrs from Meubles, but needs all parameters in ChaisePliante to pass inside ()
		Volume(d as ChaisePliante); //to use functions specific to ChaisePliante, because d is instantiated as Meubles
	}
}
using System;
					
public class Program
{
	public class Meubles
	{
		public string Matière{get;set;}
		public double Hauteur{get;set;}
		public double Longueur{get;set;}
		public double Largeur{get;set;}
		public double Poids{get;set;}
		public int PosX{get;set;}
		public int PosY{get;set;}
	
		public Meubles(string matière, double hauteur, double longueur, double largeur, double poids)
		{
		Matière=matière;
		Hauteur=hauteur;
		Longueur=longueur;
		Largeur=largeur;
		Poids=poids;
		}
		public string Déplacer(int newPosX, int newPosY)
		{
			if ((newPosX==PosX) && (newPosY==PosY))
			{
				return "Le meuble reste sur sa position actuelle.";
			}
			double distA=newPosX-PosX;
			double distB=newPosY-PosY;
			double distC=Math.Round(Math.Sqrt(Math.Pow(distA, 2.0)+Math.Pow(distB,2.0)),2);
			PosX=newPosX;
			PosY=newPosY;
			return $"La nouvelle position du meuble est ({newPosX},{newPosY}). La distance de déplacement est {distC}.";
		}
		public string PasserPorte(double hauteurPorte, double largeurPorte)
		{
			if ((hauteurPorte>Hauteur+5) && (largeurPorte>Longueur+3))
			{
				return "Le meuble peut passer la porte.";
			}
			return "Le meuble ne peut pas passer la porte.";
		}
	}
	public class ChaisePliante : Meubles
	{
		public bool Plié{get;set;}
		public int Pieds{get;set;}
	
		public ChaisePliante(string matière, double hauteur, double longueur, double largeur, double poids, bool plié, int pieds) : base(matière, hauteur, longueur, largeur, poids)
		{
		Plié=plié;
		Pieds=pieds;
		}
		public void Plier()
		{
			if (Plié)
			{
				Console.WriteLine("La chaise pliante est déjà pliée.");
			}
			else
			{
				Plié=true;
			}
		}
		public void Déplier()
		{
			if (Plié)
			{
				Plié=false;
			}
			else
			{
				Console.WriteLine("La chaise pliante est déjà dépliée.");
			}
		}
	}
	public class Fauteuil : ChaisePliante
	{
		public double EpaisseurCoussin{get;set;}
		public bool? AccoudoirPlié{get;set;}
		
		public Fauteuil(string matière, double hauteur, double longueur, double largeur, double poids, bool plié, int pieds) : base(matière, hauteur, longueur, largeur, poids, plié, pieds)
		{
		}
		public void PlierAccoudoir()
		{
			if (AccoudoirPlié != null)
			{
				if (AccoudoirPlié==true)
				{
					Console.WriteLine("Les accoudoirs sont déjà pliés.");
				}
				else
				{
					AccoudoirPlié=true;
				}
			}
			else
			{
				Console.WriteLine("La valeur de l'attribut 'AccoudoirPlié' n'est pas désignée.");
			}
		}
		public void DéplierAccoudoir()
		{
			if (AccoudoirPlié != null)
			{
				if (AccoudoirPlié==true)
				{
					AccoudoirPlié=false;
				}
				else
				{
					Console.WriteLine("Les accoudoirs sont déjà dépliés.");
				}
			}
			else
			{
				Console.WriteLine("La valeur de l'attribut 'AccoudoirPlié' n'est pas désignée.");
			}
		}
	}
	public class Canapé : Fauteuil
	{
		public int NbSièges{get;set;}
		public int NbAssis=0;
		
		public Canapé(string matière, double hauteur, double longueur, double largeur, double poids, bool plié, int pieds, int nbSièges) : base(matière, hauteur, longueur, largeur, poids, plié, pieds)
		{
			NbSièges=nbSièges;
		}
		public bool Asseoir(int personne)
		{
			bool success=false;
			if (personne<=NbSièges-NbAssis)
			{
				success=true;
				NbAssis=personne+NbAssis;
				return success;
			}
			return success;
		}
		public bool Lever(int personne)
		{
			bool success=false;
			if (personne<=NbAssis)
			{
				success=true;
				NbAssis=NbAssis-personne;
				return success;
			}
			return success;
		}
		public string AsseoirLever(int perAsseoir, int perLever)
		{
			/*int veutAsseoir=perAsseoir-perLever;
			if (veutAsseoir>=0)
			{
				int reste=NbSièges-NbAssis;
				if (veutAsseoir<=reste)
				{
					NbAssis=NbAssis+veutAsseoir;
					return $"Nombre de personnes assises est {NbAssis}.";
				}
			int levé=veutAsseoir-reste;
			NbAssis=NbSièges;
			return $"Nombre de personnes assises est {NbAssis} et {levé} de personne(s) reste(nt) levée(s).";
			}
			else if (veutAsseoir>=NbAssis*-1)
			{
				NbAssis=NbAssis+veutAsseoir;
				return $"Nombre de personnes assises est {NbAssis}.";
			}
			return "Erreur: Il y a plus de personne qui veut se lever que les personnes assises!";*/
			int reste=NbAssis-perLever;   // Out first, In later
			if (reste>=0) 
			{
				int assis=reste+perAsseoir;
				if (assis<=NbSièges)
				{
					NbAssis=assis;
					return $"Nombre de personnes assises est {NbAssis}.";
				}
				int levé1=assis-NbSièges;
				NbAssis=NbSièges;
				return $"Maximum de places assises atteinte. Nombre de personnes assises est {NbAssis} et {levé1} de personne(s) reste(nt) levée(s).";
			}
			NbAssis=0;
			if (perAsseoir<=NbSièges)
			{
				NbAssis=perAsseoir;
				return $"Nombre de personnes assises est {NbAssis}.";	
			}
			int levé2=perAsseoir-NbSièges;
			NbAssis=NbSièges;
			return $"Maximum de places assises atteinte. Nombre de personnes assises est {NbAssis} et {levé2} de personne(s) reste(nt) levée(s).";
		}			
	}		
	public static void Volume(ChaisePliante x)
	{
		double vol=x.Hauteur*x.Largeur*x.Longueur;
		Console.WriteLine($"Le volume est {vol}.");
	}
	public static void Main()
	{
		Meubles a=new Meubles("bois",15.0,5.0,5.0,45.0);
		a.PosX=15;
		a.PosY=-5;
		
		Console.WriteLine(a.Déplacer(20,10));
		Console.WriteLine(a.PasserPorte(8.0,2.0));
		Console.WriteLine("Position actuelle:("+a.PosX+","+a.PosY+").");
		Console.WriteLine(a.Déplacer(20,10));
		
		Console.WriteLine("================================================");
		ChaisePliante b=new ChaisePliante("métal", 8.0, 3.0, 3.0, 25.0, true, 4);
		b.Plier();
		b.Déplier();
		Console.WriteLine(b.Déplacer(10,8));
		Console.WriteLine(b.PasserPorte(15.0,8.0));
		Console.WriteLine("Etat plié actuel:"+b.Plié+". Position actuelle:("+b.PosX+","+b.PosY+").");
		
		Console.WriteLine("================================================");
		Fauteuil c=new Fauteuil("bois et cuir", 16.0, 5.0, 5.0, 40.0, false, 4);
		c.PlierAccoudoir();
		c.AccoudoirPlié=true;
		c.PlierAccoudoir();
		c.DéplierAccoudoir();
		c.DéplierAccoudoir();
		c.PosX=28;
		c.PosY=-15;
		Console.WriteLine(c.Déplacer(10,8));
		Console.WriteLine("Etat plié actuel:"+c.Plié+". Position actuelle:("+c.PosX+","+c.PosY+").");
		
		Console.WriteLine("===============================================");
		Meubles d=new ChaisePliante("plastique", 10.0, 2.5, 3.5, 35.7, false, 4); //d takes only all attrs from Meubles, but needs all parameters in ChaisePliante to pass inside ()
		Volume(d as ChaisePliante); //to use functions specific to ChaisePliante, because d is instantiated as Meubles
		
		Console.WriteLine("===============================================");
		Canapé e=new Canapé("cuir", 25.0, 100.0, 50.0, 80.5, false, 6, 5);
		Console.WriteLine(e.Asseoir(8));
		Console.WriteLine(e.Lever(5));
		Console.WriteLine(e.Lever(5));
		Console.WriteLine(e.Asseoir(4));	
		Console.WriteLine(e.Asseoir(1));
		Console.WriteLine(e.Asseoir(8));
		
		Console.WriteLine("===============================================");
		Canapé f=new Canapé("cuir", 25.0, 100.0, 50.0, 80.5, false, 6, 5);		
		Console.WriteLine(f.NbAssis);
		Console.WriteLine(f.AsseoirLever(3,8));
		Console.WriteLine(f.AsseoirLever(0,8));
	}
}
using System;
					
public class Program
{
	public static void Main()
	{
		int[] a=new int[8];    //1-D array must have size
		a[0]=1;
		for (int i=0;i<a.Length;i++)
		{
			a[i]=i;
		}
		foreach (int j in a)
		{
			Console.Write(j+" ");
		}
		Console.WriteLine();
		int[] c=new int[8];
		int[] d=new int[8];
		int[][] b=new int[3][]; //2-D array needs only one input size
		
		b[0]=a;
		b[1]=c;
		b[2]=d;
		Console.WriteLine(b[0][1]);

		for (int i=0;i<c.Length;i++)
		{
			c[i]=10-i;
		}
		Console.WriteLine(c.GetValue(0)); //SetValue & GetValue can only access value at certain coordinate(s). eg. if only 1-D, then only one parameter will be accepted, vice-versa.
	}
}
using System;
					
public class Program
{
	public static void Main()
	{
		string numString="123;1235;465;654;973;56787;565";
		string[] nums=numString.Split(';');
		
		int counter=0;
		int sum=0;
		while (counter<nums.Length)
		{
			int num=Convert.ToInt32(nums[counter]);
			sum=sum+num;
			counter++;
		}
		Console.WriteLine(sum);
	}
}
using System;
using NumSharp;
					
public class Program
{
	public static void Main()
	{
		char[] arrA=new char[]{'r','e','t','y'};
		char[] arrB=new char[]{'c','v','b','g','z'};
		char[] arrC=new char[]{'a','c','f','j','y','e'};
		char[] arrD=new char[]{'z','k'};
		
		char[][] arrJagged=new char[4][]{arrA, arrB, arrC, arrD}; //can pass variable directly
		
		for (int i=0;i<arrJagged.Length;i++)
		{
			for (int j=0; j<arrJagged[i].Length;j++)
			{
				Console.Write(arrJagged[i][j]+" ");
			}
			Console.WriteLine();
		}
		Console.WriteLine("===================================");
		var matrixA=np.zeros(2,3);
		Console.WriteLine(matrixA.ToString());
		Console.WriteLine("===================================");
		NDArray a=new double[,]{{1,2,3},{4,5,6}};
		NDArray b=new double[,]{{4,2},{1,5},{5,6}};
		Console.WriteLine(a.dot(b).ToString());		
	}
}