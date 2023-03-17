using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_POO_socio_e_dependente
{
	internal class Socio
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
			
			Console.WriteLine("Nome do Sócio: ");
			NomeDoSocio = Console.ReadLine();
			
			Console.WriteLine("Data de Nascimento: ");
			DataNasc = Console.ReadLine();
			
			Console.WriteLine("Data de Aquisição: ");
			DataAquisicao = Console.ReadLine();
		}
	}
}
