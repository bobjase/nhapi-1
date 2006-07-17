using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 CQ (Composite Quantity with Units) data type.  Consists of the following components: </p><ol>
/// <li>Quantity (NM)</li>
/// <li>Units (CE)</li>
/// </ol>
///</summary>
[Serializable]
public class CQ : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CQ.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CQ(Message message) : this(message, null){}

	///<summary>
	/// Creates a CQ.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CQ(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new NM(message,"Quantity");
		data[1] = new CE(message,"Units");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public Type[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="number">The ordinal item to get</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///<summary>
	public Type getComponent(int number) { 

		try { 
			return this.data[number]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CQ composite"); 
		} 
	} 
	///<summary>
	/// Returns Quantity (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Quantity {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Units (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE Units {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}