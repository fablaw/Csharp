using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
  class Program
  {
    class Usager
    {
      public string Id{get;set;}
      public string Nom{get;set;}
      public string Prénom{get;set;}
      public string NumSécu{get;set;}
      public int NumTel{get;set;}

      public Usager(string id, string nom, string prénom, string numSécu, int numTel)
      {
        Id=id;
        Nom=nom;
        Prénom=prénom;
        NumSécu=numSécu;
        NumTel=numTel;
      }
      public void AfficherId()
      {
        Console.WriteLine("Id: {0};\nNom: {1};\nPrénom: {2};\nNuméro Sécu: {3};\nNuméro Tél: {4}",Id, Nom, Prénom, NumSécu, NumTel);
      }
    }
    class Véhicule
    {
      public string Id{get;set;}
      public int PosX{get;set;}
      public int PosY{get;set;}

      public Véhicule(string id)
      {
        Id=id;
      }
      public string GetID()
      {
        return Id;
      }
      public void Déplacer(int newX, int newY)
      {
        if ((newX==PosX) && (newY==PosY))
			  {
				  Console.WriteLine("Le véhicule reste sur sa position actuelle.");
			  }
			  double distA=newX-PosX;
			  double distB=newY-PosY;
			  double distC=Math.Round(Math.Sqrt(Math.Pow(distA, 2.0)+Math.Pow(distB,2.0)),2);
			  PosX=newX;
			  PosY=newY;
			  Console.WriteLine($"La nouvelle position du meuble est ({PosX},{PosY}). La distance de déplacement est {distC}.");
      }
    }
    class Voiture : Véhicule
    {
      public string Marque{get;set;}
      public string Modèle{get;set;}
      public int NbPlaces{get;set;}
      public List<Usager> PersonnesInstallées{get;set;}
      public List<Usager> ListeAttente{get;set;}

      public Voiture(string id, string marque, string modèle, int nbPlaces, List<Usager> personnesInstallées) : base(id)
      {
        Marque=marque;
        Modèle=modèle;
        NbPlaces=nbPlaces;
        PersonnesInstallées=personnesInstallées;
      }
      public void InstallerIndividu(List<Usager> perAinstaller)
      {
        if (ListeAttente.Count==0)
        {
          foreach (var per in perAinstaller)
          {
            int counterAdd=0;
            if (!PersonnesInstallées.Contains(per))
            {
              if (PersonnesInstallées.Count<NbPlaces)
              {
                PersonnesInstallées.Add(per);
                counterAdd=counterAdd+1;
              }
              else
              {
                ListeAttente.Add(per);
                Console.WriteLine($"Il n'y a pas assez de place. {per.Prénom} {per.Nom} sera dans la liste d'attente.");
              }
            }
            else
            {
              Console.WriteLine($"{per.Prénom} {per.Nom} est déjà installé dans cette voiture.");
            }
            Console.WriteLine($"{counterAdd} sur {perAinstaller.Count} a(sont) été installée(s).");
          }
        }
        else
        {
          foreach (var pers in ListeAttente)
          {
            if (perAinstaller.Contains(pers))
            {
              if (PersonnesInstallées.Count<NbPlaces)
              {
                PersonnesInstallées.Add(pers);
                ListeAttente.Remove(pers);
                perAinstaller.Remove(pers);
              }
            }
            else
            {
              if (PersonnesInstallées.Count<NbPlaces)
              {
                PersonnesInstallées.Add(pers);
                ListeAttente.Remove(pers);
              }
            }
          }
          foreach (var exPer in perAinstaller.Except(ListeAttente))
          {
            ListeAttente.Add(exPer);
          }
          Console.WriteLine($"Il reste {ListeAttente.Count} de personnes dans la liste d'attente.");
        }
      }
      public void SortirIndividu(List<Usager> perAsortir)
      {
        foreach (var person in perAsortir)
        {
          if (PersonnesInstallées.Contains(person))
          {
            PersonnesInstallées.Remove(person);
          }
          else
          {
            Console.WriteLine($"{person.Prénom} {person.Nom} n'est pas installé dans cette voiture.");
          }
        }
      }
    }
    class AvionCargo : Véhicule
    {
      public string Modèle{get;set;}
      public int NbRéacteurs{get;set;}
      public double CargoMax{get;set;}
      public Usager Pilote{get;set;}
      public double CargoInstallé{get;set;}

      public AvionCargo(string id, string modèle, int nbRéacteurs, double cargoMax, Usager pilote, double cargoInstallé): base(id)
      {
        Modèle=modèle;
        NbRéacteurs=nbRéacteurs;
        CargoMax=cargoMax;
        Pilote=pilote;
        CargoInstallé=cargoInstallé;
      }
      public void ChargerCargo(double poidsIn)
      {
        if (CargoInstallé+poidsIn<=CargoMax)
        {
          CargoInstallé=CargoInstallé+poidsIn;
        }
        else
        {
          Console.WriteLine("Le poids à charger dépasse la maximum capacité.");
        }
      }
      public void DéchargerCargo(double poidsOut)
      {
        if (poidsOut<=CargoInstallé)
        {
          CargoInstallé=CargoInstallé-poidsOut;
        }
        else
        {
          Console.WriteLine("Il y a plus de poids à enlever que le poids déjà installé.");
        }
      }
    }
    static void Main(string[] args)
    {
      Usager userA=new Usager("S001", "Morain", "Jean", "33 88 99", 65743);
      Usager userB=new Usager("S002", "Morain", "Jeanne", "34 78 29", 62743);
      Usager userC=new Usager("S003", "Moraino", "Jim", "31 88 69", 65721);
      Usager userD=new Usager("S004", "de Morain", "Alice", "23 88 49", 66143);
      Usager userE=new Usager("S005", "de Morain", "Jean", "23 88 99", 65023);
      Usager userF=new Usager("S006", "de Moralle", "Jain", "23 78 99", 61023);
      Usager userG=new Usager("S007", "Dubois", "Ben", "23 88 19", 65022);
      Véhicule vh1=new Véhicule("VH001");
      Véhicule vh2=new Véhicule("VH002");
      vh1.PosX=15;
      vh1.PosY=5;
      vh2.PosX=20;
      vh2.PosY=7;
      var listPassager1=new List<Usager>{userA, userB, userC};
      var listPassager2=new List<Usager>{userB, userE, userF};
      var listPassager3=new List<Usager>{userA, userB};
      var listPassager4=new List<Usager>{userD, userE, userG, userA, userC};
      Voiture vt1=new Voiture("VT001", "Ford", "ST", 4, listPassager1);
      Voiture vt2=new Voiture("VT002", "Peugeot", "308", 5, listPassager2);
      vt1.SortirIndividu(listPassager2);
      AvionCargo ac1=new AvionCargo("AC001", "Boeing", 4, 500.0, userA, 200.0);
      AvionCargo ac2=new AvionCargo("AC002", "Airbus", 5, 750.0, userB, 0.0);
      AvionCargo ac3=new AvionCargo("AC003", "Boeing", 3, 450.0, userC, 50.0);
      ac1.ChargerCargo(400.0);
      ac2.ChargerCargo(300.0);
      ac2.DéchargerCargo(400.0);
      vt2.InstallerIndividu(listPassager4);

      Console.WriteLine("=================================");
      var listVoiture= new List<Voiture>{vt1, vt2};
      var listAvionCargo= new List<AvionCargo>{ac1, ac2, ac3};

      string racine="/Users/fabianlaw/code/C#/Csharp/eval_transport";
      string racineAvion=racine+"/Avion";
      string racineVoiture=racine+"/Voiture";

      foreach (var item in listVoiture)
      {
        if (!Directory.Exists(racineVoiture+$"/{item.NbPlaces}"))
        {
          Directory.CreateDirectory(racineVoiture+$"/{item.NbPlaces}");
        }

        if (!Directory.Exists(racineVoiture+$"/{item.NbPlaces}/{item.Marque}"))
        {
          Directory.CreateDirectory(racineVoiture+$"/{item.NbPlaces}/{item.Marque}");
        }

        if (!Directory.Exists(racineVoiture+$"/{item.NbPlaces}/{item.Marque}/{item.Modèle}"))
        {
          Directory.CreateDirectory(racineVoiture+$"/{item.NbPlaces}/{item.Marque}/{item.Modèle}");
        }

        string finalDk=racineVoiture+$"/{item.NbPlaces}/{item.Marque}/{item.Modèle}";
        foreach (var itemPerson in item.PersonnesInstallées)
        {
          File.Create(finalDk+$"/{itemPerson.Nom}_{itemPerson.Prénom}_{itemPerson.Id}.txt");
        }
      }
      foreach (var obj in listAvionCargo)
      {
        if (!Directory.Exists(racineAvion+$"/{obj.NbRéacteurs}"))
        {
          Directory.CreateDirectory(racineAvion+$"/{obj.NbRéacteurs}");
        }

        if (!Directory.Exists(racineAvion+$"/{obj.NbRéacteurs}/{obj.Modèle}"))
        {
          Directory.CreateDirectory(racineAvion+$"/{obj.NbRéacteurs}/{obj.Modèle}");
        }

        string finalDir=racineAvion+$"/{obj.NbRéacteurs}/{obj.Modèle}";
        File.Create(finalDir+$"/{obj.Pilote.Nom}_{obj.Pilote.Prénom}_{obj.Pilote.Id}.txt");

      }
    }
  }
}
