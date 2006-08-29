using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment
{

    ///<summary>
    /// Represents an HL7 QRD message segment. 
    /// This segment has the following fields:
    /// * QRD-1: QUERY DATE/TIME (TS)
    /// * QRD-2: QUERY FORMAT CODE (ID)
    /// * QRD-3: QUERY PRIORITY (ID)
    /// * QRD-4: QUERY ID (ST)
    /// * QRD-5: DEFERRED RESPONSE TYPE (ID)
    /// * QRD-6: DEFERRED RESPONSE DATE/TIME (TS)
    /// * QRD-7: QUANTITY LIMITED REQUEST (CQ)
    /// * QRD-8: WHO SUBJECT FILTER (ST)
    /// * QRD-9: WHAT SUBJECT FILTER (ID)
    /// * QRD-10: WHAT DEPARTMENT DATA CODE (ST)
    /// * QRD-11: WHAT DATA CODE VALUE QUAL. (ST)
    /// * QRD-12: QUERY RESULTS LEVEL (ID)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class QRD : AbstractSegment
    {

        /**
         * Creates a QRD (QUERY DEFINITION) segment object that belongs to the given 
         * message.  
         */
        public QRD(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(TS), true, 1, 19, new System.Object[] { message }, "QUERY DATE/TIME");
                this.add(typeof(ID), true, 1, 1, new System.Object[] { message, 106 }, "QUERY FORMAT CODE");
                this.add(typeof(ID), true, 1, 1, new System.Object[] { message, 91 }, "QUERY PRIORITY");
                this.add(typeof(ST), true, 1, 10, new System.Object[] { message }, "QUERY ID");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 107 }, "DEFERRED RESPONSE TYPE");
                this.add(typeof(TS), false, 1, 19, new System.Object[] { message }, "DEFERRED RESPONSE DATE/TIME");
                this.add(typeof(CQ), true, 1, 5, new System.Object[] { message }, "QUANTITY LIMITED REQUEST");
                this.add(typeof(ST), true, 0, 20, new System.Object[] { message }, "WHO SUBJECT FILTER");
                this.add(typeof(ID), true, 0, 3, new System.Object[] { message, 48 }, "WHAT SUBJECT FILTER");
                this.add(typeof(ST), true, 0, 20, new System.Object[] { message }, "WHAT DEPARTMENT DATA CODE");
                this.add(typeof(ST), false, 0, 20, new System.Object[] { message }, "WHAT DATA CODE VALUE QUAL.");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 108 }, "QUERY RESULTS LEVEL");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns QUERY DATE/TIME(QRD-1).
        ///</summary>
        public TS QUERYDATETIME
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
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
        /// Returns QUERY FORMAT CODE(QRD-2).
        ///</summary>
        public ID QUERYFORMATCODE
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns QUERY PRIORITY(QRD-3).
        ///</summary>
        public ID QUERYPRIORITY
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
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
        /// Returns QUERY ID(QRD-4).
        ///</summary>
        public ST QUERYID
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
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
        /// Returns DEFERRED RESPONSE TYPE(QRD-5).
        ///</summary>
        public ID DEFERREDRESPONSETYPE
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
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
        /// Returns DEFERRED RESPONSE DATE/TIME(QRD-6).
        ///</summary>
        public TS DEFERREDRESPONSEDATETIME
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns QUANTITY LIMITED REQUEST(QRD-7).
        ///</summary>
        public CQ QUANTITYLIMITEDREQUEST
        {
            get
            {
                CQ ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
                    ret = (CQ)t;
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
        /// Returns a single repetition of WHO SUBJECT FILTER(QRD-8).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getWHOSUBJECTFILTER(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(8, rep);
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
        /// Returns all repetitions of WHO SUBJECT FILTER (QRD-8).
        ///</summary>
        public ST[] getWHOSUBJECTFILTER()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(8);
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
        /// Returns a single repetition of WHAT SUBJECT FILTER(QRD-9).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getWHATSUBJECTFILTER(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(9, rep);
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
        /// Returns all repetitions of WHAT SUBJECT FILTER (QRD-9).
        ///</summary>
        public ID[] getWHATSUBJECTFILTER()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(9);
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
        /// Returns a single repetition of WHAT DEPARTMENT DATA CODE(QRD-10).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getWHATDEPARTMENTDATACODE(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(10, rep);
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
        /// Returns all repetitions of WHAT DEPARTMENT DATA CODE (QRD-10).
        ///</summary>
        public ST[] getWHATDEPARTMENTDATACODE()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(10);
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
        /// Returns a single repetition of WHAT DATA CODE VALUE QUAL.(QRD-11).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getWHATDATACODEVALUEQUAL(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(11, rep);
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
        /// Returns all repetitions of WHAT DATA CODE VALUE QUAL. (QRD-11).
        ///</summary>
        public ST[] getWHATDATACODEVALUEQUAL()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(11);
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
        /// Returns QUERY RESULTS LEVEL(QRD-12).
        ///</summary>
        public ID QUERYRESULTSLEVEL
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
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


    }
}