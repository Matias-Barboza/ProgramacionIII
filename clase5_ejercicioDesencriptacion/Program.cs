using System;

internal class Program
{
    private static void Main(string[] args)
    {
        String mensaje = "kd wiqd géuúi tédbbúnq kdq wiqd iúígédíqsybyuqu", mensaje1;
        int clave;


        Console.WriteLine("Ingrese el mensaje a desencriptar: ");
        mensaje1 = Console.ReadLine();
        Console.WriteLine("Ingrese la clave de cifrado: ");
        int.TryParse(Console.ReadLine(), out clave);

        while(clave == 0) 
        {
            Console.WriteLine("La clave es invalida");
            Console.WriteLine("Ingrese la clave de cifrado: ");
            int.TryParse(Console.ReadLine(), out clave);
        }

        Console.WriteLine("\nMensaje original:");
        Console.WriteLine(mensaje1);
        Console.WriteLine("\nMensaje descrifrado:");
        Console.WriteLine(desencriptarMensaje(mensaje1, clave));
    }

    public static string desencriptarMensaje(String mensaje, int clave) 
    {
        String mensajeDesencriptado = "";
        int i = 0, posicion = -1;
        char caracterAux;

        foreach(char caracter in mensaje) 
        {
            if (caracter != ' ')
            {
                if (estaDentroDelAlfabeto(caracter, out posicion))
                {
                    caracterAux = conversion(caracter, posicion, clave);
                    mensajeDesencriptado += caracterAux;
                }
            }
            else
            {
                mensajeDesencriptado += " ";
            }
        }

        return mensajeDesencriptado;
    }

    public static bool estaDentroDelAlfabeto(char caracterMensaje, out int posicion) 
    {
        String alphabet = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";
        posicion = -1;

        foreach (char caracterAlphabet in alphabet) 
        {
            if (caracterMensaje == caracterAlphabet)
            {
                posicion = alphabet.IndexOf(caracterMensaje);
                return true;
            }
        }

        return false;
    }

    public static char conversion(char caracter, int posicion, int clave) 
    {
        String alphabet = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";
        posicion += 1;

        for(int i = 1; i <= clave; i++) 
        {
            if (posicion < 33)
            {
                caracter = alphabet[posicion];
                posicion++;
            }
            else
            {
                posicion = 0;
                caracter = alphabet[posicion];
                posicion++;
            }
        }

        return caracter;
    }
}   