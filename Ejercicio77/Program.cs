
using System.Collections;

class Ejercicio77
{
    static void Main()
    {
        SortedList<string,string> diccio = new SortedList<string,string>();
        diccio.Add("Hello", "Hola");
        diccio["see you later"] = "hasta luego";

        Console.WriteLine(diccio["Hola"]);

        if (diccio.ContainsKey("Adios"))
            Console.WriteLine(diccio["Bye"]);
    }
}
