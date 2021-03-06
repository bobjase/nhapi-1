using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v21.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v21.segment{

/**
 * <p>Represents an HL7 NK1 message segment. 
 * This segment has the following fields:</p><p>
 * NK1-1: SET ID - NEXT OF KIN (SI)<br> 
 * NK1-2: NEXT OF KIN NAME (PN)<br> 
 * NK1-3: NEXT OF KIN RELATIONSHIP (ST)<br> 
 * NK1-4: NEXT OF KIN - ADDRESS (AD)<br> 
 * NK1-5: NEXT OF KIN - PHONE NUMBER (TN)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class NK1 : AbstractSegment  {

  /**
   * Creates a NK1 (NEXT OF KIN) segment object that belongs to the given 
   * message.  
   */
  public NK1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "SET ID - NEXT OF KIN");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "NEXT OF KIN NAME");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "NEXT OF KIN RELATIONSHIP");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "NEXT OF KIN - ADDRESS");
       this.add(typeof(TN), false, 0, 40, new System.Object[]{message}, "NEXT OF KIN - PHONE NUMBER");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns SET ID - NEXT OF KIN(NK1-1).
	*/
	public SI SETIDNEXTOFKIN
	{
		get{
			SI ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (SI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns NEXT OF KIN NAME(NK1-2).
	*/
	public PN NEXTOFKINNAME
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (PN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns NEXT OF KIN RELATIONSHIP(NK1-3).
	*/
	public ST NEXTOFKINRELATIONSHIP
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns NEXT OF KIN - ADDRESS(NK1-4).
	*/
	public AD NEXTOFKINADDRESS
	{
		get{
			AD ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (AD)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of NEXT OF KIN - PHONE NUMBER(NK1-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getNEXTOFKINPHONENUMBER(int rep)
	{
			TN ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of NEXT OF KIN - PHONE NUMBER (NK1-5).
   */
  public TN[] getNEXTOFKINPHONENUMBER() {
     TN[] ret = null;
    try {
        Type[] t = this.getField(5);  
        ret = new TN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}


}}