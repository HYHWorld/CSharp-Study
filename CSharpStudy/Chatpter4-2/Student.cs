using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatpter4_2 {
	class Student : Person{
		public Student(int i,int j):base(i,j){
			Console.WriteLine("hehe");
		}

		public new void Func() {
			Console.WriteLine("hhhh");
		}
	}
}
