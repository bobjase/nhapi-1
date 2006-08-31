using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 UB1 message segment. 
    /// This segment has the following fields:
    /// * UB1-1: Set ID - UB1 (SI)
    /// * UB1-2: Blood Deductible  (43) (NM)
    /// * UB1-3: Blood Furnished Pints Of (40) (NM)
    /// * UB1-4: Blood Replaced Pints (41) (NM)
    /// * UB1-5: Blood Not Replaced Pints(42) (NM)
    /// * UB1-6: Co Insurance Days (25) (NM)
    /// * UB1-7: Condition Code (35-39) (IS)
    /// * UB1-8: Covered Days   (23) (NM)
    /// * UB1-9: Non Covered Days   (24) (NM)
    /// * UB1-10: Value Amount and Code (46-49) (CM_UVC)
    /// * UB1-11: Number Of Grace Days (90) (NM)
    /// * UB1-12: Spec Program Indicator (44) (CE)
    /// * UB1-13: PSRO/UR Approval Indicator (87) (ID)
    /// * UB1-14: PSRO/UR Approved Stay Fm (88) (DT)
    /// * UB1-15: PSRO/UR Approved Stay To (89) (DT)
    /// * UB1-16: Occurrence (28 32) (CM_OCD)
    /// * UB1-17: Occurrence Span (33) (ID)
    /// * UB1-18: Occur Span Start Date(33) (DT)
    /// * UB1-19: Occur Span End Date (33) (DT)
    /// * UB1-20: UB 82 Locator 2 (ST)
    /// * UB1-21: UB 82 Locator 9 (ST)
    /// * UB1-22: UB 82 Locator 27 (ST)
    /// * UB1-23: UB 82 Locator 45 (ST)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class UB1 : AbstractSegment
    {

        /**
         * Creates a UB1 (UB82  data) segment object that belongs to the given 
         * message.  
         */
        public UB1(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(SI), false, 1, 4, new System.Object[] { message }, "Set ID - UB1");
                this.add(typeof(NM), false, 1, 1, new System.Object[] { message }, "Blood Deductible  (43)");
                this.add(typeof(NM), false, 1, 2, new System.Object[] { message }, "Blood Furnished Pints Of (40)");
                this.add(typeof(NM), false, 1, 2, new System.Object[] { message }, "Blood Replaced Pints (41)");
                this.add(typeof(NM), false, 1, 2, new System.Object[] { message }, "Blood Not Replaced Pints(42)");
                this.add(typeof(NM), false, 1, 2, new System.Object[] { message }, "Co Insurance Days (25)");
                this.add(typeof(IS), false, 5, 2, new System.Object[] { message, 43 }, "Condition Code (35-39)");
                this.add(typeof(NM), false, 1, 3, new System.Object[] { message }, "Covered Days   (23)");
                this.add(typeof(NM), false, 1, 3, new System.Object[] { message }, "Non Covered Days   (24)");
                this.add(typeof(CM_UVC), false, 8, 12, new System.Object[] { message }, "Value Amount and Code (46-49)");
                this.add(typeof(NM), false, 1, 2, new System.Object[] { message }, "Number Of Grace Days (90)");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Spec Program Indicator (44)");
                this.add(typeof(ID), false, 1, 60, new System.Object[] { message, 0 }, "PSRO/UR Approval Indicator (87)");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "PSRO/UR Approved Stay Fm (88)");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "PSRO/UR Approved Stay To (89)");
                this.add(typeof(CM_OCD), false, 5, 20, new System.Object[] { message }, "Occurrence (28 32)");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 0 }, "Occurrence Span (33)");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Occur Span Start Date(33)");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Occur Span End Date (33)");
                this.add(typeof(ST), false, 1, 30, new System.Object[] { message }, "UB 82 Locator 2");
                this.add(typeof(ST), false, 1, 7, new System.Object[] { message }, "UB 82 Locator 9");
                this.add(typeof(ST), false, 1, 8, new System.Object[] { message }, "UB 82 Locator 27");
                this.add(typeof(ST), false, 1, 17, new System.Object[] { message }, "UB 82 Locator 45");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Set ID - UB1(UB1-1).
        ///</summary>
        public SI SetIDUB1
        {
            get
            {
                SI ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
                    ret = (SI)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Blood Deductible  (43)(UB1-2).
        ///</summary>
        public NM BloodDeductible
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
                    ret = (NM)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Blood Furnished Pints Of (40)(UB1-3).
        ///</summary>
        public NM BloodFurnishedPintsOf
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
                    ret = (NM)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Blood Replaced Pints (41)(UB1-4).
        ///</summary>
        public NM BloodReplacedPints
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
                    ret = (NM)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Blood Not Replaced Pints(42)(UB1-5).
        ///</summary>
        public NM BloodNotReplacedPints
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
                    ret = (NM)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Co Insurance Days (25)(UB1-6).
        ///</summary>
        public NM CoInsuranceDays
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
                    ret = (NM)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns a single repetition of Condition Code (35-39)(UB1-7).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public IS getConditionCode3539(int rep)
        {
            IS ret = null;
            try
            {
                IType t = this.GetField(7, rep);
                ret = (IS)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Condition Code (35-39) (UB1-7).
        ///</summary>
        public IS[] getConditionCode3539()
        {
            IS[] ret = null;
            try
            {
                IType[] t = this.GetField(7);
                ret = new IS[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (IS)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }

        ///<summary>
        /// Returns Covered Days   (23)(UB1-8).
        ///</summary>
        public NM CoveredDays
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
                    ret = (NM)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Non Covered Days   (24)(UB1-9).
        ///</summary>
        public NM NonCoveredDays
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
                    ret = (NM)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns a single repetition of Value Amount and Code (46-49)(UB1-10).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_UVC getValueAmountCode4649(int rep)
        {
            CM_UVC ret = null;
            try
            {
                IType t = this.GetField(10, rep);
                ret = (CM_UVC)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Value Amount and Code (46-49) (UB1-10).
        ///</summary>
        public CM_UVC[] getValueAmountCode4649()
        {
            CM_UVC[] ret = null;
            try
            {
                IType[] t = this.GetField(10);
                ret = new CM_UVC[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_UVC)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }

        ///<summary>
        /// Returns Number Of Grace Days (90)(UB1-11).
        ///</summary>
        public NM NumberOfGraceDays
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
                    ret = (NM)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Spec Program Indicator (44)(UB1-12).
        ///</summary>
        public CE SpecProgramIndicator
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
                    ret = (CE)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PSRO/UR Approval Indicator (87)(UB1-13).
        ///</summary>
        public ID PSROURApprovalIndicator
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(13, 0);
                    ret = (ID)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PSRO/UR Approved Stay Fm (88)(UB1-14).
        ///</summary>
        public DT PSROURApprovedStayFm
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(14, 0);
                    ret = (DT)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PSRO/UR Approved Stay To (89)(UB1-15).
        ///</summary>
        public DT PSROURApprovedStayTo
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(15, 0);
                    ret = (DT)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns a single repetition of Occurrence (28 32)(UB1-16).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_OCD getOccurrence2832(int rep)
        {
            CM_OCD ret = null;
            try
            {
                IType t = this.GetField(16, rep);
                ret = (CM_OCD)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Occurrence (28 32) (UB1-16).
        ///</summary>
        public CM_OCD[] getOccurrence2832()
        {
            CM_OCD[] ret = null;
            try
            {
                IType[] t = this.GetField(16);
                ret = new CM_OCD[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_OCD)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }

        ///<summary>
        /// Returns Occurrence Span (33)(UB1-17).
        ///</summary>
        public ID OccurrenceSpan
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(17, 0);
                    ret = (ID)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Occur Span Start Date(33)(UB1-18).
        ///</summary>
        public DT OccurSpanStartDate
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(18, 0);
                    ret = (DT)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Occur Span End Date (33)(UB1-19).
        ///</summary>
        public DT OccurSpanEndDate
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(19, 0);
                    ret = (DT)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns UB 82 Locator 2(UB1-20).
        ///</summary>
        public ST UB82Locator2
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(20, 0);
                    ret = (ST)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns UB 82 Locator 9(UB1-21).
        ///</summary>
        public ST UB82Locator9
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(21, 0);
                    ret = (ST)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns UB 82 Locator 27(UB1-22).
        ///</summary>
        public ST UB82Locator27
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(22, 0);
                    ret = (ST)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns UB 82 Locator 45(UB1-23).
        ///</summary>
        public ST UB82Locator45
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(23, 0);
                    ret = (ST)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }


    }
}