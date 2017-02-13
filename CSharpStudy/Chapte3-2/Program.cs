using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapte3_2 {
	public enum Grander {
		男,
		女
	}
	class Program {
		static void Main(string[] args) {
			//const提示词
			//enum枚举
			//struct结构
			Grander g =	Grander.女;//枚举和int兼容
			Grander ge = (Grander)Enum.Parse(typeof(Grander), "1"); //String->Grander
			Console.WriteLine(g);
			Console.WriteLine(ge);
			Console.ReadKey();
			//out:返回多个值时使用,无需赋值,但方法内必须赋值
			//ref:带入值运算,必须赋值后带入,但方法内可以不赋值
			//out,ref:类似指针
			//params任意个数参数
		}
	}
}
