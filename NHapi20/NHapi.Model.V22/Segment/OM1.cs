using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 OM1 message segment. 
    /// This segment has the following fields:
    /// * OM1-1: Segment Type ID (ST)
    /// * OM1-2: Sequence Number - Test/ Observation Master File (NM)
    /// * OM1-3: Producer's test / observation ID (CE)
    /// * OM1-4: Permitted Data Types (ID)
    /// * OM1-5: Specimen Required (ID)
    /// * OM1-6: Producer ID (CE)
    /// * OM1-7: Observation Description (TX)
    /// * OM1-8: Other test / observation IDs for the observation (CE)
    /// * OM1-9: Other Names (ST)
    /// * OM1-10: Preferred Report Name for the Observation (ST)
    /// * OM1-11: Preferred Short Name or Mnemonic for Observation (ST)
    /// * OM1-12: Preferred Long Name for the Observation (ST)
    /// * OM1-13: Orderability (ID)
    /// * OM1-14: Identity of instrument used to perform this study (CE)
    /// * OM1-15: Coded Representation of Method (CE)
    /// * OM1-16: Portable (ID)
    /// * OM1-17: Observation producing department / section (ID)
    /// * OM1-18: Telephone Number of Section (TN)
    /// * OM1-19: Nature of test / observation (ID)
    /// * OM1-20: Report Subheader (CE)
    /// * OM1-21: Report Display Order (ST)
    /// * OM1-22: Date / time stamp for any change in definition for obs (TS)
    /// * OM1-23: Effective date / time of change (TS)
    /// * OM1-24: Typical Turn-around Time (NM)
    /// * OM1-25: Processing Time (NM)
    /// * OM1-26: Processing Priority (ID)
    /// * OM1-27: Reporting Priority (ID)
    /// * OM1-28: Outside Site(s) Where Observation may be Performed (CE)
    /// * OM1-29: Address of Outside Site(s) (AD)
    /// * OM1-30: Phone Number of Outside Site (TN)
    /// * OM1-31: Confidentiality Code (ID)
    /// * OM1-32: Observations required to interpret the observation (CE)
    /// * OM1-33: Interpretation of Observations (TX)
    /// * OM1-34: Contraindications to Observations (CE)
    /// * OM1-35: Reflex tests / observations (CE)
    /// * OM1-36: Rules that Trigger Reflex Testing (ST)
    /// * OM1-37: Fixed Canned Message (CE)
    /// * OM1-38: Patient Preparation (TX)
    /// * OM1-39: Procedure Medication (CE)
    /// * OM1-40: Factors that may affect the observation (TX)
    /// * OM1-41: Test / observation performance schedule (ST)
    /// * OM1-42: Description of Test Methods (TX)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class OM1 : AbstractSegment
    {

        /**
         * Creates a OM1 (GENERAL - fields that apply to most observations) segment object that belongs to the given 
         * message.  
         */
        public OM1(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ST), false, 1, 3, new System.Object[] { message }, "Segment Type ID");
                this.add(typeof(NM), false, 1, 4, new System.Object[] { message }, "Sequence Number - Test/ Observation Master File");
                this.add(typeof(CE), true, 1, 200, new System.Object[] { message }, "Producer's test / observation ID");
                this.add(typeof(ID), false, 0, 12, new System.Object[] { message, 125 }, "Permitted Data Types");
                this.add(typeof(ID), true, 1, 1, new System.Object[] { message, 136 }, "Specimen Required");
                this.add(typeof(CE), true, 1, 200, new System.Object[] { message }, "Producer ID");
                this.add(typeof(TX), false, 1, 200, new System.Object[] { message }, "Observation Description");
                this.add(typeof(CE), false, 1, 200, new System.Object[] { message }, "Other test / observation IDs for the observation");
                this.add(typeof(ST), true, 0, 200, new System.Object[] { message }, "Other Names");
                this.add(typeof(ST), false, 1, 30, new System.Object[] { message }, "Preferred Report Name for the Observation");
                this.add(typeof(ST), false, 1, 8, new System.Object[] { message }, "Preferred Short Name or Mnemonic for Observation");
                this.add(typeof(ST), false, 1, 200, new System.Object[] { message }, "Preferred Long Name for the Observation");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 136 }, "Orderability");
                this.add(typeof(CE), false, 0, 60, new System.Object[] { message }, "Identity of instrument used to perform this study");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Coded Representation of Method");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 136 }, "Portable");
                this.add(typeof(ID), false, 0, 1, new System.Object[] { message, 0 }, "Observation producing department / section");
                this.add(typeof(TN), false, 1, 40, new System.Object[] { message }, "Telephone Number of Section");
                this.add(typeof(ID), true, 1, 1, new System.Object[] { message, 174 }, "Nature of test / observation");
                this.add(typeof(CE), false, 1, 200, new System.Object[] { message }, "Report Subheader");
                this.add(typeof(ST), false, 1, 20, new System.Object[] { message }, "Report Display Order");
                this.add(typeof(TS), true, 1, 26, new System.Object[] { message }, "Date / time stamp for any change in definition for obs");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Effective date / time of change");
                this.add(typeof(NM), false, 1, 20, new System.Object[] { message }, "Typical Turn-around Time");
                this.add(typeof(NM), false, 1, 20, new System.Object[] { message }, "Processing Time");
                this.add(typeof(ID), false, 0, 40, new System.Object[] { message, 168 }, "Processing Priority");
                this.add(typeof(ID), false, 1, 5, new System.Object[] { message, 169 }, "Reporting Priority");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Outside Site(s) Where Observation may be Performed");
                this.add(typeof(AD), false, 0, 1000, new System.Object[] { message }, "Address of Outside Site(s)");
                this.add(typeof(TN), false, 0, 400, new System.Object[] { message }, "Phone Number of Outside Site");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 177 }, "Confidentiality Code");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Observations required to interpret the observation");
                this.add(typeof(TX), false, 1, 65536, new System.Object[] { message }, "Interpretation of Observations");
                this.add(typeof(CE), false, 0, 65536, new System.Object[] { message }, "Contraindications to Observations");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Reflex tests / observations");
                this.add(typeof(ST), false, 1, 80, new System.Object[] { message }, "Rules that Trigger Reflex Testing");
                this.add(typeof(CE), false, 0, 65536, new System.Object[] { message }, "Fixed Canned Message");
                this.add(typeof(TX), false, 1, 200, new System.Object[] { message }, "Patient Preparation");
                this.add(typeof(CE), false, 1, 200, new System.Object[] { message }, "Procedure Medication");
                this.add(typeof(TX), false, 1, 200, new System.Object[] { message }, "Factors that may affect the observation");
                this.add(typeof(ST), false, 0, 60, new System.Object[] { message }, "Test / observation performance schedule");
                this.add(typeof(TX), false, 1, 65536, new System.Object[] { message }, "Description of Test Methods");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Segment Type ID(OM1-1).
        ///</summary>
        public ST SegmentTypeID
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
        /// Returns Sequence Number - Test/ Observation Master File(OM1-2).
        ///</summary>
        public NM SequenceNumberTestObservationMasterFile
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
        /// Returns Producer's test / observation ID(OM1-3).
        ///</summary>
        public CE ProducerSTestObservationID
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
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
        /// Returns a single repetition of Permitted Data Types(OM1-4).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getPermittedDataTypes(int rep)
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
        /// Returns all repetitions of Permitted Data Types (OM1-4).
        ///</summary>
        public ID[] getPermittedDataTypes()
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
        /// Returns Specimen Required(OM1-5).
        ///</summary>
        public ID SpecimenRequired
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
        /// Returns Producer ID(OM1-6).
        ///</summary>
        public CE ProducerID
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns Observation Description(OM1-7).
        ///</summary>
        public TX ObservationDescription
        {
            get
            {
                TX ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
                    ret = (TX)t;
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
        /// Returns Other test / observation IDs for the observation(OM1-8).
        ///</summary>
        public CE OtherTestObservationIDsForTheObservation
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
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
        /// Returns a single repetition of Other Names(OM1-9).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getOtherNames(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(9, rep);
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
        /// Returns all repetitions of Other Names (OM1-9).
        ///</summary>
        public ST[] getOtherNames()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(9);
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
        /// Returns Preferred Report Name for the Observation(OM1-10).
        ///</summary>
        public ST PreferredReportNameForTheObservation
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(10, 0);
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
        /// Returns Preferred Short Name or Mnemonic for Observation(OM1-11).
        ///</summary>
        public ST PreferredShortNameOrMnemonicForObservation
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
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
        /// Returns Preferred Long Name for the Observation(OM1-12).
        ///</summary>
        public ST PreferredLongNameForTheObservation
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
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
        /// Returns Orderability(OM1-13).
        ///</summary>
        public ID Orderability
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
        /// Returns a single repetition of Identity of instrument used to perform this study(OM1-14).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getIdentityOfInstrumentUsedToPerformThisStudy(int rep)
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
        /// Returns all repetitions of Identity of instrument used to perform this study (OM1-14).
        ///</summary>
        public CE[] getIdentityOfInstrumentUsedToPerformThisStudy()
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
        /// Returns a single repetition of Coded Representation of Method(OM1-15).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getCodedRepresentationOfMethod(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(15, rep);
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
        /// Returns all repetitions of Coded Representation of Method (OM1-15).
        ///</summary>
        public CE[] getCodedRepresentationOfMethod()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(15);
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
        /// Returns Portable(OM1-16).
        ///</summary>
        public ID Portable
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(16, 0);
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
        /// Returns a single repetition of Observation producing department / section(OM1-17).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getObservationProducingDepartmentSection(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(17, rep);
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
        /// Returns all repetitions of Observation producing department / section (OM1-17).
        ///</summary>
        public ID[] getObservationProducingDepartmentSection()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(17);
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
        /// Returns Telephone Number of Section(OM1-18).
        ///</summary>
        public TN TelephoneNumberOfSection
        {
            get
            {
                TN ret = null;
                try
                {
                    IType t = this.GetField(18, 0);
                    ret = (TN)t;
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
        /// Returns Nature of test / observation(OM1-19).
        ///</summary>
        public ID NatureOfTestObservation
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(19, 0);
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
        /// Returns Report Subheader(OM1-20).
        ///</summary>
        public CE ReportSubheader
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(20, 0);
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
        /// Returns Report Display Order(OM1-21).
        ///</summary>
        public ST ReportDisplayOrder
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
        /// Returns Date / time stamp for any change in definition for obs(OM1-22).
        ///</summary>
        public TS DateTimeStampForAnyChangeInDefinitionForObs
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(22, 0);
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
        /// Returns Effective date / time of change(OM1-23).
        ///</summary>
        public TS EffectiveDateTimeOfChange
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(23, 0);
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
        /// Returns Typical Turn-around Time(OM1-24).
        ///</summary>
        public NM TypicalTurnAroundTime
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(24, 0);
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
        /// Returns Processing Time(OM1-25).
        ///</summary>
        public NM ProcessingTime
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(25, 0);
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
        /// Returns a single repetition of Processing Priority(OM1-26).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getProcessingPriority(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(26, rep);
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
        /// Returns all repetitions of Processing Priority (OM1-26).
        ///</summary>
        public ID[] getProcessingPriority()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(26);
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
        /// Returns Reporting Priority(OM1-27).
        ///</summary>
        public ID ReportingPriority
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(27, 0);
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
        /// Returns a single repetition of Outside Site(s) Where Observation may be Performed(OM1-28).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getOutsideSiteSWhereObservationMayBePerformed(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(28, rep);
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
        /// Returns all repetitions of Outside Site(s) Where Observation may be Performed (OM1-28).
        ///</summary>
        public CE[] getOutsideSiteSWhereObservationMayBePerformed()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(28);
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
        /// Returns a single repetition of Address of Outside Site(s)(OM1-29).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public AD getAddressOfOutsideSiteS(int rep)
        {
            AD ret = null;
            try
            {
                IType t = this.GetField(29, rep);
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
        /// Returns all repetitions of Address of Outside Site(s) (OM1-29).
        ///</summary>
        public AD[] getAddressOfOutsideSiteS()
        {
            AD[] ret = null;
            try
            {
                IType[] t = this.GetField(29);
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
        /// Returns a single repetition of Phone Number of Outside Site(OM1-30).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public TN getPhoneNumberOfOutsideSite(int rep)
        {
            TN ret = null;
            try
            {
                IType t = this.GetField(30, rep);
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
        /// Returns all repetitions of Phone Number of Outside Site (OM1-30).
        ///</summary>
        public TN[] getPhoneNumberOfOutsideSite()
        {
            TN[] ret = null;
            try
            {
                IType[] t = this.GetField(30);
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
        /// Returns Confidentiality Code(OM1-31).
        ///</summary>
        public ID ConfidentialityCode
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(31, 0);
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
        /// Returns a single repetition of Observations required to interpret the observation(OM1-32).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getObservationsRequiredToInterpretTheObservation(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(32, rep);
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
        /// Returns all repetitions of Observations required to interpret the observation (OM1-32).
        ///</summary>
        public CE[] getObservationsRequiredToInterpretTheObservation()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(32);
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
        /// Returns Interpretation of Observations(OM1-33).
        ///</summary>
        public TX InterpretationOfObservations
        {
            get
            {
                TX ret = null;
                try
                {
                    IType t = this.GetField(33, 0);
                    ret = (TX)t;
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
        /// Returns a single repetition of Contraindications to Observations(OM1-34).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getContraindicationsToObservations(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(34, rep);
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
        /// Returns all repetitions of Contraindications to Observations (OM1-34).
        ///</summary>
        public CE[] getContraindicationsToObservations()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(34);
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
        /// Returns a single repetition of Reflex tests / observations(OM1-35).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getReflexTestsObservations(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(35, rep);
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
        /// Returns all repetitions of Reflex tests / observations (OM1-35).
        ///</summary>
        public CE[] getReflexTestsObservations()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(35);
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
        /// Returns Rules that Trigger Reflex Testing(OM1-36).
        ///</summary>
        public ST RulesThatTriggerReflexTesting
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(36, 0);
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
        /// Returns a single repetition of Fixed Canned Message(OM1-37).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getFixedCannedMessage(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(37, rep);
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
        /// Returns all repetitions of Fixed Canned Message (OM1-37).
        ///</summary>
        public CE[] getFixedCannedMessage()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(37);
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
        /// Returns Patient Preparation(OM1-38).
        ///</summary>
        public TX PatientPreparation
        {
            get
            {
                TX ret = null;
                try
                {
                    IType t = this.GetField(38, 0);
                    ret = (TX)t;
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
        /// Returns Procedure Medication(OM1-39).
        ///</summary>
        public CE ProcedureMedication
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(39, 0);
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
        /// Returns Factors that may affect the observation(OM1-40).
        ///</summary>
        public TX FactorsThatMayAffectTheObservation
        {
            get
            {
                TX ret = null;
                try
                {
                    IType t = this.GetField(40, 0);
                    ret = (TX)t;
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
        /// Returns a single repetition of Test / observation performance schedule(OM1-41).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getTestObservationPerformanceSchedule(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(41, rep);
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
        /// Returns all repetitions of Test / observation performance schedule (OM1-41).
        ///</summary>
        public ST[] getTestObservationPerformanceSchedule()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(41);
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
        /// Returns Description of Test Methods(OM1-42).
        ///</summary>
        public TX DescriptionOfTestMethods
        {
            get
            {
                TX ret = null;
                try
                {
                    IType t = this.GetField(42, 0);
                    ret = (TX)t;
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