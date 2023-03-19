using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_POO_socio_e_dependente
{
	public class Dependente
	{
		public string NomeDependente { get; set; }
		public int NumeroDaCota { get; set; }
		public string DataDeNascimento { get; set; }

		public void EntraDados(int Cota)
		{
			NumeroDaCota = Cota;

			Console.WriteLine("\n\nNome do Dependente:");
			NomeDependente = Console.ReadLine();

			Console.WriteLine("\nData de Nascimento:");
			DataDeNascimento = Console.ReadLine();
		}
	}
}
