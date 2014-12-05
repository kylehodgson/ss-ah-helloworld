using System;
using NUnit.Framework;

namespace HelloWorld.Tests
{
	[TestFixture]
	public class HelloWorldServiceTests
	{
		[Test]
		public void ShouldHaveWorkingTestHarness() 
		{
			Assert.AreEqual (true, true);
		}

		[Test]
		public void ShouldRespondToGreetings() {
			var target = new GreetingService ();
			var response = target.Get(new GreetingRequest{Name="World"});
			Assert.That (response.Equals ("Hello, World!"));
		}
	}
}

