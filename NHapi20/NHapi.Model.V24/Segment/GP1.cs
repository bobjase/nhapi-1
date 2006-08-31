using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

///<summary>
/// Represents an HL7 GP1 message segment. 
/// This segment has the following fields:
/// * GP1-1: Type of Bill Code (IS)
/// * GP1-2: Revenue Code (IS)
/// * GP1-3: Overall Claim Disposition Code (IS)
/// * GP1-4: OCE Edits per Visit Code (IS)
/// * GP1-5: Outlier Cost (CP)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class GP1 : AbstractSegment  {

  /**
   * Creates a GP1 (Grouping/Reimbursement - Visit) segment object that belongs to the given 
   * message.  
   */
	public GP1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(IS), true, 1, 3, new System.Object[]{message, 455}, "Type of Bill Code");
       this.add(typeof(IS), false, 0, 3, new System.Object[]{message, 456}, "Revenue Code");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 457}, "Overall Claim Disposition Code");
       this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 458}, "OCE Edits per Visit Code");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Outlier Cost");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Type of Bill Code(GP1-1).
	///</summary>
	public IS TypeOfBillCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

	///<summary>
	/// Returns a single repetition of Revenue Code(GP1-2).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public IS getRevenueCode(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(2, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Revenue Code (GP1-2).
   ///</summary>
  public IS[] getRevenueCode() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(2);  
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

	///<summary>
	/// Returns Overall Claim Disposition Code(GP1-3).
	///</summary>
	public IS OverallClaimDispositionCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

	///<summary>
	/// Returns a single repetition of OCE Edits per Visit Code(GP1-4).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public IS getOCEEditsPerVisitCode(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(4, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of OCE Edits per Visit Code (GP1-4).
   ///</summary>
  public IS[] getOCEEditsPerVisitCode() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(4);  
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

	///<summary>
	/// Returns Outlier Cost(GP1-5).
	///</summary>
	public CP OutlierCost
	{
		get{
			CP ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (CP)t;
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