using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_POO_socio_e_dependente
{
	internal class Dependente
	{
		public string NomeDependente { get; set; }
		public int NumeroDaCota { get; set; }
		public string DataDeNascimento { get; set; }

		public void EntraDados(int Cota)
		{
			NumeroDaCota = Cota;

			Console.WriteLine("\n\n Nome do Dependente:");
			NomeDependente = Console.ReadLine();

			Console.WriteLine("Data de Nascimento:");
			DataDeNascimento = Console.ReadLine();
		}
	}
}
