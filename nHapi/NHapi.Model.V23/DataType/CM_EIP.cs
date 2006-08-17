using System;using NHapi.Base.model;
using ca.uhn.log;

namespace NHapi.Base.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_EIP (parent order) data type.  Consists of the following components: </p><ol>
/// <li>parent´s placer order number (EI)</li>
/// <li>parent´s filler order number (EI)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_EIP : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_EIP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_EIP(Message message) : base(message){
		data = new Type[2];
		data[0] = new EI(message);
		data[1] = new EI(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_EIP composite"); 
		} 
	} 
	///<summary>
	/// Returns parent´s placer order number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public EI ParentSPlacerOrderNumber {
get{
	   EI ret = null;
	   try {
	      ret = (EI)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns parent´s filler order number (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public EI ParentSFillerOrderNumber {
get{
	   EI ret = null;
	   try {
	      ret = (EI)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}