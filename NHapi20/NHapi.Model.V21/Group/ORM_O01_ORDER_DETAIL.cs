using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V21.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V21.Group
{
    ///<summary>
    ///Represents the ORM_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: OBR (OBSERVATION REQUEST) 
    /// * 1: ORO (ORDER OTHER) 
    /// * 2: RX1 (PHARMACY ORDER) 
    /// * 3: NTE (NOTES AND COMMENTS) optional repeating
    /// * 4: OBX (RESULT) optional repeating
    /// * 5: NTE (NOTES AND COMMENTS) optional repeating
    ///</summary>
    [Serializable]
    public class ORM_O01_ORDER_DETAIL : AbstractGroup
    {

        ///<summary> 
        /// Creates a new ORM_O01_ORDER_DETAIL Group.
        ///</summary>
        public ORM_O01_ORDER_DETAIL(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(OBR), true, false);
                this.add(typeof(ORO), true, false);
                this.add(typeof(RX1), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(OBX), false, true);
                this.add(typeof(NTE), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORM_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns OBR (OBSERVATION REQUEST) - creates it if necessary
        ///</summary>
        public OBR OBR
        {
            get
            {
                OBR ret = null;
                try
                {
                    ret = (OBR)this.GetStructure("OBR");
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
        /// Returns ORO (ORDER OTHER) - creates it if necessary
        ///</summary>
        public ORO ORO
        {
            get
            {
                ORO ret = null;
                try
                {
                    ret = (ORO)this.GetStructure("ORO");
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
        /// Returns RX1 (PHARMACY ORDER) - creates it if necessary
        ///</summary>
        public RX1 RX1
        {
            get
            {
                RX1 ret = null;
                try
                {
                    ret = (RX1)this.GetStructure("RX1");
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
        /// Returns  first repetition of NTE (NOTES AND COMMENTS) - creates it if necessary
        ///</summary>
        public NTE getNTE()
        {
            NTE ret = null;
            try
            {
                ret = (NTE)this.GetStructure("NTE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of NTE
        /// * (NOTES AND COMMENTS) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public NTE getNTE(int rep)
        {
            return (NTE)this.GetStructure("NTE", rep);
        }

        /** 
         * Returns the number of existing repetitions of NTE 
         */
        public int NTEReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("NTE").Length;
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
        /// Returns  first repetition of OBX (RESULT) - creates it if necessary
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
        /// * (RESULT) - creates it if necessary
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
        /// Returns  first repetition of NTE2 (NOTES AND COMMENTS) - creates it if necessary
        ///</summary>
        public NTE getNTE2()
        {
            NTE ret = null;
            try
            {
                ret = (NTE)this.GetStructure("NTE2");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of NTE2
        /// * (NOTES AND COMMENTS) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public NTE getNTE2(int rep)
        {
            return (NTE)this.GetStructure("NTE2", rep);
        }

        /** 
         * Returns the number of existing repetitions of NTE2 
         */
        public int NTE2Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("NTE2").Length;
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

    }
}