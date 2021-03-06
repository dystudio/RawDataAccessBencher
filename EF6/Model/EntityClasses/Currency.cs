﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Currency'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Currency : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="Currency"/> class.</summary>
		public Currency() : base()
		{
			this.CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
			this.CurrencyRates = new HashSet<CurrencyRate>();
			this.CurrencyRates_ = new HashSet<CurrencyRate>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the CurrencyCode field. </summary>
		[DataMember]
		public System.String CurrencyCode { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		[DataMember]
		public System.String Name { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'CountryRegionCurrency.Currency - Currency.CountryRegionCurrencies (m:1)'</summary>
		[DataMember]
		public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'CurrencyRate.Currency - Currency.CurrencyRates (m:1)'</summary>
		[DataMember]
		public virtual ICollection<CurrencyRate> CurrencyRates { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'CurrencyRate.Currency_ - Currency.CurrencyRates_ (m:1)'</summary>
		[DataMember]
		public virtual ICollection<CurrencyRate> CurrencyRates_ { get; set;}
		#endregion
	}
}
