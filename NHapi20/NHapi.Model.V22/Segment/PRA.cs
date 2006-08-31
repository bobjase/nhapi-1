using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 PRA message segment. 
    /// This segment has the following fields:
    /// * PRA-1: PRA - primary key value (ST)
    /// * PRA-2: Practitioner group (CE)
    /// * PRA-3: Practitioner Category (ID)
    /// * PRA-4: Provider Billing (ID)
    /// * PRA-5: Specialty (CM_SPD)
    /// * PRA-6: Practitioner ID Numbers (CM_PLN)
    /// * PRA-7: Privileges (CM_PIP)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class PRA : AbstractSegment
    {

        /**
         * Creates a PRA (practitioner detail) segment object that belongs to the given 
         * message.  
         */
        public PRA(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ST), true, 1, 20, new System.Object[] { message }, "PRA - primary key value");
                this.add(typeof(CE), false, 0, 60, new System.Object[] { message }, "Practitioner group");
                this.add(typeof(ID), false, 0, 3, new System.Object[] { message, 186 }, "Practitioner Category");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 187 }, "Provider Billing");
                this.add(typeof(CM_SPD), false, 0, 100, new System.Object[] { message }, "Specialty");
                this.add(typeof(CM_PLN), false, 0, 100, new System.Object[] { message }, "Practitioner ID Numbers");
                this.add(typeof(CM_PIP), false, 0, 20, new System.Object[] { message }, "Privileges");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns PRA - primary key value(PRA-1).
        ///</summary>
        public ST PRAPrimaryKeyValue
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
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
        /// Returns a single repetition of Practitioner group(PRA-2).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getPractitionerGroup(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(2, rep);
                ret = (CE)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Practitioner group (PRA-2).
        ///</summary>
        public CE[] getPractitionerGroup()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(2);
                ret = new CE[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CE)t[i];
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
        /// Returns a single repetition of Practitioner Category(PRA-3).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getPractitionerCategory(int rep)
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
        /// Returns all repetitions of Practitioner Category (PRA-3).
        ///</summary>
        public ID[] getPractitionerCategory()
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
        /// Returns Provider Billing(PRA-4).
        ///</summary>
        public ID ProviderBilling
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
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
        /// Returns a single repetition of Specialty(PRA-5).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_SPD getSpecialty(int rep)
        {
            CM_SPD ret = null;
            try
            {
                IType t = this.GetField(5, rep);
                ret = (CM_SPD)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Specialty (PRA-5).
        ///</summary>
        public CM_SPD[] getSpecialty()
        {
            CM_SPD[] ret = null;
            try
            {
                IType[] t = this.GetField(5);
                ret = new CM_SPD[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_SPD)t[i];
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
        /// Returns a single repetition of Practitioner ID Numbers(PRA-6).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_PLN getPractitionerIDNumbers(int rep)
        {
            CM_PLN ret = null;
            try
            {
                IType t = this.GetField(6, rep);
                ret = (CM_PLN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Practitioner ID Numbers (PRA-6).
        ///</summary>
        public CM_PLN[] getPractitionerIDNumbers()
        {
            CM_PLN[] ret = null;
            try
            {
                IType[] t = this.GetField(6);
                ret = new CM_PLN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_PLN)t[i];
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
        /// Returns a single repetition of Privileges(PRA-7).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_PIP getPrivileges(int rep)
        {
            CM_PIP ret = null;
            try
            {
                IType t = this.GetField(7, rep);
                ret = (CM_PIP)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Privileges (PRA-7).
        ///</summary>
        public CM_PIP[] getPrivileges()
        {
            CM_PIP[] ret = null;
            try
            {
                IType[] t = this.GetField(7);
                ret = new CM_PIP[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_PIP)t[i];
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