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
