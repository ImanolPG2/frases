using System;

class Program
{
    static void Main()
    {

        Console.Write("Por favor, ingresa una frase: ");
        string frase = Console.ReadLine();

        if (string.IsNullOrEmpty(frase))
        {
            Console.WriteLine("La frase está vacía.");
        }
        else
        {

            int longitud = frase.Length;
            Console.WriteLine($"La longitud de la frase es: {longitud}");

            char primerCaracter = frase[0];
            char ultimoCaracter = frase[longitud - 1];
            Console.WriteLine($"El primer carácter es: '{primerCaracter}'");
            Console.WriteLine($"El último carácter es: '{ultimoCaracter}'");


            string fraseConComas = string.Join(",", frase.Split(' '));
            Console.WriteLine($"Frase con palabras separadas por comas: {fraseConComas}");
        }
    }
}


class Program
{
    static void Main()
    {

        Console.Write("Por favor, ingresa la primera frase: ");
        string frase1 = Console.ReadLine();


        Console.Write("Por favor, ingresa la segunda frase: ");
        string frase2 = Console.ReadLine();


        if (frase1 == frase2)
        {
            Console.WriteLine("Ambas frases son iguales.");
        }
        else
        {
            Console.WriteLine("Las frases son diferentes.");
        }
    }
}




class Program
{
    static void Main()
    {

        Console.Write("Por favor, ingresa una frase: ");
        string frase = Console.ReadLine();


        Console.Write("Por favor, ingresa una palabra a buscar en la frase: ");
        string palabra = Console.ReadLine();


        int posicion = frase.IndexOf(palabra);
        if (posicion != -1)
        {
            Console.WriteLine($"La palabra '{palabra}' se encuentra en la frase en la posición: {posicion}");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no se encuentra en la frase.");
        }

        int contador = 0;
        int inicioBusqueda = 0;
        while ((inicioBusqueda = frase.IndexOf(palabra, inicioBusqueda)) != -1)
        {
            contador++;
            inicioBusqueda += palabra.Length;
        }
        Console.WriteLine($"La palabra '{palabra}' aparece {contador} veces en la frase.");

        string palabraMayusculas = palabra.ToUpper();
        string palabraMinusculas = palabra.ToLower();
        Console.WriteLine($"La palabra en mayúsculas es: {palabraMayusculas}");
        Console.WriteLine($"La palabra en minúsculas es: {palabraMinusculas}");
    }
}
