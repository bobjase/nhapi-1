using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

///<summary>
/// <p>The HL7 CK (composite ID with check digit) data type.  Consists of the following components: </p><ol>
/// <li>ID number (NM) (NM)</li>
/// <li>check digit (NM)</li>
/// <li>code identifying the check digit scheme employed (ID)</li>
/// <li>assigning authority (HD)</li>
/// </ol>
///</summary>
[Serializable]
public class CK : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CK.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CK(Message message) : this(message, null){}

	///<summary>
	/// Creates a CK.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CK(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new NM(message,"ID number (NM)");
		data[1] = new NM(message,"Check digit");
		data[2] = new ID(message, 0,"Code identifying the check digit scheme employed");
		data[3] = new HD(message,"Assigning authority");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element CK composite"); 
		} 
	} 
	///<summary>
	/// Returns ID number (NM) (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM IDNumber {
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
	/// Returns check digit (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM CheckDigit {
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
	///<summary>
	/// Returns code identifying the check digit scheme employed (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID CodeIdentifyingTheCheckDigitSchemeEmployed {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns assigning authority (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public HD AssigningAuthority {
get{
	   HD ret = null;
	   try {
	      ret = (HD)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}