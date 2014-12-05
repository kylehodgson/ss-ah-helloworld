using System;
using ServiceStack;

namespace HelloWorld
{
	public class AppHost : AppHostBase
	{
		public AppHost () : base("Hello World Service Stack App", typeof(GreetingService).Assembly)
		{ }

		public override void Configure (Funq.Container container)
		{ }

	}
}

