using System;
using NHapi.Base.Log;
using NHapi.Model.V231.Group;
using NHapi.Model.V231.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Message

{
///<summary>
/// Represents a SUR_P09 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
/// * 0: MSH (MSH - message header segment) 
/// * 1: SUR_P09_FACILITY (a Group object) repeating
///</summary>
[Serializable]
public class SUR_P09 : AbstractMessage  {

	///<summary> 
	/// Creates a new SUR_P09 Group with custom IModelClassFactory.
	///</summary>
	public SUR_P09(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new SUR_P09 Group with DefaultModelClassFactory. 
	///</summary> 
	public SUR_P09() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for SUR_P09.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SUR_P09_FACILITY), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SUR_P09 - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MSH (MSH - message header segment) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of SUR_P09_FACILITY (a Group object) - creates it if necessary
	///</summary>
	public SUR_P09_FACILITY getFACILITY() {
	   SUR_P09_FACILITY ret = null;
	   try {
	      ret = (SUR_P09_FACILITY)this.GetStructure("FACILITY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SUR_P09_FACILITY
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SUR_P09_FACILITY getFACILITY(int rep) { 
	   return (SUR_P09_FACILITY)this.GetStructure("FACILITY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SUR_P09_FACILITY 
	 */ 
	public int FACILITYReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("FACILITY").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}