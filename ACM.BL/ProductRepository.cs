﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class ProductRepository
	{
		public Product Retrieve(int productId)
		{
			Product product = new Product(productId);

			if (productId == 2)
			{
				product.ProductName = "Sunflowers";
				product.ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers";
				product.CurrentPrice = 15.96M;
			}

			Object myObject = new Object();
			Console.WriteLine($"Object:{myObject.ToString()}");
			Console.WriteLine($"Product:{product.ToString()}");
			return product;
		}
		public bool Save(Product product)
		{
			var success = true;
			if (product.HasChanges)
			{
				if (product.IsValid)
				{
					if (product.IsNew)
					{
						

					}
					else
					{
						
					}
				}
				else
				{
					success = false;
				}
				
			}

			return success;
		}
	}
}
