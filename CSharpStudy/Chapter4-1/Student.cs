using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_1 {
	public class Student : Person{
		private string _chinese;
		private string _english;
		private string _math;

		Student(String Name,String Sex,String Gender) {
			this.Name = Name;
			this.Sex = Sex;
			this.Gender = Gender;
		}

		public string Chinese {
			get {
				return _chinese;
			}

			set {
				this._chinese = value;
			}
		}

		public string English {
			get {
				return _english;
			}

			set {
				this._english = value;
			}
		}

		public string Math {
			get {
				return _math;
			}

			set {
				this._math = value;
			}
		}
	}
}
