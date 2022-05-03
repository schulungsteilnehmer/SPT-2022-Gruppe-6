/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 03.05.2022
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zeugnisapp
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			// TODO: Implement Functionality Here
			
			string Leistungskurs1;
			string Leistungskurs2;
			string Datum;
			string Name; 
			string Klasse; 
			string Grundkurs1;
			string Grundkurs2;
			string Grundkurs3;
			string Grundkurs4;
			string Grundkurs5;
			string Grundkurs6;
			int PunkteLk1;
			int PunkteLk2;
			int PunkteG1;
			int PunkteG2;
			int PunkteG3;
			int PunkteG4;
			int PunkteG5;
			int PunkteG6;
			double [] Note = new double[10];
			double Endnote;
			Endnote = 0;
				
			
			Console.Write("Name(Vor- und Nachname): ");
			Name = Console.ReadLine();
			
			Console.Write("Datum: ");
			Datum = Console.ReadLine();
			
			Console.Write("Klasse: ");
			Klasse = Console.ReadLine();
			
			
			Console.Write("Leistungskurs1: ");
			Leistungskurs1 = Console.ReadLine();
			Console.Write("PunkteLK1(0-15Punkte): ");
			PunkteLk1 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Leistungskurs2: ");
			Leistungskurs2 = Console.ReadLine();
			Console.Write("PunkteLK2(0-15Punkte): ");
			PunkteLk2 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Grundkurs1: ");
			Grundkurs1 = Console.ReadLine();
			Console.Write("Punkte G1(0-15Punkte): ");
			PunkteG1 = Convert.ToInt32(Console.ReadLine());
			
			
			
			Console.Write("Grundkurs2: ");
			Grundkurs2 = Console.ReadLine();
			Console.Write("Punkte G2(0-15Punkte): ");
			PunkteG2 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Grundkurs3: ");
			Grundkurs3 = Console.ReadLine();
			Console.Write("Punkte G3(0-15Punkte): ");
			PunkteG3 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Grundkurs4: ");
			Grundkurs4 = Console.ReadLine();
			Console.Write("Punkte G4(0-15Punkte): ");
			PunkteG4 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Grundkurs5: ");
			Grundkurs5 = Console.ReadLine();
			Console.Write("Punkte G5(0-15Punkte): ");
			PunkteG5 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Grundkurs6: ");
			Grundkurs6 = Console.ReadLine();
			Console.Write("Punkte G6(0-15Punkte): ");
			PunkteG6 = Convert.ToInt32(Console.ReadLine());
			
		
			
			
			Note[0] = ((17 - PunkteLk1) / 3);
			Note[1] = ((17 - PunkteLk1) / 3);
			
			Note[2] = ((17 - PunkteLk2) / 3);
			Note[3] = ((17 - PunkteLk2) / 3);
			
			Note[4] = ((17 - PunkteG1) / 3);
			Note[5] = ((17 - PunkteG2) / 3);
			
			Note[6] = ((17 - PunkteG3) / 3);
			Note[7] = ((17 - PunkteG4) / 3);
			
			Note[8] = ((17 - PunkteG5) / 3);
			Note[9] = ((17 - PunkteG6) / 3);
			
			for (int i = 0; i <= 9; i++) {
				Endnote += Note[i]; 
				
				
			}
			Endnote = Endnote / 10;
		    Console.Write(Endnote);
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
			
		}
	}
}