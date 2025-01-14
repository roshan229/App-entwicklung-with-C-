/*Framwork opensource 
    applikaiton entwicklung
*/
using System;

class Program
{
    static void Main(string[] args)
    {

        static void Greet( ) {
            Console.WriteLine("Good morning");
        }
        int zahl = 42;
        /*                                        // ganze Zahl
        double pi = 3.14159;                                  // Gleitkommazahl
        string nachricht = "Hallo, Welt!";                    // Zeichenkette
        bool istWahr = true;                                  // boolesch

        Console.WriteLine($"Zahl: {zahl}");
        Console.WriteLine($"Pi: {pi}");
        Console.WriteLine($"Nachricht: {nachricht}");
        Console.WriteLine($"Ist Wahr: {istWahr}");*/

        Console.WriteLine("Hello World");
        Console.WriteLine("Zahl: "+zahl +"\n");

  
    /*string imp = Console.ReadLine(); //takes the inpute
    Console.WriteLine(imp);*/

       float a=34.4F;  //F lekhna imp xa else double use garnu parxa

       //string to int conversion

       string num="2";
       Console.WriteLine("Numer with additoin  5  is "+ (Convert.ToInt32(num)+5));

       /*
        /" for anführungszeichen
       */

       Greet();

    Player tommy =new Player();
    Console.WriteLine(tommy.health);
    tommy.health=1000;  //to set the new health
    Console.WriteLine(tommy.health);

    }
}
