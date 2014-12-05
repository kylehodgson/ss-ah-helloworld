
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld
{
	public class Global : System.Web.HttpApplication
	{

		protected void Application_Start ()
		{
			(new AppHost ()).Init ();
		}
	}
}
