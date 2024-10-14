using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_09_Endimensionella {
	internal class Program {
		static void ArrayAlgorithmExample() {
			Random rng = new Random();

			int[] myNumbers = new int[11];
			for (int i = 0; i < myNumbers.Length; i++) {
				myNumbers[i] = rng.Next(10);
			}

			for (int i = 0; i < myNumbers.Length; i++) {
				// myNumbers[i] -= 10;
				Console.WriteLine(myNumbers[i]);
			}

			Console.WriteLine("===========");

			for (int i = 0; i < myNumbers.Length - 1; i += 2) {
				int firstNumber = myNumbers[i];
				int secondNumber = myNumbers[i + 1];

				Console.WriteLine(secondNumber - firstNumber);
			}


		}

		static void Main(string[] args) {
			ArrayAlgorithmExample();
		}
	}
}
