// See https://aka.ms/new-console-template for more information


/* Ejercicio I
Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del
propio número de registro (en caso de ser comenzar con 0, sumarle 100), todos los
números deben mostrarse por pantalla y, con los múltiplos de 3 se debera agregar
“Foo”, con los múltiplos de 5, “Bar”, y, por último, con los múltiplos de ambos, “FooBar”.
Por ejemplo, con el número mostrará “15 – FooBar”.
*/

Console.WriteLine("Ingrese su número de su registro:");
int numeroRegistro = int.Parse(Console.ReadLine());
string nro = numeroRegistro.ToString();
nro = nro.Substring(0, 3);
Console.WriteLine(nro);

Convert.ToInt32(nro);
int a = 0;
for (int i = 0; i < numeroRegistro; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + "-" + "FooBar");
    }
    if (i % 5 == 0)
	{
		Console.WriteLine(i + "-" + "Bar");
	}
    if (i % 3 == 0)
    {
        Console.WriteLine(i + "-" + "Foo");
    }
    if (i % 3 != 0 && i % 5 != 0)
    {
        Console.WriteLine(i);
    }
}





