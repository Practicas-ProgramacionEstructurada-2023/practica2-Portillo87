using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
           //Declarcion de variables de tipo texto capturando desde la terminal
           string? nombre;
           string? apellido;

           // Declaracion de variables de tipo texto  desde codigo 
           string? codigo_estudiante = "U20230820";
           string? becado = "No";

           //Declaracion de variables de tipo enteras capturando desde la terminal
           int edad;

           //Declaracion de variable de tipo ennteras desde codigo
           int AñoIngreso = 2023;
           int AñoEgreso = 2028;

           //Declaracion de variables desimales capturando desde la terminal
           double mensualidad;

           //Declaracion de variable decimales desde codigo
           double transporte = 5.50;
           double alimentacion = 8.75;

           //Declaracion de variable de tiempo o time
           DateTime fechaActual = DateTime. Now;
           DateTime fechaEspecifica = new DateTime (23, 8, 19, 16,20,00);



           //Obtencion de datos desde la terminal
           Console.WriteLine ("Ingrese su nombre:");
           nombre = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");
           Console.WriteLine("Ingrese su apellido:");
           apellido = Convert.ToString(Console.ReadLine());
           Console.WriteLine();


           Console.WriteLine("Ingrese su edad:");
           edad = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Ingrese su mensualidad:");
           mensualidad = Convert.ToDouble(Console.ReadLine());


           //Impresion de datos 
           Console.WriteLine("Su nombre: " + nombre);
           Console.WriteLine("Su apellido es:" + apellido);
           Console.WriteLine("Su codigo estudiantil es:" + codigo_estudiante);
           Console.WriteLine("Es becado:" + becado);
           Console.WriteLine("Su edad es:" + edad);
           Console.WriteLine("Su año de ingreso es :" + AñoIngreso);
           Console.WriteLine("Su año de egreso sera: " + AñoEgreso);
           Console.WriteLine("Su mensualidad universitaria es:" + "$" + mensualidad);
           Console.WriteLine("Su gastos diarios de transporte es:" + "$" + transporte);
           Console.WriteLine("Su gasto diario de alimentacion es:" + "$" + alimentacion);
           Console.WriteLine("La fecha y tiempo de impresion de datos es:" + fechaActual);
           Console.WriteLine("La fecha que termina la practica es:" + fechaEspecifica);
           Console.WriteLine("*******************************Fin de impresion**************************");

           Console.WriteLine("****************************Inicion de impresion*************************");
           //APLICACION DE FUNCIONES DE CADENA

           //Funcion de comparacion cadenas de texto
           bool cadenaComparativa= nombre == apellido;

           //Funcion de Minuscula
           string? funcionMinuscula1 = nombre.ToLower();
           string? funcionMinuscula2 = apellido.ToLower();

           //Funcion de Mayuscula
           string? funcionMayuscula1 = nombre.ToUpper();
           string? funcionMayuscula2 = apellido.ToUpper();


           //Funcion  de tamaño de cadena
           int iilongituCadena1=nombre.Length;
           int iilongituCadena2=apellido.Length;
           
           //Funcion de cadena
           string? cadenaConcatenada = nombre + " " + apellido;

           Console.WriteLine("Comparacion: " + cadenaComparativa);
           Console.WriteLine("Mayuscula Nombre y Apellido: " + funcionMayuscula1 + " " + funcionMayuscula2);
           Console.WriteLine("Minuscula nombre y Apellido: " + funcionMinuscula1 + " " + funcionMinuscula2);
           Console.WriteLine("Concatenacion: " + cadenaConcatenada);
           Console.WriteLine("La longitud de datos de nombre es: " + iilongituCadena1);
           Console.WriteLine("La longitud de datos de nombre es: " + iilongituCadena2);
           Console.WriteLine("*******************************Fin de impresion*****************************");
           

        }
    }
}