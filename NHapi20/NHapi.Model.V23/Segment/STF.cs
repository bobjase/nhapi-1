using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 STF message segment. 
    /// This segment has the following fields:
    /// * STF-1: STF - Primary Key Value (CE)
    /// * STF-2: Staff ID Code (CE)
    /// * STF-3: Staff Name (XPN)
    /// * STF-4: Staff Type (ID)
    /// * STF-5: Sex (IS)
    /// * STF-6: Date of Birth (TS)
    /// * STF-7: Active/Inactive Flag (ID)
    /// * STF-8: Department (CE)
    /// * STF-9: Service (CE)
    /// * STF-10: Phone (TN)
    /// * STF-11: Office/Home Address (AD)
    /// * STF-12: Activation Date (CM_DIN)
    /// * STF-13: Inactivation Date (CM_DIN)
    /// * STF-14: Backup Person ID (CE)
    /// * STF-15: E-mail Address (ST)
    /// * STF-16: Preferred Method of Contact (CE)
    /// * STF-17: Marital Status (IS)
    /// * STF-18: Job Title (ST)
    /// * STF-19: Job Code/Class (JCC)
    /// * STF-20: Employment Status (IS)
    /// * STF-21: Additional Insured on Auto (ID)
    /// * STF-22: Driver's License Number (DLN)
    /// * STF-23: Copy Auto Ins (ID)
    /// * STF-24: Auto Ins. Expires (DT)
    /// * STF-25: Date Last DMV Review (DT)
    /// * STF-26: Date Next DMV Review (DT)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class STF : AbstractSegment
    {

        /**
         * Creates a STF (Staff identification segment) segment object that belongs to the given 
         * message.  
         */
        public STF(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(CE), true, 1, 60, new System.Object[] { message }, "STF - Primary Key Value");
                this.add(typeof(CE), false, 0, 60, new System.Object[] { message }, "Staff ID Code");
                this.add(typeof(XPN), false, 1, 48, new System.Object[] { message }, "Staff Name");
                this.add(typeof(ID), false, 0, 2, new System.Object[] { message, 182 }, "Staff Type");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 1 }, "Sex");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Date of Birth");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 183 }, "Active/Inactive Flag");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Department");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Service");
                this.add(typeof(TN), false, 0, 40, new System.Object[] { message }, "Phone");
                this.add(typeof(AD), false, 2, 106, new System.Object[] { message }, "Office/Home Address");
                this.add(typeof(CM_DIN), false, 0, 26, new System.Object[] { message }, "Activation Date");
                this.add(typeof(CM_DIN), false, 0, 26, new System.Object[] { message }, "Inactivation Date");
                this.add(typeof(CE), false, 0, 60, new System.Object[] { message }, "Backup Person ID");
                this.add(typeof(ST), false, 0, 40, new System.Object[] { message }, "E-mail Address");
                this.add(typeof(CE), false, 1, 200, new System.Object[] { message }, "Preferred Method of Contact");
                this.add(typeof(IS), false, 0, 1, new System.Object[] { message, 2 }, "Marital Status");
                this.add(typeof(ST), false, 1, 20, new System.Object[] { message }, "Job Title");
                this.add(typeof(JCC), false, 1, 20, new System.Object[] { message }, "Job Code/Class");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 66 }, "Employment Status");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 136 }, "Additional Insured on Auto");
                this.add(typeof(DLN), false, 1, 25, new System.Object[] { message }, "Driver's License Number");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 136 }, "Copy Auto Ins");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Auto Ins. Expires");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Date Last DMV Review");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Date Next DMV Review");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns STF - Primary Key Value(STF-1).
        ///</summary>
        public CE STFPrimaryKeyValue
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
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
        /// Returns a single repetition of Staff ID Code(STF-2).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getStaffIDCode(int rep)
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
        /// Returns all repetitions of Staff ID Code (STF-2).
        ///</summary>
        public CE[] getStaffIDCode()
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
        /// Returns Staff Name(STF-3).
        ///</summary>
        public XPN StaffName
        {
            get
            {
                XPN ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
                    ret = (XPN)t;
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
        /// Returns a single repetition of Staff Type(STF-4).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getStaffType(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(4, rep);
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
        /// Returns all repetitions of Staff Type (STF-4).
        ///</summary>
        public ID[] getStaffType()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(4);
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
        /// Returns Sex(STF-5).
        ///</summary>
        public IS Sex
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
                    ret = (IS)t;
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
        /// Returns Date of Birth(STF-6).
        ///</summary>
        public TS DateOfBirth
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
        /// Returns Active/Inactive Flag(STF-7).
        ///</summary>
        public ID ActiveInactiveFlag
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
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
        /// Returns a single repetition of Department(STF-8).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getDepartment(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(8, rep);
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
        /// Returns all repetitions of Department (STF-8).
        ///</summary>
        public CE[] getDepartment()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(8);
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
        /// Returns a single repetition of Service(STF-9).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getService(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(9, rep);
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
        /// Returns all repetitions of Service (STF-9).
        ///</summary>
        public CE[] getService()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(9);
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
        /// Returns a single repetition of Phone(STF-10).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public TN getPhone(int rep)
        {
            TN ret = null;
            try
            {
                IType t = this.GetField(10, rep);
                ret = (TN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Phone (STF-10).
        ///</summary>
        public TN[] getPhone()
        {
            TN[] ret = null;
            try
            {
                IType[] t = this.GetField(10);
                ret = new TN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (TN)t[i];
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
        /// Returns a single repetition of Office/Home Address(STF-11).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public AD getOfficeHomeAddress(int rep)
        {
            AD ret = null;
            try
            {
                IType t = this.GetField(11, rep);
                ret = (AD)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Office/Home Address (STF-11).
        ///</summary>
        public AD[] getOfficeHomeAddress()
        {
            AD[] ret = null;
            try
            {
                IType[] t = this.GetField(11);
                ret = new AD[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (AD)t[i];
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
        /// Returns a single repetition of Activation Date(STF-12).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_DIN getActivationDate(int rep)
        {
            CM_DIN ret = null;
            try
            {
                IType t = this.GetField(12, rep);
                ret = (CM_DIN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Activation Date (STF-12).
        ///</summary>
        public CM_DIN[] getActivationDate()
        {
            CM_DIN[] ret = null;
            try
            {
                IType[] t = this.GetField(12);
                ret = new CM_DIN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_DIN)t[i];
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
        /// Returns a single repetition of Inactivation Date(STF-13).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_DIN getInactivationDate(int rep)
        {
            CM_DIN ret = null;
            try
            {
                IType t = this.GetField(13, rep);
                ret = (CM_DIN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Inactivation Date (STF-13).
        ///</summary>
        public CM_DIN[] getInactivationDate()
        {
            CM_DIN[] ret = null;
            try
            {
                IType[] t = this.GetField(13);
                ret = new CM_DIN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_DIN)t[i];
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
        /// Returns a single repetition of Backup Person ID(STF-14).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getBackupPersonID(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(14, rep);
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
        /// Returns all repetitions of Backup Person ID (STF-14).
        ///</summary>
        public CE[] getBackupPersonID()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(14);
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
        /// Returns a single repetition of E-mail Address(STF-15).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getEMailAddress(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(15, rep);
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
        /// Returns all repetitions of E-mail Address (STF-15).
        ///</summary>
        public ST[] getEMailAddress()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(15);
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
        /// Returns Preferred Method of Contact(STF-16).
        ///</summary>
        public CE PreferredMethodOfContact
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(16, 0);
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
        /// Returns a single repetition of Marital Status(STF-17).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public IS getMaritalStatus(int rep)
        {
            IS ret = null;
            try
            {
                IType t = this.GetField(17, rep);
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
        /// Returns all repetitions of Marital Status (STF-17).
        ///</summary>
        public IS[] getMaritalStatus()
        {
            IS[] ret = null;
            try
            {
                IType[] t = this.GetField(17);
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
        /// Returns Job Title(STF-18).
        ///</summary>
        public ST JobTitle
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(18, 0);
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
        /// Returns Job Code/Class(STF-19).
        ///</summary>
        public JCC JobCodeClass
        {
            get
            {
                JCC ret = null;
                try
                {
                    IType t = this.GetField(19, 0);
                    ret = (JCC)t;
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
        /// Returns Employment Status(STF-20).
        ///</summary>
        public IS EmploymentStatus
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(20, 0);
                    ret = (IS)t;
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
        /// Returns Additional Insured on Auto(STF-21).
        ///</summary>
        public ID AdditionalInsuredOnAuto
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(21, 0);
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
        /// Returns Driver's License Number(STF-22).
        ///</summary>
        public DLN DriverSLicenseNumber
        {
            get
            {
                DLN ret = null;
                try
                {
                    IType t = this.GetField(22, 0);
                    ret = (DLN)t;
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
        /// Returns Copy Auto Ins(STF-23).
        ///</summary>
        public ID CopyAutoIns
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(23, 0);
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
        /// Returns Auto Ins. Expires(STF-24).
        ///</summary>
        public DT AutoInsExpires
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(24, 0);
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
        /// Returns Date Last DMV Review(STF-25).
        ///</summary>
        public DT DateLastDMVReview
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(25, 0);
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
        /// Returns Date Next DMV Review(STF-26).
        ///</summary>
        public DT DateNextDMVReview
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(26, 0);
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


    }
}