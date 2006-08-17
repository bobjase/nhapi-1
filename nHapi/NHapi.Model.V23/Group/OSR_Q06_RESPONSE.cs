using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the OSR_Q06_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OSR_Q06_PATIENT (a Group object) <b>optional </b><br>
 * 1: OSR_Q06_ORDER (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class OSR_Q06_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new OSR_Q06_RESPONSE Group.
	 */
	public OSR_Q06_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("OSR_Q06_PATIENT", "2.3"), false, false);
	      this.add(factory.getGroupClass("OSR_Q06_ORDER", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OSR_Q06_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OSR_Q06_PATIENT (a Group object) - creates it if necessary
	 */
	public OSR_Q06_PATIENT PATIENT { 
get{
	   OSR_Q06_PATIENT ret = null;
	   try {
	      ret = (OSR_Q06_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of OSR_Q06_ORDER (a Group object) - creates it if necessary
	 */
	public OSR_Q06_ORDER  getORDER() { 
	   OSR_Q06_ORDER ret = null;
	   try {
	      ret = (OSR_Q06_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OSR_Q06_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OSR_Q06_ORDER getORDER(int rep) { 
	   return (OSR_Q06_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OSR_Q06_ORDER 
	 */ 
	public int ORDERReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ORDER").Length; 
	    }
 catch (HL7Exception e) 
{ 
	        String message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}