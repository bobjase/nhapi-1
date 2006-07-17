using System;
using ca.uhn.hl7v2.model;
namespace ca.uhn.hl7v2.model.v24.datatype
{
///<summary>
///<p>Represents the HL7 SI (sequence ID) datatype.  A SI contains a single String value.
///<summary>
[Serializable]
public class SI : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized SI.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public SI(Message message) : base(message){
	}

	public SI(Message message, string description) : base(message,description){
	}

	///<summary>
	///  @return "2.4"
	///</summary>
	public string getVersion() {
	    return "2.4";
}
}
}