using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Pirma užduotis, spauskit \"Enter\" startui");
            ReadLine();
            WriteLine("Sveiki, koks yra šio popiežiaus vardas");
            string vard = ReadLine();
            WriteLine("Gaila, bet neatsimenu, kurią mėnesio dieną atvyko popiežius, įveskit prašau dieną");
            string diena = ReadLine();
            WriteLine("{0} {1}",PirmaUzduotis.Vardas(vard), PirmaUzduotis.Diena(diena));
            ReadKey();
            WriteLine("Pradedam antrą užduotį. Įveskite pirmąjį skaičių");
            string skaicius1 = ReadLine();
            WriteLine("Įveskite antrąjį skaičių");
            string skaicius2 = ReadLine();

            WriteLine("Įvyko magija, žiūrėk ką padariau \n{0} {1}", skaicius2, skaicius1);
            ReadLine();

            WriteLine("Trečia užduotis: įveskite temperatūrą laipsniais, o aš pasikviesiu Farenheitą ir Kelviną");
            string line = ReadLine();
            int laipsniai;
            Int32.TryParse(line, out laipsniai);
            WriteLine("Ponas Farenheitas sako, kad duotieji Celsijaus laipsniai atitinka {0}, o Kelvinas atsako – {1}", TreciaUzduotis.Fahrenheit(laipsniai), TreciaUzduotis.Kelvin(laipsniai));
            ReadLine();
        }
    }
    class PirmaUzduotis
    {
        public static string Vardas(string a)
        {
            string b = "Pagal Jus popiežiaus vardas yra" + a;
            return b;
        }

        public static string Diena(string a)
        {
            string b = "ir jis buvo atvykęs 2018-09-" + a;
            return b;

        }
    }

    class TreciaUzduotis 
    {
        public static double Fahrenheit(int a)
        {
            double convertTofahrenheit = (a * 1.8 + 32);
            return convertTofahrenheit;
        }
        
        public static double Kelvin (int a)
        {
            double convertToKelvin = a + 273.15;
            return convertToKelvin;
        }
    }
}
