
using System;
using System.IO;

namespace Persistencia01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("TALLER SECCION B");
			
			//Creamos un directorio
			
				string rutaRaiz = Path.Combine(AppDomain .CurrentDomain .BaseDirectory ,"DATOS IUJO");
				string rutaReportes = Path.Combine (rutaRaiz,"reportes");
				
				Console.WriteLine (rutaRaiz);
				Console .WriteLine (rutaReportes);
				
				if(Directory .Exists (rutaReportes )){
					Directory.CreateDirectory (rutaReportes );
					Console .WriteLine ("directorio creado correctamente");
				}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}