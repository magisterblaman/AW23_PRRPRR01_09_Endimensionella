using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_09_Endimensionella {
	internal class Program {
		static void CumulativeExample() {
			int sum = 0;
			for (int i = 1; i <= 10; i++) {
				//if (i % 2 == 0) {
				//	sum += i * i;
				//} else {
				//	sum -= i * i;
				//}

				sum += i * i * (int)Math.Pow(-1, i);
			}
			Console.WriteLine(sum);
		}

		static void Main(string[] args) {
			CumulativeExample();
		}
	}
}
