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
