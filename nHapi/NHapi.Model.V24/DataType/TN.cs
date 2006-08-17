using System;
using NHapi.Base.model;
namespace NHapi.Base.model.v24.datatype
{
///<summary>
///<p>Represents the HL7 TN (telephone number) datatype.  A TN contains a single String value.
///<summary>
[Serializable]
public class TN : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized TN.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public TN(Message message) : base(message){
	}

	///<summary>
	///  @return "2.4"
	///</summary>
	public String getVersion() {
	    return "2.4";
}
}
}