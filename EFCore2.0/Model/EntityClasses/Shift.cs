﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.3.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore20.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Shift'.</summary>
	public partial class Shift : CommonEntityBase
	{
		#region Class Extensibility Methods
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Shift"/> class.</summary>
		public Shift() : base()
		{
			this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
			OnCreated();
		}

		/// <summary>Gets or sets the EndTime field. </summary>
		public System.TimeSpan EndTime { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set;}
		/// <summary>Gets or sets the ShiftId field. </summary>
		public System.Byte ShiftId { get; set;}
		/// <summary>Gets or sets the StartTime field. </summary>
		public System.TimeSpan StartTime { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'EmployeeDepartmentHistory.Shift - Shift.EmployeeDepartmentHistories (m:1)'</summary>
		public List<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set;}
	}
}