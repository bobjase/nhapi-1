using System;
using ca.uhn.log;
using NHapi.Base.model.v231.group;
using NHapi.Base.model.v231.segment;
using NHapi.Base;
using NHapi.Base.parser;
using NHapi.Base.model;

/**
 * <p>Represents a PTR_PCF message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MSH - message header segment) <b></b><br>
 * 1: MSA (MSA - message acknowledgment segment) <b></b><br>
 * 2: ERR (ERR - error segment) <b>optional </b><br>
 * 3: QAK (Query Acknowledgement) <b>optional </b><br>
 * 4: QRD (QRD - original-style query definition segment) <b></b><br>
 * 5: PTR_PCF_PATIENT (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Base.model.v231.message

{
[Serializable]
public class PTR_PCF : AbstractMessage  {

	/** 
	 * Creates a new PTR_PCF Group with custom ModelClassFactory.
	 */
	public PTR_PCF(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new PTR_PCF Group with DefaultModelClassFactory. 
	 */ 
	public PTR_PCF() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("MSA", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("ERR", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("QAK", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("QRD", "2.3.1"), true, false);
	      this.add(factory.getGroupClass("PTR_PCF_PATIENT", "2.3.1"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PTR_PCF - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (MSH - message header segment) - creates it if necessary
	 */
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.get_Renamed("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns MSA (MSA - message acknowledgment segment) - creates it if necessary
	 */
	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.get_Renamed("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ERR (ERR - error segment) - creates it if necessary
	 */
	public ERR ERR { 
get{
	   ERR ret = null;
	   try {
	      ret = (ERR)this.get_Renamed("ERR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns QAK (Query Acknowledgement) - creates it if necessary
	 */
	public QAK QAK { 
get{
	   QAK ret = null;
	   try {
	      ret = (QAK)this.get_Renamed("QAK");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns QRD (QRD - original-style query definition segment) - creates it if necessary
	 */
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.get_Renamed("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PTR_PCF_PATIENT (a Group object) - creates it if necessary
	 */
	public PTR_PCF_PATIENT  getPATIENT() { 
	   PTR_PCF_PATIENT ret = null;
	   try {
	      ret = (PTR_PCF_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PTR_PCF_PATIENT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PTR_PCF_PATIENT getPATIENT(int rep) { 
	   return (PTR_PCF_PATIENT)this.get_Renamed("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PTR_PCF_PATIENT 
	 */ 
	public int PATIENTReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PATIENT").Length; 
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