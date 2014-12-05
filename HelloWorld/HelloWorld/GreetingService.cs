using System;
using ServiceStack;

namespace HelloWorld
{
	public class GreetingService : Service
	{

		public string Get(GreetingRequest request)
		{
			return "Hello, {0}!".Fmt(request.Name);
		}
	}

}

