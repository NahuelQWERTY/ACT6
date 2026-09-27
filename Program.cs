using System;
using System.Diagnostics.CodeAnalysis;

/*
EJERCICIOS
1. Imprimir los numeros del 1 al 20 con for.
2. Imprimir solo los pares del 2 al 20.
3. Calcular la suma de 1 a 100 con for.
4. Cuenta regresiva del 10 al 1 con while.
5. Pedir al usuario un numero hasta que ingrese uno positivo (do-while).
6. Imprimir tabla de multiplicar del 5.
7. Usar foreach para imprimir cada letra de un string.
8. Usar break para detener el bucle cuando se encuentra el numero 13.
9. Usar continue para saltear multiplos de 3.
10. Crear patron de asteriscos: 5 filas con bucles anidados.
*/
class Program
{
    static void Main()
    {

//1. Imprimir los numeros del 1 al 20 con for.
    Console.WriteLine("Consigna 1");
    for (int i=1;i<21 ;i++ ){
    Console.WriteLine("Numero: "+ i);
    }      
//2. Imprimir solo los pares del 2 al 20.
    Console.WriteLine("Consigna 2");
    for (int i=2; i<21 ;i++)
        {
            if(i%2==0) Console.WriteLine ("pares: "+ i);
        }
//3. Calcular la suma de 1 a 100 con for.
    Console.WriteLine("Consigna 3");
    int suma=0;
    for (int i=1; i < 101; i++) suma=suma+i;
        Console.WriteLine(suma);
//4. Cuenta regresiva del 10 al 1 con while.
    Console.WriteLine("Consigna 4");
    int cuenta=10;
    while (cuenta > 0)
        {
            Console.WriteLine(cuenta);
            cuenta--;
        }
//5. Pedir al usuario un numero hasta que ingrese uno positivo (do-while).
    Console.WriteLine("Consigna 5");
    int opcion;
        do
        {
        Console.Write("Ingresa un numero positivo: ");
        opcion=int.Parse(Console.ReadLine()!);
        }
        while (opcion <= 0);
//6. Imprimir tabla de multiplicar del 5.
    Console.WriteLine("Consigna 6");
    for (int i=1; i<11; i++){
        int Cuenta1=i*5;
        Console.WriteLine(i+" x 5 "+" = "+ Cuenta1 );      
        }
//7. Usar foreach para imprimir cada letra de un string.
    Console.WriteLine("Consigna 7");
    string[] loschimpchons= {"L","o","s"," ","c","h","i","m","p","c","h","o","n","s"};
    foreach (string simpsons in loschimpchons)
        {
            Console.WriteLine(simpsons);
        }
//8. Usar break para detener el bucle cuando se encuentra el numero 13.
    Console.WriteLine("Consigna 8");
    for (int i = 0; 1<20; i++){
        Console.Write(i + " ");
        if (i==13){
            Console.WriteLine("bucle detenido al encontrar el numero 13");
            break ;
        }
        
        
    }
//9. Usar continue para saltear multiplos de 3.
    Console.WriteLine("Consigna 9");
    for (int i=0; i<50; i++){
        if(i%3==0) continue;
        Console.Write(i + " ");
    }

//10. Crear patron de asteriscos: 5 filas con bucles anidados.
    Console.WriteLine("\nConsigna 10");
    for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}