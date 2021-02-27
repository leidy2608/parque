using System;
					
public class Program
{
	public static void Main()
	{
		string cadena ="";
		int edad = 0;
		int altura = 0;


		Console.WriteLine("Bienvenido al parque A TODA VELOCIDAD");

		Console.Write("Para entrar y utilizar los juegos necesitaremos tus datos");
		Console.WriteLine("\nPor favor ingrsa tu edad"); // \n es un salto de linea
		cadena = Console.ReadLine();
		edad = Convert.ToInt32(cadena);


		if(edad < 15){

			Console.WriteLine("Lo sentimos pero no puedes ingresar a las instalaciones,el parque puede ser peligroso para usted");

		}else{

			Console.WriteLine("Bienvenido!Preparado para ir a toda velocidad?");

			// Los Juegos seran medidos por los colores del semaforo dependiendo de su peligro. 
			//Verde = Rapido.
			//Amarillo = Muy Rapido .
			// Rojo = Extremadamente rapido

			Console.WriteLine("Ahora por favor ingresa tu altura en centimetros");
			cadena = Console.ReadLine();
			altura = Convert.ToInt32(cadena);

			if(altura < 150){

				Console.Write("Solo podras ir a aquellos juegos que tengan color Verde");

			} else if (altura > 150 && altura < 165){

				Console.Write("Solo podras ir a aquellos juegos que tengan color Verde y Amarillo");

			} else if (altura > 165){

				Console.Write("Podras ir a aquellos juegos que tengan color Verde, Amarrillo y Rojo");

			}
		}	
	}
}