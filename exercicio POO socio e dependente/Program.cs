using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_POO_socio_e_dependente
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Socio> Socios = new List<Socio>();
			List<Dependente> Dependentes = new List<Dependente>();

			Socio Soc;

			Dependente Dep;

			do
			{
				Soc = new Socio();

				Soc.EntraDados();

				Socios.Add(Soc);

				Console.WriteLine("\n O Sócio possui Dependentes? (S/N)");

				if (Console.ReadKey(true).Key == ConsoleKey.S)
				{
					do
					{
						Dep = new Dependente();

						Dep.EntraDados(Soc.NumeroDaCota);

						Console.WriteLine("Deseja cadastrar outro dependente? (S/N)");

					} while (Console.ReadKey(true).Key == ConsoleKey.S);
				}

				Console.Clear();

				foreach (Socio socio in Socios)
				{
					Console.WriteLine($"\n {socio.NumeroDaCota} - {socio.NomeDoSocio}");
					Console.WriteLine($"\n Nascimento:  - {socio.DataNasc}");
					Console.WriteLine($"\n Aquisição: - {socio.DataAquisicao}");


					foreach (Dependente dependente in Dependentes)
					{
						if (dependente.NumeroDaCota == socio.NumeroDaCota)
						{
							Console.WriteLine($" {dependente.NomeDependente}");
						}
					}

				}

				Console.ReadKey();


				int Cota;

				Console.WriteLine("Digite uma cota para exclusão: ");
				Cota = int.Parse(Console.ReadLine());

				foreach (Socio socio1 in Socios)
				{
					if (socio1.NumeroDaCota == Cota)
						Soc = socio1;
				}

				Socios.Remove(Soc);



			} while (true);
		}
	}
}
