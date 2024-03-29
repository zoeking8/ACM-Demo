﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class CustomerRepository
	{
		private AddressRepository addressRepository { get; set; }

		public CustomerRepository()
		{
			addressRepository = new AddressRepository();
		}
		public Customer Retrieve(int customerId)
		{
			Customer customer = new Customer(customerId);
			{
				if (customerId == 1)
				{
					customer.EmailAddress = "fbaggins@hobbiton.me";
					customer.FirstName = "Frodo";
					customer.LastName = "Baggins";
					customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
				}

				return customer;
			}
		}

		public bool Save(Customer customer)
		{
			return true;
		}
	}
}
