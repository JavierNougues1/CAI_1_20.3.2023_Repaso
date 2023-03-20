// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

/********************************************************************************************************************************************************************* 
                                 Ejercicio I
**********************************************************************************************************************************************************************
Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del propio número de registro (en caso de ser comenzar con 0, 
sumarle 100), todos los números deben mostrarse por pantalla y, con los múltiplos de 3 se debera agregar “Foo”, con los múltiplos de 5, “Bar”,
y, por último, con los múltiplos de ambos, “FooBar”.
Por ejemplo, con el número mostrará “15 – FooBar”.
*/
/*
Console.WriteLine("Ingrese su número de su registro:");
int numeroRegistro = int.Parse(Console.ReadLine());
string nro = numeroRegistro.ToString();
nro = nro.Substring(0, 3);

for (int i = 0; i < numeroRegistro; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + "-" + "FooBar");
    }
    else
    {
        if (i % 5 == 0)
        {
            Console.WriteLine(i + "-" + "Bar");
        }
        if (i % 3 == 0)
        {
            Console.WriteLine(i + "-" + "Foo");
        }
    }
    if (i % 3 != 0 && i % 5 != 0)
    {
        Console.WriteLine(i);
    }
}
*/


/********************************************************************************************************************************************************************
                            Ejercicio II
********************************************************************************************************************************************************************
Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del
propio número de registro (en caso de ser comenzar con 0, sumarle 100) e identificar
los múltiplos de 3 y, también, aquellos que sean números primos. Para ambos casos
(múltiplo de 3 y primos), deben mostrar el número en cuestión y " Es divisible por 3",
"Es primo" y, en caso de ser ambos “Es primo y divisible por 3”.
Por ejemplo, con el primer número mostrará “1 – Es primo”.
*/
/*
Console.WriteLine("Ingrese su número de su registro:");
int numeroRegistro2 = int.Parse(Console.ReadLine());
string nro2 = numeroRegistro2.ToString();
nro = nro2.Substring(0, 3);

for (int i = 0; i < numeroRegistro2; i++)
{
    if (i % 3 == 0 && i % 2 == 0)
    {
        Console.WriteLine(i + "- Es primo y es divisible por 3.");
    }
    else
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i + "- Es primo.");
        }
        if (i % 3 == 0)
        {
            Console.WriteLine(i + "- Es divisible por 3.");
        }
    }
}
/*


/********************************************************************************************************************************************************************
                            Ejercicio III
********************************************************************************************************************************************************************
Crear una aplicación que indique, cuando el usuario ingresa una palabra, si ésta es un palíndromo.
Nota: Palíndromo son palabras que al derecho y al revés se leen igual, como "ananá".
*/
Console.WriteLine("Introduzca una palabra:");
string palabra = Console.ReadLine();
string inversa =  new string(palabra.ToCharArray().Reverse().ToArray());

if (palabra.Equals(inversa))
{
    Console.WriteLine(palabra + " - Es una palabra palíndromo ya que al revés se lee: " +  inversa);
}


/********************************************************************************************************************************************************************
                            Ejercicio V
********************************************************************************************************************************************************************
Crear una aplicación que, cuando el usuario ingresa un número de 5 cifras, lo invierta y muestre por pantalla “El número invertido es: *nnnnn*”. 
Por ejemplo, si el usuario ingresa “12345”, mostrará por pantalla “54321”.
*/
Console.WriteLine("Introduzca un número:");
string numero = Console.ReadLine();
string inversa2 = new string(numero.ToCharArray().Reverse().ToArray());
Console.WriteLine("Número ingresado: " + numero + " -> Número a la inversa: " + inversa2);