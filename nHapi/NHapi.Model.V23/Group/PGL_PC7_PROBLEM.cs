using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the PGL_PC7_PROBLEM Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PRB (Problem Detail) <b></b><br>
 * 1: NTE (Notes and comments segment) <b>optional repeating</b><br>
 * 2: VAR (Variance) <b>optional repeating</b><br>
 * 3: PGL_PC7_PROBLEM_ROLE (a Group object) <b>optional repeating</b><br>
 * 4: PGL_PC7_PROBLEM_OBSERVATION (a Group object) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class PGL_PC7_PROBLEM : AbstractGroup {

	/** 
	 * Creates a new PGL_PC7_PROBLEM Group.
	 */
	public PGL_PC7_PROBLEM(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PRB", "2.3"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.3"), false, true);
	      this.add(factory.getSegmentClass("VAR", "2.3"), false, true);
	      this.add(factory.getGroupClass("PGL_PC7_PROBLEM_ROLE", "2.3"), false, true);
	      this.add(factory.getGroupClass("PGL_PC7_PROBLEM_OBSERVATION", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PGL_PC7_PROBLEM - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PRB (Problem Detail) - creates it if necessary
	 */
	public PRB PRB { 
get{
	   PRB ret = null;
	   try {
	      ret = (PRB)this.get_Renamed("PRB");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE (Notes and comments segment) - creates it if necessary
	 */
	public NTE  getNTE() { 
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE
	 * (Notes and comments segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE(int rep) { 
	   return (NTE)this.get_Renamed("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("NTE").Length; 
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

	/**
	 * Returns  first repetition of VAR (Variance) - creates it if necessary
	 */
	public VAR  getVAR() { 
	   VAR ret = null;
	   try {
	      ret = (VAR)this.get_Renamed("VAR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of VAR
	 * (Variance) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public VAR getVAR(int rep) { 
	   return (VAR)this.get_Renamed("VAR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of VAR 
	 */ 
	public int VARReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("VAR").Length; 
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

	/**
	 * Returns  first repetition of PGL_PC7_PROBLEM_ROLE (a Group object) - creates it if necessary
	 */
	public PGL_PC7_PROBLEM_ROLE  getPROBLEM_ROLE() { 
	   PGL_PC7_PROBLEM_ROLE ret = null;
	   try {
	      ret = (PGL_PC7_PROBLEM_ROLE)this.get_Renamed("PROBLEM_ROLE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PGL_PC7_PROBLEM_ROLE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PGL_PC7_PROBLEM_ROLE getPROBLEM_ROLE(int rep) { 
	   return (PGL_PC7_PROBLEM_ROLE)this.get_Renamed("PROBLEM_ROLE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PGL_PC7_PROBLEM_ROLE 
	 */ 
	public int PROBLEM_ROLEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROBLEM_ROLE").Length; 
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

	/**
	 * Returns  first repetition of PGL_PC7_PROBLEM_OBSERVATION (a Group object) - creates it if necessary
	 */
	public PGL_PC7_PROBLEM_OBSERVATION  getPROBLEM_OBSERVATION() { 
	   PGL_PC7_PROBLEM_OBSERVATION ret = null;
	   try {
	      ret = (PGL_PC7_PROBLEM_OBSERVATION)this.get_Renamed("PROBLEM_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PGL_PC7_PROBLEM_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PGL_PC7_PROBLEM_OBSERVATION getPROBLEM_OBSERVATION(int rep) { 
	   return (PGL_PC7_PROBLEM_OBSERVATION)this.get_Renamed("PROBLEM_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PGL_PC7_PROBLEM_OBSERVATION 
	 */ 
	public int PROBLEM_OBSERVATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROBLEM_OBSERVATION").Length; 
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