using System;

interface IUFO
{
		void fly();
		void goToHyperspace();
		void land();
}

class Animal
{
		public void move()
		{
				Console.WriteLine("Animal is moving.");
		}

		public void sleep()
		{
				Console.WriteLine("Animal is sleeping.");
		}

		public void eat()
		{
				Console.WriteLine("Animal is eating.");
		}
}

class Dog : Animal
{
		public void sing()
		{
				Console.WriteLine("Dog is barking.");
		}

		public void wash()
		{
				Console.WriteLine("Dog is being washed.");
		}

		public void turnAround()
		{
				Console.WriteLine("Dog is turning around.");
		}
}

class Cat : Animal
{
		public void sing()
		{
				Console.WriteLine("Cat is meowing.");
		}

		public void wash()
		{
				Console.WriteLine("Cat is grooming itself.");
		}

		public void turnAround()
		{
				Console.WriteLine("Cat is turning around.");
		}
}

class Bird : Animal
{
		public void sing()
		{
				Console.WriteLine("Bird is chirping.");
		}

		public void wash()
		{
				Console.WriteLine("Bird is bathing.");
		}

		public void turnAround()
		{
				Console.WriteLine("Bird is turning around in the air.");
		}
}

class SmallCraft : IUFO
{
		public void fly()
		{
				Console.WriteLine("SmallCraft is flying.");
		}

		public void goToHyperspace()
		{
				Console.WriteLine("SmallCraft is going to hyperspace.");
		}

		public void land()
		{
				Console.WriteLine("SmallCraft is landing.");
		}
}

class LargeCraft : IUFO
{
		public void fly()
		{
				Console.WriteLine("LargeCraft is flying.");
		}

		public void goToHyperspace()
		{
				Console.WriteLine("LargeCraft is going to hyperspace.");
		}

		public void land()
		{
				Console.WriteLine("LargeCraft is landing.");
		}
}

class BossCraft : IUFO
{
		public void fly()
		{
				Console.WriteLine("BossCraft is flying.");
		}

		public void goToHyperspace()
		{
				Console.WriteLine("BossCraft is going to hyperspace.");
		}

		public void land()
		{
				Console.WriteLine("BossCraft is landing.");
		}
}

class Program
{
		static void Main()
		{
				Dog myDog = new Dog();
				Cat myCat = new Cat();
				Bird myBird = new Bird();

				SmallCraft smallUFO = new SmallCraft();
				LargeCraft largeUFO = new LargeCraft();
				BossCraft bossUFO = new BossCraft();

				// Calling methods for Dog
				Console.WriteLine("Dog:");
				myDog.move();
				myDog.sleep();
				myDog.eat();
				myDog.sing();
				myDog.wash();
				myDog.turnAround();

				// Calling methods for Cat
				Console.WriteLine("\nCat:");
				myCat.move();
				myCat.sleep();
				myCat.eat();
				myCat.sing();
				myCat.wash();
				myCat.turnAround();

				// Calling methods for Bird
				Console.WriteLine("\nBird:");
				myBird.move();
				myBird.sleep();
				myBird.eat();
				myBird.sing();
				myBird.wash();
				myBird.turnAround();

				// Calling methods for SmallCraft
				Console.WriteLine("\nSmallCraft (UFO):");
				smallUFO.fly();
				smallUFO.goToHyperspace();
				smallUFO.land();

				// Calling methods for LargeCraft
				Console.WriteLine("\nLargeCraft (UFO):");
				largeUFO.fly();
				largeUFO.goToHyperspace();
				largeUFO.land();

				// Calling methods for BossCraft
				Console.WriteLine("\nBossCraft (UFO):");
				bossUFO.fly();
				bossUFO.goToHyperspace();
				bossUFO.land();
		}
}
