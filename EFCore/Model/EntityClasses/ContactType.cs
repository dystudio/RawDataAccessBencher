﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ContactType'.</summary>
	public partial class ContactType : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="ContactType"/> class.</summary>
		public ContactType() : base()
		{
			this.BusinessEntityContacts = new List<BusinessEntityContact>();
			OnCreated();
		}

		/// <summary>Gets or sets the ContactTypeId field. </summary>
		public System.Int32 ContactTypeId { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityContact.ContactType - ContactType.BusinessEntityContacts (m:1)'</summary>
		public virtual List<BusinessEntityContact> BusinessEntityContacts { get; set;}
	}
}