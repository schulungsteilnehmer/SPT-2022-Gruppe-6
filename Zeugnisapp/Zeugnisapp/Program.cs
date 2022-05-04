/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 03.05.2022
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
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
			int Fehltage;
			int entschuldigteFehltage;
			int  unentschuldigteFehltage;
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
			int Counter = 0;
			string Txt;
			double [] Note = new double[10];
			double Endnote;
			unentschuldigteFehltage = 0;
			Endnote = 0;
				
			
			
			
			
			Console.Write("Name(Vor- und Nachname): ");
			Name = Console.ReadLine();
			
			Console.Write("Datum (dd.mm.yyyy): ");
			Datum = Console.ReadLine();
			
			Console.Write("Klasse: ");
			Klasse = Console.ReadLine();
			
			Console.Write("Fehltage: ");
			Fehltage = Convert.ToInt32(Console.ReadLine());
			
			
			Console.Write("Davon entschuldigt: ");
			entschuldigteFehltage = Convert.ToInt32(Console.ReadLine());
			
			
			
			
			
			
			
			Console.Write("\nLeistungskurs1: ");
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
			
		
			
			
			Note[0] = ((17 - (double)PunkteLk1) / 3);
			Note[8] = ((17 - (double)PunkteLk1) / 3);
			
			Note[1] = ((17 - (double)PunkteLk2) / 3);
			Note[9] = ((17 - (double)PunkteLk2) / 3);
			
			Note[2] = ((17 - (double)PunkteG1) / 3);
			Note[3] = ((17 - (double)PunkteG2) / 3);
			
			Note[4] = ((17 - (double)PunkteG3) / 3);
			Note[5] = ((17 - (double)PunkteG4) / 3);
			
			Note[6] = ((17 - (double)PunkteG5) / 3);
			Note[7] = ((17 - (double)PunkteG6) / 3);
			
			for (int i = 0; i <= 9; i++) {
				Endnote += Note[i]; 
				
				
			}
			
			Endnote = Endnote / 10;
		    Console.Write(Endnote);
		    
		    
		    unentschuldigteFehltage = Fehltage - entschuldigteFehltage; 
		    
			
		    Console.Write("\nUnentschuldigte Fehltage: {0}",unentschuldigteFehltage);
		    
		    Console.Clear();
		    Console.Write("=========Zeugnis========");
		    Console.WriteLine("\nName: {0} \nDatum: {1} \nKlasse: {2} \n========================\n", Name, Datum, Klasse);
		    Console.WriteLine(" {0}(Leistungskurs 1): {1:F1} ", Leistungskurs1, Note[0]);
		    Console.WriteLine(" {0}(Leistungskurs 2): {1:F1} ", Leistungskurs2, Note[2]);
		    Console.WriteLine(" {0}: {1:F1} ", Grundkurs1, Note[4]);
		    Console.WriteLine(" {0}: {1:F1} ", Grundkurs2, Note[5]);
		    Console.WriteLine(" {0}: {1:F1} ", Grundkurs3, Note[6]);
		    Console.WriteLine(" {0}: {1:F1} ", Grundkurs4, Note[7]);
		    Console.WriteLine(" {0}: {1:F1} ", Grundkurs5, Note[8]);
		    Console.WriteLine(" {0}: {1:F1} ", Grundkurs6, Note[9]);
		    Console.WriteLine("Fehltage: {0} ", Fehltage);
		    Console.WriteLine("unentschuldigte Fehltage: {0}: entschuldigte Fehltage {1} ", unentschuldigteFehltage, entschuldigteFehltage);
		    Console.WriteLine("Durchschnitt: {0:F1} ", Endnote);
		    
			
		    
		    for (int i = 0; i <= 7 ; i++){
				double Notenpunkte = 17 - (3*Note[i]);
				if (Notenpunkte<5) {
					Counter++;
				
				}  
				
				
			}		   




		    if(unentschuldigteFehltage > 29 || Counter > 2)
		    {
		    	
		    Console.Write(" \nDer Schüler wird nicht versetzt");
			
		    }
			else 
			
			{
				Console.Write(" \nDer Schüler wird versetzt");
			}
			
			
			Console.ReadKey(true);
		    Console.Clear();
		    Console.WriteLine("Wollen Sie eine Textdatei empfangen? (Ja oder Nein):");
		    Txt = Console.ReadLine();
		    if (Txt == "Ja" || Txt == "ja"){
		    	string fileName = @"C:\Users\schulung.SCHULUNGNB-03\Documents\Zeugnissoftware\Zeugnis.txt";
			StreamWriter writer = new StreamWriter(fileName); 
			
			writer.Write("=========Zeugnis========");
		    writer.WriteLine("\nName: {0} \nDatum: {1} \nKlasse: {2} \n========================\n ", Name, Datum, Klasse);
		    writer.WriteLine(" {0}(Leistungskurs 1): {1:F1} ", Leistungskurs1, Note[0]);
		    writer.WriteLine(" {0}(Leistungskurs 2): {1:F1} ", Leistungskurs2, Note[2]);
		    writer.WriteLine(" {0}: {1:F1} ", Grundkurs1, Note[4]);
		    writer.WriteLine(" {0}: {1:F1} ", Grundkurs2, Note[5]);
		    writer.WriteLine(" {0}: {1:F1} ", Grundkurs3, Note[6]);
		    writer.WriteLine(" {0}: {1:F1} ", Grundkurs4, Note[7]);
		    writer.WriteLine(" {0}: {1:F1} ", Grundkurs5, Note[8]);
		    writer.WriteLine(" {0}: {1:F1} ", Grundkurs6, Note[9]);
		    writer.WriteLine("Fehltage: {0} ", Fehltage);
		    writer.WriteLine("unentschuldigte Fehltage: {0}: entschuldigte Fehltage {1} ", unentschuldigteFehltage, entschuldigteFehltage);
		    writer.WriteLine("Durchschnitt: {0:F1} ", Endnote);
		    
		    if(unentschuldigteFehltage > 29 || Counter > 2)
		    {
		    	
		    writer.Write(" \nDer Schüler wird nicht versetzt");
			
		    }
			else 
			
			{
				writer.Write(" \nDer Schüler wird versetzt");
			}
			
			writer.Close();
		    }
		    
			
			
			
			
			
		    
		    
		    
		    
		    
		    	
		    	
		    
	
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
			
		}
	}
}