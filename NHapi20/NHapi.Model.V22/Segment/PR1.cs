using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 PR1 message segment. 
    /// This segment has the following fields:
    /// * PR1-1: Set ID - procedure (SI)
    /// * PR1-2: Procedure coding method (ID)
    /// * PR1-3: Procedure code (ID)
    /// * PR1-4: Procedure description (ST)
    /// * PR1-5: Procedure date / time (TS)
    /// * PR1-6: Procedure type (ID)
    /// * PR1-7: Procedure minutes (NM)
    /// * PR1-8: Anesthesiologist (CN_PERSON)
    /// * PR1-9: Anesthesia code (ID)
    /// * PR1-10: Anesthesia minutes (NM)
    /// * PR1-11: Surgeon (CN_PERSON)
    /// * PR1-12: Procedure Practitioner (CM_PRACTITIONER)
    /// * PR1-13: Consent code (ID)
    /// * PR1-14: Procedure priority (NM)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class PR1 : AbstractSegment
    {

        /**
         * Creates a PR1 (PROCEDURES) segment object that belongs to the given 
         * message.  
         */
        public PR1(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(SI), true, 1, 4, new System.Object[] { message }, "Set ID - procedure");
                this.add(typeof(ID), true, 0, 2, new System.Object[] { message, 89 }, "Procedure coding method");
                this.add(typeof(ID), true, 0, 10, new System.Object[] { message, 88 }, "Procedure code");
                this.add(typeof(ST), false, 0, 40, new System.Object[] { message }, "Procedure description");
                this.add(typeof(TS), true, 1, 26, new System.Object[] { message }, "Procedure date / time");
                this.add(typeof(ID), true, 1, 2, new System.Object[] { message, 90 }, "Procedure type");
                this.add(typeof(NM), false, 1, 4, new System.Object[] { message }, "Procedure minutes");
                this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[] { message }, "Anesthesiologist");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 19 }, "Anesthesia code");
                this.add(typeof(NM), false, 1, 4, new System.Object[] { message }, "Anesthesia minutes");
                this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[] { message }, "Surgeon");
                this.add(typeof(CM_PRACTITIONER), false, 0, 60, new System.Object[] { message }, "Procedure Practitioner");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 59 }, "Consent code");
                this.add(typeof(NM), false, 1, 2, new System.Object[] { message }, "Procedure priority");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Set ID - procedure(PR1-1).
        ///</summary>
        public SI SetIDProcedure
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
        /// Returns a single repetition of Procedure coding method(PR1-2).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getProcedureCodingMethod(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(2, rep);
                ret = (ID)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Procedure coding method (PR1-2).
        ///</summary>
        public ID[] getProcedureCodingMethod()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(2);
                ret = new ID[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ID)t[i];
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
        /// Returns a single repetition of Procedure code(PR1-3).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getProcedureCode(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(3, rep);
                ret = (ID)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Procedure code (PR1-3).
        ///</summary>
        public ID[] getProcedureCode()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(3);
                ret = new ID[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ID)t[i];
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
        /// Returns a single repetition of Procedure description(PR1-4).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getProcedureDescription(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(4, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Procedure description (PR1-4).
        ///</summary>
        public ST[] getProcedureDescription()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(4);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
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
        /// Returns Procedure date / time(PR1-5).
        ///</summary>
        public TS ProcedureDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
                    ret = (TS)t;
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
        /// Returns Procedure type(PR1-6).
        ///</summary>
        public ID ProcedureType
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns Procedure minutes(PR1-7).
        ///</summary>
        public NM ProcedureMinutes
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
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
        /// Returns Anesthesiologist(PR1-8).
        ///</summary>
        public CN_PERSON Anesthesiologist
        {
            get
            {
                CN_PERSON ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
                    ret = (CN_PERSON)t;
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
        /// Returns Anesthesia code(PR1-9).
        ///</summary>
        public ID AnesthesiaCode
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
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
        /// Returns Anesthesia minutes(PR1-10).
        ///</summary>
        public NM AnesthesiaMinutes
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(10, 0);
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
        /// Returns Surgeon(PR1-11).
        ///</summary>
        public CN_PERSON Surgeon
        {
            get
            {
                CN_PERSON ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
                    ret = (CN_PERSON)t;
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
        /// Returns a single repetition of Procedure Practitioner(PR1-12).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_PRACTITIONER getProcedurePractitioner(int rep)
        {
            CM_PRACTITIONER ret = null;
            try
            {
                IType t = this.GetField(12, rep);
                ret = (CM_PRACTITIONER)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Procedure Practitioner (PR1-12).
        ///</summary>
        public CM_PRACTITIONER[] getProcedurePractitioner()
        {
            CM_PRACTITIONER[] ret = null;
            try
            {
                IType[] t = this.GetField(12);
                ret = new CM_PRACTITIONER[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_PRACTITIONER)t[i];
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
        /// Returns Consent code(PR1-13).
        ///</summary>
        public ID ConsentCode
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
        /// Returns Procedure priority(PR1-14).
        ///</summary>
        public NM ProcedurePriority
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(14, 0);
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


    }
}