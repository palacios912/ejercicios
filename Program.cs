/*
 Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10
 */

int i;
int j = 0;
int resultado;

Console.Write("ingrese numero para tabla: ");
i = Convert.ToInt32(Console.ReadLine());

while (j<10)
{
    j++;
    resultado = i * j;
    Console.WriteLine($"{i} x {j} = {resultado}");
}
/*Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:

Reciba al menos un número por consola
Determine si el número es positivo o negativo
Presente un contador para cada tipo (positivo y negativo).
Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo.
Tienes completa libertad para elegir el formato de la salida.
*/
int i2;

do
{
    Console.Write("ingrese valor para calcular, presione 0 para salir :");
    i2 = Convert.ToInt32(Console.ReadLine());
    
    if (i2 > 0 && i2!=0)
    {
        Console.WriteLine("es numero mayor");
    }
    else
    {
        if (i2 == 0)
        {
            Console.WriteLine("es 0");
        }
        else
        {
            Console.WriteLine("es numero menor");
        }
    }
} while (i2 != 0);

/*Ejercicio 3 - For

Escribe un programa que realice estos pasos:

Reciba 3 datos:
ancho
alto
relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla.Ejemplos:
Input: 2,2,2, relleno = true
Output:

** **
** **
Input: 3, 4, 1, relleno = false
Output:
***
* *
* *
***
 */


int alto, ancho, cantidad;
string relleno;
string x = "*";
Console.Write("ingrese alto: ");
alto = Convert.ToInt32(Console.ReadLine());

Console.Write("ingrese ancho: ");
ancho = Convert.ToInt32(Console.ReadLine());

Console.Write("relleno (si o no): ");
relleno = Console.ReadLine();

Console.Write("ingrese cantidad: ");
cantidad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
for (int i4 = 0; i4 < cantidad; i4++)
{
    for (int i3 = 0; i3 < alto; i3++)
    {
        for (int j3 = 0; j3 < ancho; j3++)
        {
            if (relleno == "si")
            {
                Console.Write("*");
            }
            else if (relleno == "no")
            {
                if (i3 == 0 || i3 == alto - 1)
                {
                    Console.Write("*");
                }
                else if (j3 == 0 || j3 == ancho - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}