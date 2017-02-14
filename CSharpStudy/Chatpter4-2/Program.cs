using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chatpter4_2 {
	class Program {
		static void Main(string[] args) {
			//string str = "hehe";//无法单独更改
			//Console.WriteLine(str[0]);
			//Console.ReadKey();
			//string str = null;
			//StringBuilder sb = new StringBuilder();
			//Stopwatch sw = new Stopwatch();
			//sw.Start();
			//for(int i = 0; i < 100000; i++) {
			//	//str += i;
			//	sb.Append(i);
			//}
			//sw.Stop();
			//Console.WriteLine(sb.ToString());
			//Console.WriteLine(sw.Elapsed);
			//Console.ReadKey();
			//string str = "1   3 5  67 8 , +'@$%#$%^#%$^ 1223";
			//Regex reg = new Regex(@"[\d]*");
			//str = reg.Replace(str, "");
			//Console.Write(str);
			//Console.ReadKey();


			//几个常用的字符串函数	
			//1.Replace
			//2.SubString
			//3.Split
			//4.Contains
			//5.Join 带上分隔符加入数组
			Student s = new Student(1, 2);
			s.Func();
			Console.ReadKey();
		}
	}
}
