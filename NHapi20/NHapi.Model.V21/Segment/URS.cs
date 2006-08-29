using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment
{

    ///<summary>
    /// Represents an HL7 URS message segment. 
    /// This segment has the following fields:
    /// * URS-1: R/U WHERE SUBJECT DEFINITION (ST)
    /// * URS-2: R/U WHEN DATA START DATE/TIME (TS)
    /// * URS-3: R/U WHEN DATA END DATE/TIME (TS)
    /// * URS-4: R/U WHAT USER QUALIFIER (ST)
    /// * URS-5: R/U OTHER RESULTS SUBJECT DEFINI (ST)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class URS : AbstractSegment
    {

        /**
         * Creates a URS (UNSOLICITED SELECTION) segment object that belongs to the given 
         * message.  
         */
        public URS(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ST), true, 0, 20, new System.Object[] { message }, "R/U WHERE SUBJECT DEFINITION");
                this.add(typeof(TS), false, 1, 19, new System.Object[] { message }, "R/U WHEN DATA START DATE/TIME");
                this.add(typeof(TS), false, 1, 19, new System.Object[] { message }, "R/U WHEN DATA END DATE/TIME");
                this.add(typeof(ST), false, 0, 20, new System.Object[] { message }, "R/U WHAT USER QUALIFIER");
                this.add(typeof(ST), false, 0, 20, new System.Object[] { message }, "R/U OTHER RESULTS SUBJECT DEFINI");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns a single repetition of R/U WHERE SUBJECT DEFINITION(URS-1).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getRUWHERESUBJECTDEFINITION(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(1, rep);
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
        /// Returns all repetitions of R/U WHERE SUBJECT DEFINITION (URS-1).
        ///</summary>
        public ST[] getRUWHERESUBJECTDEFINITION()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(1);
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
        /// Returns R/U WHEN DATA START DATE/TIME(URS-2).
        ///</summary>
        public TS RUWHENDATASTARTDATETIME
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns R/U WHEN DATA END DATE/TIME(URS-3).
        ///</summary>
        public TS RUWHENDATAENDDATETIME
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
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
        /// Returns a single repetition of R/U WHAT USER QUALIFIER(URS-4).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getRUWHATUSERQUALIFIER(int rep)
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
        /// Returns all repetitions of R/U WHAT USER QUALIFIER (URS-4).
        ///</summary>
        public ST[] getRUWHATUSERQUALIFIER()
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
        /// Returns a single repetition of R/U OTHER RESULTS SUBJECT DEFINI(URS-5).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getRUOTHERRESULTSSUBJECTDEFINI(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(5, rep);
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
        /// Returns all repetitions of R/U OTHER RESULTS SUBJECT DEFINI (URS-5).
        ///</summary>
        public ST[] getRUOTHERRESULTSSUBJECTDEFINI()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(5);
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


    }
}