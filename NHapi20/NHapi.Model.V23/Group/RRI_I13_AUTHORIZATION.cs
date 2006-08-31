using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
///<summary>
///Represents the RRI_I13_AUTHORIZATION Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: AUT (Authorization Information) 
/// * 1: CTD (Contact Data) optional 
///</summary>
[Serializable]
public class RRI_I13_AUTHORIZATION : AbstractGroup {

	///<summary> 
	/// Creates a new RRI_I13_AUTHORIZATION Group.
	///</summary>
	public RRI_I13_AUTHORIZATION(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(AUT), true, false);
	      this.add(typeof(CTD), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRI_I13_AUTHORIZATION - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns AUT (Authorization Information) - creates it if necessary
	///</summary>
	public AUT AUT { 
get{
	   AUT ret = null;
	   try {
	      ret = (AUT)this.GetStructure("AUT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns CTD (Contact Data) - creates it if necessary
	///</summary>
	public CTD CTD { 
get{
	   CTD ret = null;
	   try {
	      ret = (CTD)this.GetStructure("CTD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}