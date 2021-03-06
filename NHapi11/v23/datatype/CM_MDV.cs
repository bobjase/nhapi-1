using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_MDV (minimum/maximum data values) data type.  Consists of the following components: </p><ol>
/// <li>Minimum Value (NM)</li>
/// <li>Maximum Value (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_MDV : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_MDV.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_MDV(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_MDV.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_MDV(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new NM(message,"Minimum Value");
		data[1] = new NM(message,"Maximum Value");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_MDV composite"); 
		} 
	} 
	///<summary>
	/// Returns Minimum Value (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM MinimumValue {
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
	/// Returns Maximum Value (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM MaximumValue {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}