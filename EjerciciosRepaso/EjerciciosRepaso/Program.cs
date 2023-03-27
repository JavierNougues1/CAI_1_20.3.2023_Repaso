// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

//Opción corta:
string inversa =  new string(palabra.ToCharArray().Reverse().ToArray());
if (palabra.Equals(inversa))
{
    Console.WriteLine(palabra + " - Es una palabra palíndromo ya que al revés se lee: " +  inversa);
}

// Otra opción: 
int i = int.Parse(palabra);
i = palabra.Length;
for (int pos = i -1; pos >= 0; pos--)
{
    inversa += palabra[pos];
}
if (inversa == palabra)
{
    Console.WriteLine(palabra + " - Es una palabra palíndromo ya que al revés se lee: " + inversa);
}


/********************************************************************************************************************************************************************
                            Ejercicio IV
********************************************************************************************************************************************************************
Crear una aplicación que, cuando el usuario ingresa dos palabras, inidque si estas son un anagrama. 
Nota: anagrama son aquellas palabras que, reordenando sus letras, se forma una nueva palabra.
*/
//Me ayudé con el GitHub

Console.WriteLine("Ingrese la primera palabra:");
string pal1 = Console.ReadLine();
Console.WriteLine("Ingrese la segunda palabra:");
string pal2 = Console.ReadLine();

if (pal1.Length != pal2.Length)
{
    Console.WriteLine("No son anagramas.");
}
else
{
    //Para saber si son anagramas tienen que tener las mismas palabras.
    for (int iiiiii1 = 0; iiiiii1 < pal1.Length; iiiiii1++)
    {
        for (int iiiiii2 = 0; iiiiii2 < pal2.Length; iiiiii2++)
        {
            if (pal1[iiiiii1] == pal2[iiiiii2])
            {
                pal2 = pal2.Remove(iiiiii2, 1);
            }
        }
    }
    if (pal2.Length == 0)
    {
        Console.WriteLine("Son anagramas.");
    }
    else
    {
        Console.WriteLine("No son anagramas.");
    }
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

//Otra opción:
numero = Console.ReadLine();
int iiii = int.Parse(numero);
iiii = numero.Length;
for (int pos2 = iiii - 1; pos2 >= 0; pos2--)
{
    inversa2 += numero[pos2];
}


/********************************************************************************************************************************************************************
                            Ejercicio VII
********************************************************************************************************************************************************************
Crear una aplicación que, cuando el usuario ingrese cinco números, indique cuál es mayor, cuál es valor intermedio y cuál el menor.
*/
int mayor, intermedio, menor;

Console.WriteLine("Ingrese el primer número:");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
int numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercero número:");
int numero3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el cuarto número:");
int numero4 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el quinto número:");
int numero5 = int.Parse(Console.ReadLine());

//Repetir esta lógica para las otras posibilidades.
if (numero1 >= numero2 && numero1 >= numero3 && numero1 >= numero4 && numero1 >= numero5)
{
    mayor = numero1;

    if (numero2 >= numero3 && numero2 >= numero4 && numero2 >= numero5)
    {
        intermedio = numero2;

        if (numero3 <= numero4 && numero3 <= numero5)
        {
            menor = numero3;
        }
        if (numero4 <= numero3 && numero4 <= numero3)
        {
            menor = numero4;
        }
        if (numero5 <= numero3 && numero5 <= numero4)
        {
            menor = numero5;
        }
    }
}

// Opción 2, ayuda del GitHub
int pedir = 5;
int[] num = new int[pedir]; 
menor = 0;
intermedio = 0;
mayor = 0;
for (int i2 = 0; i2 <= pedir; i2++)
{
    Console.WriteLine("Ingrese un número:");
    num[i2] = int.Parse(Console.ReadLine());
    if (menor == 0)
    {
        menor = num[i2];
        mayor = num[i2];
    }
    if (num[i2]>mayor)
    {
        mayor = num[i2];
    }
    if (num[i2]<menor)
    {
        menor = numero[i2];
    }
}


/********************************************************************************************************************************************************************
                            Ejercicio VIII
********************************************************************************************************************************************************************
Crear una aplicación que, cuando el usuario ingrese una fecha, calcule la diferencia entre ésta y el día de hoy, mostrando por pantalla "La diferencia de fechas es de *nnnnn*
días."
*/
DateTime fecha = DateTime.Parse(Console.ReadLine());
TimeSpan diferencia = DateTime.Today.Subtract(fecha);
Console.WriteLine(diferencia);


/********************************************************************************************************************************************************************
                            Ejercicio X
********************************************************************************************************************************************************************
Crear una aplicación que lea un carácter tecleado por el usuario e indique si se trata de una vocal, una cifra numérica o una consonante.
Nota: Incluir todas las validaciones que considere necesarias (los caracteres especiales
no deben tenerse en cuenta).
*/
Console.WriteLine("Ingrese un caracter:");
string carac = Console.ReadLine().ToLower();

if (carac != "," || carac != ";" || carac != "." || carac != ":" || carac != " " || carac != "-" || carac != "_" || carac != "'" || carac != "?" || carac != "!" || carac != "¡" || carac != "¿")
{
    if (carac == "1" || carac == "2" || carac == "3" || carac == "4" || carac == "5" || carac == "6" || carac == "7" || carac == "8" || carac == "9")
    {
        Console.WriteLine("El caracter ingresado es un número.");
    }
    else if (carac == "a" || carac == "e" || carac == "i" || carac == "o" || carac == "u")
    {
        Console.WriteLine("El caracter ingresado es una vocal.");
    }
    else
    {
        Console.WriteLine("El caracter ingresado es una consonante.");
    }
}



/********************************************************************************************************************************************************************
                            Ejercicio X
********************************************************************************************************************************************************************
Crear una aplicación que, cuando el usuario ingrese un nombre, un apellido y la edad en un mismo input (en cualquier orden), indique cuál es cada uno.
*/
//No se como hacerlo en cualquier orden.
/*
int edad = 0;
string nombre, apellido;
Console.WriteLine("Ingrese: Nombre, Apellido, Edad separado por 'espacio': ");
string cadena = Console.ReadLine();

string palabras[] = cadena.Split(' ');

foreach(palabra in palabras)
{
    if (int.TryParse(palabra, out edad))
    {
        break;
    }
}
foreach(palabra in palabras)
{
    if (palabra != edad.ToString())
    {
        nombre = palabra;
    }
    else
    {
        apellido = palabra;
    }
}
*/


/********************************************************************************************************************************************************************
                            Ejercicio XIII
********************************************************************************************************************************************************************
Crear una aplicación que, cuando el usuario ingresa un número,calcule el factorial del mismo y lo muestre por pantalla.
Nota: el factorial de un número es el producto de todos los números enteros desde 1 hasta n.
Ejemplo: 5 != 1x2x3x4x5 = 120
*/
Console.WriteLine("Ingrese un número:");
int numero6 = int.Parse(Console.ReadLine());
for (int ii = 0; ii <= numero6 ; ii++)
{
    numero6 *= ii;
}


/********************************************************************************************************************************************************************
                            Ejercicio XV
********************************************************************************************************************************************************************
Crear una aplicación que verifique, en tres oportunidades, si la clave ingresada por el usuario es correcta. La clave será 
el nombre del usuario, si acierta mostrará por pantalla "Bienvenido, *usuario*", si no acierta mostrará "Acceso denegado",
y cuando se cumplan los tres intentos mostrará "Clave bloqueada".
*/
int contador = 0;
while (true)
{
    Console.WriteLine("Bienvenido!:");
    Console.WriteLine("Ingrese su contraseña para continuar:");
    var contra = Console.ReadLine().ToUpper();
    if (contra != "JAVIER")
    {
        contador += 1;
        if (contador == 3)
        {
            Console.WriteLine("Clave bloqueada.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Bienvenido: " + contra);
    }
}


/********************************************************************************************************************************************************************
                            Ejercicio XIX
********************************************************************************************************************************************************************
Crear una aplicación que, cuando el usuario ingrese una cantidad de palabras, las muestre por pantalla indicando el largo en cantidad de caracteres de cada una.
*/
Console.WriteLine("Ingrese palabras separadas por espacio:");
string cadena = Console.ReadLine();
foreach(var palabra2 in cadena)
{
    Console.WriteLine("La palabra: " + palabra2 + " contiene: " + palabra2.ToString().Length + " caracteres." );
}


/********************************************************************************************************************************************************************
                            Ejercicio XX
********************************************************************************************************************************************************************
Crear una aplicación que, cuando el usuario ingrese un número, indique la cantidad de números primos entre el cero y él, y su factorial.
Ejemplo: si el usuario ingresa 5, indicará: "Hasta el 5 hay 3 números primos y el factorial de 5 es 120".
*/
Console.WriteLine("Ingrese un número:");
int numero7  = int.Parse(Console.ReadLine());
string primos = "";
int factorial = 0;
for (int iii = 0; iii <= numero7; iii++)
{
    if (i % 2 == 0)
    {
        primos += 1;
    }
    factorial *= iii;
}
Console.WriteLine("Hasta el" + numero7 + " hay " + primos + " y el factorial de " + numero7 + " es " + factorial);
