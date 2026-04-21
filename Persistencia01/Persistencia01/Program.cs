using System;
using System.IO;

namespace Persistencia01
{
	class Program
	{
		public static void Main(string[] args)
		{
			// DESAFIO 1:
				
				Console.WriteLine("Ingrese usuario;clave: ");
			string entrada = Console.ReadLine(); 
			
			
			string[] partes = entrada.Split(';');
			
			if (partes.Length >= 2) 
			{
				string usuario = partes[0];
				string clave = partes[1];
				
				if (clave.Contains("123"))
				{
					using (StreamWriter sw = new StreamWriter("seguridad.txt", true))
					{
						sw.WriteLine("Clave Débil detectada para el usuario: " + usuario);
					}
					Console.WriteLine("\nAVISO: Clave Débil detectada y guardada en seguridad.txt");
				}
				else
				{
					Console.WriteLine("\nClave segura. No se generó reporte.");
				}
			}
			else
			{
				Console.WriteLine("Error: El formato debe ser usuario;clave");
			}
			
			//DESAFIO 2:
			
			    string origen = "avatar.jpg";
				string destino = "respaldo.jpg";
				
				if (File.Exists(origen))
				{
				    
				    using (FileStream fsOrigen = new FileStream(origen, FileMode.Open, FileAccess.Read))
				    using (FileStream fsDestino = new FileStream(destino, FileMode.Create, FileAccess.Write))
				    {
				        
				        byte[] buffer = new byte[1024];
				        int bytesLeidos;
				
				       
				        while ((bytesLeidos = fsOrigen.Read(buffer, 0, buffer.Length)) > 0)
				        {
				            fsDestino.Write(buffer, 0, bytesLeidos);
				        }
				    }
				    Console.WriteLine("Imagen clonada exitosamente como 'respaldo.jpg'.");
				}
				else
				{
				    Console.WriteLine(" No se encontró el archivo 'avatar.jpg'.");
				    Console.WriteLine("Por favor coloca una imagen con ese nombre en la carpeta Debug.");
				}
				
				// DESAFIO 3:
			
				string rutaCarpeta = Directory.GetCurrentDirectory();
				string[] archivos = Directory.GetFiles(rutaCarpeta);
				
				Console.WriteLine("Escaneando archivos en: " + rutaCarpeta);
				
		
				foreach (string archivo in archivos)
				{
				    FileInfo informacion = new FileInfo(archivo);
				
				    if (informacion.Length > 5120)
				    {
				        if (informacion.Extension != ".exe" && informacion.Extension != ".cs")
				        {
				            Console.WriteLine("Borrando archivo pesado: " + informacion.Name + " (" + informacion.Length + " bytes)");
				        }
				    }
				}
				Console.WriteLine("Escaneo finalizado.");
				
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}