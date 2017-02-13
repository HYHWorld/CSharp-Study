using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3 {
	class Program {
		static void Main(string[] args) {
			//类型装换
			//int i = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine(i);
			//Console.ReadKey();
			//int i = 0;
			//try {
			//	i = Convert.ToInt32(Console.ReadLine());
			//} catch {
			//	Console.WriteLine("转换失败");
			//}
			//Console.WriteLine(i);
			//Console.ReadKey();
			int i = 0;
			Random r = new Random();//随机数
			while (i != 10) {
				int n = r.Next(1, 7);
				Console.WriteLine(n);
				i++;
			}
			int x = int.Parse("1");//类型转换
			Console.WriteLine(int.MaxValue);
			Console.ReadKey();
		}
	}
}
