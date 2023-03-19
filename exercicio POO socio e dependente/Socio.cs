using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_POO_socio_e_dependente
{
	public class Socio
	{
		public int NumeroDaCota { get; set; }
		public string NomeDoSocio { get; set; }
		public string DataNasc { get; set; }
		public string DataAquisicao { get; set; }

		public void EntraDados()
		{
			Console.Clear();

			Console.WriteLine("Cadastro de Sócio: ");
			Console.WriteLine("==================\n");

			Console.WriteLine("Número da Cota:");
			NumeroDaCota = int.Parse(Console.ReadLine());
			
			Console.WriteLine("\nNome do Sócio: ");
			NomeDoSocio = Console.ReadLine();
			
			Console.WriteLine("\nData de Nascimento: ");
			DataNasc = Console.ReadLine();
			
			Console.WriteLine("\nData de Aquisição: ");
			DataAquisicao = Console.ReadLine();
		}
	}
}
