using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
	    public Customer(): this(0)
	    {
					
	    }

	    public Customer(int customerId)
	    {
		    CustomerId = customerId;
			AddressList = new List<Address>();
	    }
		public List<Address> AddressList { get; set; }
	    public int CustomerId { get; private set; }
	    public int CustomerType { get; set; }
	    public string EmailAddress { get; set; }
		public string FirstName { get; set; }

		public string FullName
		{
			get
			{
				string fullname = LastName;
				if (!string.IsNullOrWhiteSpace(FirstName))
				{
					if (!string.IsNullOrWhiteSpace(fullname))
					{
						fullname += ", ";
					}
					fullname += FirstName;
				}
				return fullname;
			}
		}
		public static int InstanceCount { get; set; }
	    public string _lastname;
	    public string LastName
	    {
			get
			{
				return _lastname;
			}
			set
			{
				_lastname = value;
			}
	    }

		public string Log()=>
		$"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
	    public override string ToString() => FullName;
	    public override bool Validate()
	    {
		    var isValid = true;

			if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
			if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

			return isValid;

	    }
    }
}