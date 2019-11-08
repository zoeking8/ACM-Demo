﻿using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
	[TestClass]
	public class StringHandlerTest
	{
		[TestMethod]
		public void InsertSpacesTestValid()
		{
			var source = "SonicScrewdriver";
			var expected = "Sonic Screwdriver";

			var actual = source.InsertSpaces();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void InsertSpacesTestWithExistingSpace()
		{
			var source = "Sonic Screwdriver";
			var expected = "Sonic Screwdriver";

			var actual = StringHandler.InsertSpaces(source);
			Assert.AreEqual(expected, actual);
		}
	}
}
