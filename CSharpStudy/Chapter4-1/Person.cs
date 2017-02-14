using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_1 {
	public class Person {
		public string _name; //字段
		public string Name {
			get { return _name; }
			set { _name = value; }
		}


		private string _sex;
		public string Sex {
			get {
				return _sex;
			}

			set {
				this._sex = value;
			}
		}

		public string Gender {
			get {
				return _gender;
			}

			set {
				this._gender = value;
			}
		}

		private string _gender;
	}
}
