using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment{

/**
 * <p>Represents an HL7 RXO message segment. 
 * This segment has the following fields:</p><p>
 * RXO-1: Requested Give Code (CE)<br> 
 * RXO-2: Requested Give Amount - Minimum (NM)<br> 
 * RXO-3: Requested Give Amount - Maximum (NM)<br> 
 * RXO-4: Requested Give Units (CE)<br> 
 * RXO-5: Requested Dosage Form (CE)<br> 
 * RXO-6: Provider's Pharmacy Instructions (CE)<br> 
 * RXO-7: Provider's Administration Instructions (CE)<br> 
 * RXO-8: Deliver To Location (CM_LA1)<br> 
 * RXO-9: Allow Substitutions (ID)<br> 
 * RXO-10: Requested Dispense Code (CE)<br> 
 * RXO-11: Requested Dispense Amount (NM)<br> 
 * RXO-12: Requested Dispense Units (CE)<br> 
 * RXO-13: Number of Refills (NM)<br> 
 * RXO-14: Ordering Provider's DEA Number (CN)<br> 
 * RXO-15: Pharmacist/Treatment Supplier's Verifier ID (CN)<br> 
 * RXO-16: Needs Human Review (ID)<br> 
 * RXO-17: Requested Give Per (Time Unit) (ST)<br> 
 * RXO-18: Requested Give Strength (NM)<br> 
 * RXO-19: Requested Give Strength Units (CE)<br> 
 * RXO-20: Indication (CE)<br> 
 * RXO-21: Requested Give Rate Amount (ST)<br> 
 * RXO-22: Requested Give Rate Units (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RXO : AbstractSegment  {

  /**
   * Creates a RXO (Pharmacy prescription order segment) segment object that belongs to the given 
   * message.  
   */
  public RXO(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CE), true, 1, 100, new System.Object[]{message}, "Requested Give Code");
       this.add(typeof(NM), true, 1, 20, new System.Object[]{message}, "Requested Give Amount - Minimum");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Requested Give Amount - Maximum");
       this.add(typeof(CE), true, 1, 60, new System.Object[]{message}, "Requested Give Units");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Requested Dosage Form");
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message}, "Provider's Pharmacy Instructions");
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message}, "Provider's Administration Instructions");
       this.add(typeof(CM_LA1), false, 1, 200, new System.Object[]{message}, "Deliver To Location");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 161}, "Allow Substitutions");
       this.add(typeof(CE), false, 1, 100, new System.Object[]{message}, "Requested Dispense Code");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Requested Dispense Amount");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Requested Dispense Units");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Number of Refills");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "Ordering Provider's DEA Number");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "Pharmacist/Treatment Supplier's Verifier ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Needs Human Review");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Requested Give Per (Time Unit)");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Requested Give Strength");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Requested Give Strength Units");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Indication");
       this.add(typeof(ST), false, 1, 6, new System.Object[]{message}, "Requested Give Rate Amount");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Requested Give Rate Units");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Requested Give Code(RXO-1).
	*/
	public CE RequestedGiveCode
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
	* Returns Requested Give Amount - Minimum(RXO-2).
	*/
	public NM RequestedGiveAmountMinimum
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Requested Give Amount - Maximum(RXO-3).
	*/
	public NM RequestedGiveAmountMaximum
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Requested Give Units(RXO-4).
	*/
	public CE RequestedGiveUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Requested Dosage Form(RXO-5).
	*/
	public CE RequestedDosageForm
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns a single repetition of Provider's Pharmacy Instructions(RXO-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getProviderSPharmacyInstructions(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Provider's Pharmacy Instructions (RXO-6).
   */
  public CE[] getProviderSPharmacyInstructions() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(6);  
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
	* Returns a single repetition of Provider's Administration Instructions(RXO-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getProviderSAdministrationInstructions(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Provider's Administration Instructions (RXO-7).
   */
  public CE[] getProviderSAdministrationInstructions() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(7);  
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
	* Returns Deliver To Location(RXO-8).
	*/
	public CM_LA1 DeliverToLocation
	{
		get{
			CM_LA1 ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CM_LA1)t;
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
	* Returns Allow Substitutions(RXO-9).
	*/
	public ID AllowSubstitutions
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Requested Dispense Code(RXO-10).
	*/
	public CE RequestedDispenseCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns Requested Dispense Amount(RXO-11).
	*/
	public NM RequestedDispenseAmount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Requested Dispense Units(RXO-12).
	*/
	public CE RequestedDispenseUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns Number of Refills(RXO-13).
	*/
	public NM NumberOfRefills
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns Ordering Provider's DEA Number(RXO-14).
	*/
	public CN OrderingProviderSDEANumber
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (CN)t;
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
	* Returns Pharmacist/Treatment Supplier's Verifier ID(RXO-15).
	*/
	public CN PharmacistTreatmentSupplierSVerifierID
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (CN)t;
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
	* Returns Needs Human Review(RXO-16).
	*/
	public ID NeedsHumanReview
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
	* Returns Requested Give Per (Time Unit)(RXO-17).
	*/
	public ST RequestedGivePerTimeUnit
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns Requested Give Strength(RXO-18).
	*/
	public NM RequestedGiveStrength
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns Requested Give Strength Units(RXO-19).
	*/
	public CE RequestedGiveStrengthUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns Indication(RXO-20).
	*/
	public CE Indication
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns Requested Give Rate Amount(RXO-21).
	*/
	public ST RequestedGiveRateAmount
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(21, 0);
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
	* Returns Requested Give Rate Units(RXO-22).
	*/
	public CE RequestedGiveRateUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(22, 0);
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


}}