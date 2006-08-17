using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v231.segment;

using NHapi.Base.model;
/**
 * <p>Represents the ADR_A19_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: EVN (EVN - event type segment) <b>optional </b><br>
 * 1: PID (PID - patient identification segment) <b></b><br>
 * 2: PD1 (PD1 - patient additional demographic segment) <b>optional </b><br>
 * 3: NK1 (NK1 - next of kin / associated parties segment-) <b>optional repeating</b><br>
 * 4: PV1 (PV1 - patient visit segment-) <b></b><br>
 * 5: PV2 (PV2 - patient visit - additional information segment) <b>optional </b><br>
 * 6: DB1 (DB1 - Disability segment) <b>optional repeating</b><br>
 * 7: OBX (OBX - observation/result segment) <b>optional repeating</b><br>
 * 8: AL1 (AL1 - patient allergy information segment) <b>optional repeating</b><br>
 * 9: DG1 (DG1 - diagnosis segment) <b>optional repeating</b><br>
 * 10: DRG (DRG - diagnosis related group segment) <b>optional </b><br>
 * 11: ADR_A19_PROCEDURE (a Group object) <b>optional repeating</b><br>
 * 12: GT1 (GT1 - guarantor segment) <b>optional repeating</b><br>
 * 13: ADR_A19_INSURANCE (a Group object) <b>optional repeating</b><br>
 * 14: ACC (ACC - accident segment) <b>optional </b><br>
 * 15: UB1 (UB1 - UB82 data segment) <b>optional </b><br>
 * 16: UB2 (UB2 - UB92 data segment) <b>optional </b><br>
 */
namespace NHapi.Base.model.v231.group
{
[Serializable]
public class ADR_A19_QUERY_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new ADR_A19_QUERY_RESPONSE Group.
	 */
	public ADR_A19_QUERY_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("EVN", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("PID", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("PD1", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("NK1", "2.3.1"), false, true);
	      this.add(factory.getSegmentClass("PV1", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("PV2", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("DB1", "2.3.1"), false, true);
	      this.add(factory.getSegmentClass("OBX", "2.3.1"), false, true);
	      this.add(factory.getSegmentClass("AL1", "2.3.1"), false, true);
	      this.add(factory.getSegmentClass("DG1", "2.3.1"), false, true);
	      this.add(factory.getSegmentClass("DRG", "2.3.1"), false, false);
	      this.add(factory.getGroupClass("ADR_A19_PROCEDURE", "2.3.1"), false, true);
	      this.add(factory.getSegmentClass("GT1", "2.3.1"), false, true);
	      this.add(factory.getGroupClass("ADR_A19_INSURANCE", "2.3.1"), false, true);
	      this.add(factory.getSegmentClass("ACC", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("UB1", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("UB2", "2.3.1"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADR_A19_QUERY_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns EVN (EVN - event type segment) - creates it if necessary
	 */
	public EVN EVN { 
get{
	   EVN ret = null;
	   try {
	      ret = (EVN)this.get_Renamed("EVN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PID (PID - patient identification segment) - creates it if necessary
	 */
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.get_Renamed("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary
	 */
	public PD1 PD1 { 
get{
	   PD1 ret = null;
	   try {
	      ret = (PD1)this.get_Renamed("PD1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NK1 (NK1 - next of kin / associated parties segment-) - creates it if necessary
	 */
	public NK1  getNK1() { 
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.get_Renamed("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NK1
	 * (NK1 - next of kin / associated parties segment-) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NK1 getNK1(int rep) { 
	   return (NK1)this.get_Renamed("NK1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NK1 
	 */ 
	public int NK1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("NK1").Length; 
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
	 * Returns PV1 (PV1 - patient visit segment-) - creates it if necessary
	 */
	public PV1 PV1 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.get_Renamed("PV1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PV2 (PV2 - patient visit - additional information segment) - creates it if necessary
	 */
	public PV2 PV2 { 
get{
	   PV2 ret = null;
	   try {
	      ret = (PV2)this.get_Renamed("PV2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of DB1 (DB1 - Disability segment) - creates it if necessary
	 */
	public DB1  getDB1() { 
	   DB1 ret = null;
	   try {
	      ret = (DB1)this.get_Renamed("DB1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DB1
	 * (DB1 - Disability segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DB1 getDB1(int rep) { 
	   return (DB1)this.get_Renamed("DB1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DB1 
	 */ 
	public int DB1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("DB1").Length; 
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
	 * Returns  first repetition of OBX (OBX - observation/result segment) - creates it if necessary
	 */
	public OBX  getOBX() { 
	   OBX ret = null;
	   try {
	      ret = (OBX)this.get_Renamed("OBX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OBX
	 * (OBX - observation/result segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OBX getOBX(int rep) { 
	   return (OBX)this.get_Renamed("OBX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OBX 
	 */ 
	public int OBXReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("OBX").Length; 
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
	 * Returns  first repetition of AL1 (AL1 - patient allergy information segment) - creates it if necessary
	 */
	public AL1  getAL1() { 
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.get_Renamed("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of AL1
	 * (AL1 - patient allergy information segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public AL1 getAL1(int rep) { 
	   return (AL1)this.get_Renamed("AL1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AL1 
	 */ 
	public int AL1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("AL1").Length; 
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
	 * Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary
	 */
	public DG1  getDG1() { 
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.get_Renamed("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DG1
	 * (DG1 - diagnosis segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DG1 getDG1(int rep) { 
	   return (DG1)this.get_Renamed("DG1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DG1 
	 */ 
	public int DG1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("DG1").Length; 
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
	 * Returns DRG (DRG - diagnosis related group segment) - creates it if necessary
	 */
	public DRG DRG { 
get{
	   DRG ret = null;
	   try {
	      ret = (DRG)this.get_Renamed("DRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ADR_A19_PROCEDURE (a Group object) - creates it if necessary
	 */
	public ADR_A19_PROCEDURE  getPROCEDURE() { 
	   ADR_A19_PROCEDURE ret = null;
	   try {
	      ret = (ADR_A19_PROCEDURE)this.get_Renamed("PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ADR_A19_PROCEDURE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ADR_A19_PROCEDURE getPROCEDURE(int rep) { 
	   return (ADR_A19_PROCEDURE)this.get_Renamed("PROCEDURE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ADR_A19_PROCEDURE 
	 */ 
	public int PROCEDUREReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROCEDURE").Length; 
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
	 * Returns  first repetition of GT1 (GT1 - guarantor segment) - creates it if necessary
	 */
	public GT1  getGT1() { 
	   GT1 ret = null;
	   try {
	      ret = (GT1)this.get_Renamed("GT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of GT1
	 * (GT1 - guarantor segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public GT1 getGT1(int rep) { 
	   return (GT1)this.get_Renamed("GT1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of GT1 
	 */ 
	public int GT1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("GT1").Length; 
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
	 * Returns  first repetition of ADR_A19_INSURANCE (a Group object) - creates it if necessary
	 */
	public ADR_A19_INSURANCE  getINSURANCE() { 
	   ADR_A19_INSURANCE ret = null;
	   try {
	      ret = (ADR_A19_INSURANCE)this.get_Renamed("INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ADR_A19_INSURANCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ADR_A19_INSURANCE getINSURANCE(int rep) { 
	   return (ADR_A19_INSURANCE)this.get_Renamed("INSURANCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ADR_A19_INSURANCE 
	 */ 
	public int INSURANCEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("INSURANCE").Length; 
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
	 * Returns ACC (ACC - accident segment) - creates it if necessary
	 */
	public ACC ACC { 
get{
	   ACC ret = null;
	   try {
	      ret = (ACC)this.get_Renamed("ACC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns UB1 (UB1 - UB82 data segment) - creates it if necessary
	 */
	public UB1 UB1 { 
get{
	   UB1 ret = null;
	   try {
	      ret = (UB1)this.get_Renamed("UB1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns UB2 (UB2 - UB92 data segment) - creates it if necessary
	 */
	public UB2 UB2 { 
get{
	   UB2 ret = null;
	   try {
	      ret = (UB2)this.get_Renamed("UB2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}