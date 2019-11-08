using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
	[TestClass]
	public class LoggingServiceTest
	{
		[TestMethod]
		public void WriteToFileTest()
		{
			var changedItems = new List<ILoggable>();

			var customer = new Customer(1)
			{
				EmailAddress = "fbagins@hobbiton.me",
				FirstName = "Frodo",
				LastName = "Baggins",
				AddressList = null

			};
			
			changedItems.Add(customer);

			var product = new Product(2)
			{
				ProductName = "Rake",
				ProductDescription = "Garden rake with steel head",
				CurrentPrice = 6M
			};
			changedItems.Add(product);

			LoggingService.WriteToFile(changedItems);

		}
	}
}
