using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 PRC message segment. 
 * This segment has the following fields:</p><p>
 * PRC-1: Primary Key Value - PRC (CE)<br> 
 * PRC-2: Facility ID - PRC (CE)<br> 
 * PRC-3: Department (CE)<br> 
 * PRC-4: Valid Patient Classes (IS)<br> 
 * PRC-5: Price (CP)<br> 
 * PRC-6: Formula (ST)<br> 
 * PRC-7: Minimum Quantity (NM)<br> 
 * PRC-8: Maximum Quantity (NM)<br> 
 * PRC-9: Minimum Price (MO)<br> 
 * PRC-10: Maximum Price (MO)<br> 
 * PRC-11: Effective Start Date (TS)<br> 
 * PRC-12: Effective End Date (TS)<br> 
 * PRC-13: Price Override Flag (IS)<br> 
 * PRC-14: Billing Category (CE)<br> 
 * PRC-15: Chargeable Flag (ID)<br> 
 * PRC-16: Active/Inactive Flag (ID)<br> 
 * PRC-17: Cost (MO)<br> 
 * PRC-18: Charge On Indicator (IS)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class PRC : AbstractSegment  {

  /**
   * Creates a PRC (Pricing) segment object that belongs to the given 
   * message.  
   */
  public PRC(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Primary Key Value - PRC");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Facility ID - PRC");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Department");
       this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 4}, "Valid Patient Classes");
       this.add(typeof(CP), false, 0, 12, new System.Object[]{message}, "Price");
       this.add(typeof(ST), false, 0, 200, new System.Object[]{message}, "Formula");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Minimum Quantity");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Maximum Quantity");
       this.add(typeof(MO), false, 1, 12, new System.Object[]{message}, "Minimum Price");
       this.add(typeof(MO), false, 1, 12, new System.Object[]{message}, "Maximum Price");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Effective Start Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Effective End Date");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 268}, "Price Override Flag");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Billing Category");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Chargeable Flag");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 183}, "Active/Inactive Flag");
       this.add(typeof(MO), false, 1, 12, new System.Object[]{message}, "Cost");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 269}, "Charge On Indicator");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Primary Key Value - PRC(PRC-1).
	*/
	public CE PrimaryKeyValuePRC
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (CE)t;
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
	* Returns a single repetition of Facility ID - PRC(PRC-2).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getFacilityIDPRC(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(2, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Facility ID - PRC (PRC-2).
   */
  public CE[] getFacilityIDPRC() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(2);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
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

	/**
	* Returns a single repetition of Department(PRC-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getDepartment(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Department (PRC-3).
   */
  public CE[] getDepartment() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
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

	/**
	* Returns a single repetition of Valid Patient Classes(PRC-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getValidPatientClasses(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(4, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Valid Patient Classes (PRC-4).
   */
  public IS[] getValidPatientClasses() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(4);  
        ret = new IS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (IS)t[i];
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

	/**
	* Returns a single repetition of Price(PRC-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CP getPrice(int rep)
	{
			CP ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (CP)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Price (PRC-5).
   */
  public CP[] getPrice() {
     CP[] ret = null;
    try {
        Type[] t = this.getField(5);  
        ret = new CP[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CP)t[i];
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

	/**
	* Returns a single repetition of Formula(PRC-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getFormula(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Formula (PRC-6).
   */
  public ST[] getFormula() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(6);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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

	/**
	* Returns Minimum Quantity(PRC-7).
	*/
	public NM MinimumQuantity
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (NM)t;
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
	* Returns Maximum Quantity(PRC-8).
	*/
	public NM MaximumQuantity
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (NM)t;
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
	* Returns Minimum Price(PRC-9).
	*/
	public MO MinimumPrice
	{
		get{
			MO ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (MO)t;
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
	* Returns Maximum Price(PRC-10).
	*/
	public MO MaximumPrice
	{
		get{
			MO ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (MO)t;
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
	* Returns Effective Start Date(PRC-11).
	*/
	public TS EffectiveStartDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (TS)t;
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
	* Returns Effective End Date(PRC-12).
	*/
	public TS EffectiveEndDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (TS)t;
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
	* Returns Price Override Flag(PRC-13).
	*/
	public IS PriceOverrideFlag
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (IS)t;
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
	* Returns a single repetition of Billing Category(PRC-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getBillingCategory(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Billing Category (PRC-14).
   */
  public CE[] getBillingCategory() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(14);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
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

	/**
	* Returns Chargeable Flag(PRC-15).
	*/
	public ID ChargeableFlag
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (ID)t;
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
	* Returns Active/Inactive Flag(PRC-16).
	*/
	public ID ActiveInactiveFlag
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(16, 0);
				ret = (ID)t;
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
	* Returns Cost(PRC-17).
	*/
	public MO Cost
	{
		get{
			MO ret = null;
			try
			{
			Type t = this.getField(17, 0);
				ret = (MO)t;
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
	* Returns Charge On Indicator(PRC-18).
	*/
	public IS ChargeOnIndicator
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (IS)t;
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


}}