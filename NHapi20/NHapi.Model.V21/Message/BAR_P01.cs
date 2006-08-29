using System;
using NHapi.Base.Log;
using NHapi.Model.V21.Group;
using NHapi.Model.V21.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V21.Message
{
    ///<summary>
    /// Represents a BAR_P01 message structure (see chapter [AAA]). This structure contains the 
    /// following elements:
    /// * 0: MSH (MESSAGE HEADER) 
    /// * 1: EVN (EVENT TYPE) 
    /// * 2: PID (PATIENT IDENTIFICATION) 
    /// * 3: BAR_P01_VISIT (a Group object) repeating
    ///</summary>
    [Serializable]
    public class BAR_P01 : AbstractMessage
    {

        ///<summary> 
        /// Creates a new BAR_P01 Group with custom IModelClassFactory.
        ///</summary>
        public BAR_P01(IModelClassFactory factory)
            : base(factory)
        {
            init(factory);
        }

        ///<summary>
        /// Creates a new BAR_P01 Group with DefaultModelClassFactory. 
        ///</summary> 
        public BAR_P01()
            : base(new DefaultModelClassFactory())
        {
            init(new DefaultModelClassFactory());
        }

        ///<summary>
        /// initalize method for BAR_P01.  This does the segment setup for the message. 
        ///</summary> 
        private void init(IModelClassFactory factory)
        {
            try
            {
                this.add(typeof(MSH), true, false);
                this.add(typeof(EVN), true, false);
                this.add(typeof(PID), true, false);
                this.add(typeof(BAR_P01_VISIT), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BAR_P01 - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns MSH (MESSAGE HEADER) - creates it if necessary
        ///</summary>
        public MSH MSH
        {
            get
            {
                MSH ret = null;
                try
                {
                    ret = (MSH)this.GetStructure("MSH");
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
        /// Returns EVN (EVENT TYPE) - creates it if necessary
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
        /// Returns PID (PATIENT IDENTIFICATION) - creates it if necessary
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
        /// Returns  first repetition of BAR_P01_VISIT (a Group object) - creates it if necessary
        ///</summary>
        public BAR_P01_VISIT getVISIT()
        {
            BAR_P01_VISIT ret = null;
            try
            {
                ret = (BAR_P01_VISIT)this.GetStructure("VISIT");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of BAR_P01_VISIT
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public BAR_P01_VISIT getVISIT(int rep)
        {
            return (BAR_P01_VISIT)this.GetStructure("VISIT", rep);
        }

        /** 
         * Returns the number of existing repetitions of BAR_P01_VISIT 
         */
        public int VISITReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("VISIT").Length;
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
