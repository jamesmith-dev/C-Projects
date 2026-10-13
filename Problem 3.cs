using System;

// Subject interface
public interface IRealSubject
{
		void Request();
}

// RealSubject class
public class RealSubject : IRealSubject
{
		public void Request()
		{
				Console.WriteLine("RealSubject: Handling request.");
		}
}

// Proxy class
public class Proxy : IRealSubject
{
		private RealSubject realSubject;

		public void Request()
		{
				// Lazy initialization: creating the RealSubject object only when needed
				if (realSubject == null)
				{
						realSubject = new RealSubject();
				}

				Console.WriteLine("Proxy: Checking access before handling request.");
				realSubject.Request();
				Console.WriteLine("Proxy: Logging the request.");
		}
}

class Program
{
		static void Main()
		{
				// Using the Proxy to access the RealSubject
				IRealSubject proxy = new Proxy();
				proxy.Request();

				Console.ReadKey();
		}
}
