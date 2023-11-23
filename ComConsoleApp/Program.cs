using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryC_;

namespace ComConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var objCOMPlus = new COMPlusServices();
			Console.WriteLine(objCOMPlus.DoTransaction());
			Console.ReadLine();
		}
	}
}
