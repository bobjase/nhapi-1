using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the ADR_A19_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: EVN (EVN - event type segment) optional 
    /// * 1: PID (PID - patient identification segment) 
    /// * 2: PD1 (PD1 - patient additional demographic segment) optional 
    /// * 3: NK1 (NK1 - next of kin / associated parties segment-) optional repeating
    /// * 4: PV1 (PV1 - patient visit segment-) 
    /// * 5: PV2 (PV2 - patient visit - additional information segment) optional 
    /// * 6: DB1 (DB1 - Disability segment) optional repeating
    /// * 7: OBX (OBX - observation/result segment) optional repeating
    /// * 8: AL1 (AL1 - patient allergy information segment) optional repeating
    /// * 9: DG1 (DG1 - diagnosis segment) optional repeating
    /// * 10: DRG (DRG - diagnosis related group segment) optional 
    /// * 11: ADR_A19_PROCEDURE (a Group object) optional repeating
    /// * 12: GT1 (GT1 - guarantor segment) optional repeating
    /// * 13: ADR_A19_INSURANCE (a Group object) optional repeating
    /// * 14: ACC (ACC - accident segment) optional 
    /// * 15: UB1 (UB1 - UB82 data segment) optional 
    /// * 16: UB2 (UB2 - UB92 data segment) optional 
    ///</summary>
    [Serializable]
    public class ADR_A19_QUERY_RESPONSE : AbstractGroup
    {

        ///<summary> 
        /// Creates a new ADR_A19_QUERY_RESPONSE Group.
        ///</summary>
        public ADR_A19_QUERY_RESPONSE(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(EVN), false, false);
                this.add(typeof(PID), true, false);
                this.add(typeof(PD1), false, false);
                this.add(typeof(NK1), false, true);
                this.add(typeof(PV1), true, false);
                this.add(typeof(PV2), false, false);
                this.add(typeof(DB1), false, true);
                this.add(typeof(OBX), false, true);
                this.add(typeof(AL1), false, true);
                this.add(typeof(DG1), false, true);
                this.add(typeof(DRG), false, false);
                this.add(typeof(ADR_A19_PROCEDURE), false, true);
                this.add(typeof(GT1), false, true);
                this.add(typeof(ADR_A19_INSURANCE), false, true);
                this.add(typeof(ACC), false, false);
                this.add(typeof(UB1), false, false);
                this.add(typeof(UB2), false, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADR_A19_QUERY_RESPONSE - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns EVN (EVN - event type segment) - creates it if necessary
        ///</summary>
        public EVN EVN
        {
            get
            {
                EVN ret = null;
                try
                {
                    ret = (EVN)this.GetStructure("EVN");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PID (PID - patient identification segment) - creates it if necessary
        ///</summary>
        public PID PID
        {
            get
            {
                PID ret = null;
                try
                {
                    ret = (PID)this.GetStructure("PID");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary
        ///</summary>
        public PD1 PD1
        {
            get
            {
                PD1 ret = null;
                try
                {
                    ret = (PD1)this.GetStructure("PD1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns  first repetition of NK1 (NK1 - next of kin / associated parties segment-) - creates it if necessary
        ///</summary>
        public NK1 getNK1()
        {
            NK1 ret = null;
            try
            {
                ret = (NK1)this.GetStructure("NK1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of NK1
        /// * (NK1 - next of kin / associated parties segment-) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public NK1 getNK1(int rep)
        {
            return (NK1)this.GetStructure("NK1", rep);
        }

        /** 
         * Returns the number of existing repetitions of NK1 
         */
        public int NK1Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("NK1").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns PV1 (PV1 - patient visit segment-) - creates it if necessary
        ///</summary>
        public PV1 PV1
        {
            get
            {
                PV1 ret = null;
                try
                {
                    ret = (PV1)this.GetStructure("PV1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PV2 (PV2 - patient visit - additional information segment) - creates it if necessary
        ///</summary>
        public PV2 PV2
        {
            get
            {
                PV2 ret = null;
                try
                {
                    ret = (PV2)this.GetStructure("PV2");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns  first repetition of DB1 (DB1 - Disability segment) - creates it if necessary
        ///</summary>
        public DB1 getDB1()
        {
            DB1 ret = null;
            try
            {
                ret = (DB1)this.GetStructure("DB1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of DB1
        /// * (DB1 - Disability segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public DB1 getDB1(int rep)
        {
            return (DB1)this.GetStructure("DB1", rep);
        }

        /** 
         * Returns the number of existing repetitions of DB1 
         */
        public int DB1Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("DB1").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns  first repetition of OBX (OBX - observation/result segment) - creates it if necessary
        ///</summary>
        public OBX getOBX()
        {
            OBX ret = null;
            try
            {
                ret = (OBX)this.GetStructure("OBX");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of OBX
        /// * (OBX - observation/result segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public OBX getOBX(int rep)
        {
            return (OBX)this.GetStructure("OBX", rep);
        }

        /** 
         * Returns the number of existing repetitions of OBX 
         */
        public int OBXReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("OBX").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns  first repetition of AL1 (AL1 - patient allergy information segment) - creates it if necessary
        ///</summary>
        public AL1 getAL1()
        {
            AL1 ret = null;
            try
            {
                ret = (AL1)this.GetStructure("AL1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of AL1
        /// * (AL1 - patient allergy information segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public AL1 getAL1(int rep)
        {
            return (AL1)this.GetStructure("AL1", rep);
        }

        /** 
         * Returns the number of existing repetitions of AL1 
         */
        public int AL1Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("AL1").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary
        ///</summary>
        public DG1 getDG1()
        {
            DG1 ret = null;
            try
            {
                ret = (DG1)this.GetStructure("DG1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of DG1
        /// * (DG1 - diagnosis segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public DG1 getDG1(int rep)
        {
            return (DG1)this.GetStructure("DG1", rep);
        }

        /** 
         * Returns the number of existing repetitions of DG1 
         */
        public int DG1Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("DG1").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns DRG (DRG - diagnosis related group segment) - creates it if necessary
        ///</summary>
        public DRG DRG
        {
            get
            {
                DRG ret = null;
                try
                {
                    ret = (DRG)this.GetStructure("DRG");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns  first repetition of ADR_A19_PROCEDURE (a Group object) - creates it if necessary
        ///</summary>
        public ADR_A19_PROCEDURE getPROCEDURE()
        {
            ADR_A19_PROCEDURE ret = null;
            try
            {
                ret = (ADR_A19_PROCEDURE)this.GetStructure("PROCEDURE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of ADR_A19_PROCEDURE
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public ADR_A19_PROCEDURE getPROCEDURE(int rep)
        {
            return (ADR_A19_PROCEDURE)this.GetStructure("PROCEDURE", rep);
        }

        /** 
         * Returns the number of existing repetitions of ADR_A19_PROCEDURE 
         */
        public int PROCEDUREReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("PROCEDURE").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns  first repetition of GT1 (GT1 - guarantor segment) - creates it if necessary
        ///</summary>
        public GT1 getGT1()
        {
            GT1 ret = null;
            try
            {
                ret = (GT1)this.GetStructure("GT1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of GT1
        /// * (GT1 - guarantor segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public GT1 getGT1(int rep)
        {
            return (GT1)this.GetStructure("GT1", rep);
        }

        /** 
         * Returns the number of existing repetitions of GT1 
         */
        public int GT1Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("GT1").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns  first repetition of ADR_A19_INSURANCE (a Group object) - creates it if necessary
        ///</summary>
        public ADR_A19_INSURANCE getINSURANCE()
        {
            ADR_A19_INSURANCE ret = null;
            try
            {
                ret = (ADR_A19_INSURANCE)this.GetStructure("INSURANCE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of ADR_A19_INSURANCE
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public ADR_A19_INSURANCE getINSURANCE(int rep)
        {
            return (ADR_A19_INSURANCE)this.GetStructure("INSURANCE", rep);
        }

        /** 
         * Returns the number of existing repetitions of ADR_A19_INSURANCE 
         */
        public int INSURANCEReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("INSURANCE").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns ACC (ACC - accident segment) - creates it if necessary
        ///</summary>
        public ACC ACC
        {
            get
            {
                ACC ret = null;
                try
                {
                    ret = (ACC)this.GetStructure("ACC");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns UB1 (UB1 - UB82 data segment) - creates it if necessary
        ///</summary>
        public UB1 UB1
        {
            get
            {
                UB1 ret = null;
                try
                {
                    ret = (UB1)this.GetStructure("UB1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns UB2 (UB2 - UB92 data segment) - creates it if necessary
        ///</summary>
        public UB2 UB2
        {
            get
            {
                UB2 ret = null;
                try
                {
                    ret = (UB2)this.GetStructure("UB2");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

    }
}