using System;

namespace Vjezbe_6
{

	public class Zadatak_8
	{
		public static void Main()
		{

			int[] niz = new int[5];
			int unos;
			bool ok = true;

			for (int i = 0; i < niz.Length; i++)
			{
				Console.Write($"\nUnos {i} : ");

				unos = int.Parse(Console.ReadLine());

				ok = true;

				for (int j = 0; j < i; j++)
				{
					if (unos == niz[j])
					{
						ok = false;
						break;
					}
				}

				if (!ok)
				{
					Console.Write("Vas unos je vec sadrzan u nizu!!!\n");
					i--;
					continue;
				}

				niz[i] = unos;
			}

			Array.Sort(niz, 0, niz.Length);

			Console.Write("\nSortirani niz glasi : ");

			for (int i = 0; i < niz.Length; i++)
			{
				Console.Write(niz[i] + ", ");
			}

			Console.Write("\b\b \n");
		}
	}
}