using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_RI (interval) data type.  Consists of the following components: </p><ol>
/// <li>repeat pattern (ST)</li>
/// <li>explicit time intevall (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_RI : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_RI.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_RI(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_RI.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_RI(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new ST(message,"Repeat pattern");
		data[1] = new ST(message,"Explicit time intevall");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_RI composite"); 
		} 
	} 
	///<summary>
	/// Returns repeat pattern (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST RepeatPattern {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns explicit time intevall (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ExplicitTimeIntevall {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}