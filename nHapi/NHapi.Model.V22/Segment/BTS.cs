using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 BTS message segment. 
 * This segment has the following fields:</p><p>
 * BTS-1: Batch Message Count (ST)<br> 
 * BTS-2: Batch Comment (ST)<br> 
 * BTS-3: Batch Totals (CM_BATCH_TOTAL)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class BTS : AbstractSegment  {

  /**
   * Creates a BTS (BATCH TRAILER) segment object that belongs to the given 
   * message.  
   */
	public BTS(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ST), false, 1, 10, new System.Object[]{message}, "Batch Message Count");
       this.add(typeof(ST), false, 1, 80, new System.Object[]{message}, "Batch Comment");
       this.add(typeof(CM_BATCH_TOTAL), false, 0, 100, new System.Object[]{message}, "Batch Totals");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Batch Message Count(BTS-1).
	*/
	public ST BatchMessageCount
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(1, 0);
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
	* Returns Batch Comment(BTS-2).
	*/
	public ST BatchComment
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns a single repetition of Batch Totals(BTS-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_BATCH_TOTAL getBatchTotals(int rep)
	{
			CM_BATCH_TOTAL ret = null;
			try
			{
			IType t = this.getField(3, rep);
				ret = (CM_BATCH_TOTAL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Batch Totals (BTS-3).
   */
  public CM_BATCH_TOTAL[] getBatchTotals() {
     CM_BATCH_TOTAL[] ret = null;
    try {
        IType[] t = this.getField(3);  
        ret = new CM_BATCH_TOTAL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_BATCH_TOTAL)t[i];
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