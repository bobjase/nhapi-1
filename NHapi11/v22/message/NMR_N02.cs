using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v22.group;
using ca.uhn.hl7v2.model.v22.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a NMR_N02 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: MSA (MESSAGE ACKNOWLEDGMENT) <b></b><br>
 * 2: ERR (ERROR) <b>optional </b><br>
 * 3: QRD (QUERY DEFINITION) <b>optional </b><br>
 * 4: NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v22.message

{
[Serializable]
public class NMR_N02 : AbstractMessage  {

	/** 
	 * Creates a new NMR_N02 Group with custom ModelClassFactory.
	 */
	public NMR_N02(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new NMR_N02 Group with DefaultModelClassFactory. 
	 */ 
	public NMR_N02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(ERR), false, false);
	      this.add(typeof(QRD), false, false);
	      this.add(typeof(NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMR_N02 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (MESSAGE HEADER) - creates it if necessary
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
	 * Returns MSA (MESSAGE ACKNOWLEDGMENT) - creates it if necessary
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
	 * Returns ERR (ERROR) - creates it if necessary
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
	 * Returns QRD (QUERY DEFINITION) - creates it if necessary
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
	 * Returns  first repetition of NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT (a Group object) - creates it if necessary
	 */
	public NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT getCLOCK_AND_STATS_WITH_NOTES_ALT() {
	   NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT ret = null;
	   try {
	      ret = (NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT)this.get_Renamed("CLOCK_AND_STATS_WITH_NOTES_ALT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT getCLOCK_AND_STATS_WITH_NOTES_ALT(int rep) { 
	   return (NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT)this.get_Renamed("CLOCK_AND_STATS_WITH_NOTES_ALT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT 
	 */ 
	public int CLOCK_AND_STATS_WITH_NOTES_ALTReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("CLOCK_AND_STATS_WITH_NOTES_ALT").Length; 
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
