using System;
using NHapi.Base.model;
namespace NHapi.Base.model.v23.datatype
{
///<summary>
///<p>Represents the HL7 ST (string data) datatype.  A ST contains a single String value.
///<summary>
[Serializable]
public class ST : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized ST.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public ST(Message message) : base(message){
	}

	///<summary>
	///  @return "2.3"
	///</summary>
	public String getVersion() {
	    return "2.3";
}
}
}