using System;
namespace classes{
	
	class Car{
		
		string brand;
		int speed;
		
		public Car(string b, int s){
			brand = b;
			speed = s;
		}
		
		public void Accelerate(int x){
			speed = speed+x;
		}
		
		public void Brake(int x){
			speed = speed-x;
		}
		
		public void Display(){
			Console.WriteLine($"Car : {brand} Speed : {speed}");
		}
	}
	
	class Main_Prog{
		public static void Main(){
			Car c1 = new Car("Toyota", 100);
			c1.Display();
			c1.Accelerate(100);
			c1.Display();
			c1.Brake(100);
			c1.Display();
		}
	}
}
