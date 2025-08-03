using System;	// System namespace

namespace Hello{
	class displayHello{
		static void Main(string[] args){
			// Console class form System
			// WriteLine, ReadLine methods from Console
			Console.WriteLine("Enter your name : ");
			string name = Console.ReadLine();
			Console.WriteLine("HELLO! " + name);
			Console.WriteLine("Enter your age : ");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Age " + age);
		}
	}
}
