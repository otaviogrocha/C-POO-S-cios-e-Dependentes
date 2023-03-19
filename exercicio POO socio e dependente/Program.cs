using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_POO_socio_e_dependente
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<Socio> Socios = new List<Socio>();
			List<Dependente> Dependentes = new List<Dependente>();

			Socio Soc;
			
			(Soc, Socios, Dependentes) = AdicionaCota(Socios, Dependentes);

			Console.Clear();
			

			MostraDados(Socios, Dependentes);


			Console.WriteLine("\n Você deseja excluir alguma cota? (S/N)");
			if (Console.ReadKey(true).Key == ConsoleKey.S)
			{

				RemoveCota(Soc, Socios, Dependentes);

				Console.Clear();

				MostraDados(Socios, Dependentes);
			}
			

			Console.ReadKey();
		}


		public static (Socio, List<Socio>, List<Dependente>) AdicionaCota( List<Socio> Socios, List<Dependente> Dependentes)
		{
			Socio Soc;

			Dependente Dep;

			do
			{
				Soc = new Socio();

				Soc.EntraDados();

				Socios.Add(Soc);

				Console.WriteLine("\nO Sócio possui Dependentes? (S/N)");

				if (Console.ReadKey(true).Key == ConsoleKey.S)
				{
					do
					{
						Dep = new Dependente();

						Dep.EntraDados(Soc.NumeroDaCota);

						Dependentes.Add(Dep);

						Console.WriteLine("\nDeseja cadastrar outro dependente? (S/N)");

					} while (Console.ReadKey(true).Key == ConsoleKey.S);
				}

				Console.Clear();
				Console.WriteLine("Deseja cadastrar outro sócio? (S/N)");

			} while (Console.ReadKey(true).Key == ConsoleKey.S);

			return (Soc, Socios, Dependentes);
		}



		public static void RemoveCota(Socio Soc, List<Socio> Socios, List<Dependente> Dependentes)
		{
			int Cota;

			Console.WriteLine("\nDigite uma cota para exclusão: ");
			Cota = int.Parse(Console.ReadLine());

			foreach (Socio socio1 in Socios)
			{
				if (socio1.NumeroDaCota == Cota)
					Soc = socio1;
			}

			Socios.Remove(Soc);


			List<Dependente> CotasExcluir = new List<Dependente>();

			foreach (Dependente dep in Dependentes)
			{
				if (dep.NumeroDaCota == Cota)
				{
					CotasExcluir.Add(dep);
				}
			}

			foreach (Dependente dep1 in CotasExcluir)
			{
				if (dep1 != null)
				{
					Dependentes.Remove(dep1);
				}
			}
		}


		public static void MostraDados(List<Socio> Socios, List<Dependente> Dependentes)
		{
			
			foreach (Socio socio in Socios)
			{
				Console.WriteLine($"\n {socio.NumeroDaCota} - {socio.NomeDoSocio}");
				Console.WriteLine($"\n Nascimento: {socio.DataNasc}");
				Console.WriteLine($"\n Aquisição: {socio.DataAquisicao}");


				foreach (Dependente dependente in Dependentes)
				{
					if (dependente.NumeroDaCota == socio.NumeroDaCota)
					{
						Console.WriteLine("\n  Dependentes: ");
						Console.WriteLine($"  {dependente.NomeDependente}");
					}
				}

			}
		}
	}
}
