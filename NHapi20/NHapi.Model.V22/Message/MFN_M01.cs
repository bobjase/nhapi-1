using System;
using NHapi.Base.Log;
using NHapi.Model.V22.Group;
using NHapi.Model.V22.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V22.Message
{
    ///<summary>
    /// Represents a MFN_M01 message structure (see chapter [AAA]). This structure contains the 
    /// following elements:
    /// * 0: MSH (MESSAGE HEADER) 
    /// * 1: MFI (MASTER FILE IDENTIFICATION) 
    /// * 2: MFN_M01_MF (a Group object) repeating
    ///</summary>
    [Serializable]
    public class MFN_M01 : AbstractMessage
    {

        ///<summary> 
        /// Creates a new MFN_M01 Group with custom IModelClassFactory.
        ///</summary>
        public MFN_M01(IModelClassFactory factory)
            : base(factory)
        {
            init(factory);
        }

        ///<summary>
        /// Creates a new MFN_M01 Group with DefaultModelClassFactory. 
        ///</summary> 
        public MFN_M01()
            : base(new DefaultModelClassFactory())
        {
            init(new DefaultModelClassFactory());
        }

        ///<summary>
        /// initalize method for MFN_M01.  This does the segment setup for the message. 
        ///</summary> 
        private void init(IModelClassFactory factory)
        {
            try
            {
                this.add(typeof(MSH), true, false);
                this.add(typeof(MFI), true, false);
                this.add(typeof(MFN_M01_MF), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M01 - this is probably a bug in the source code generator.", e);
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
        /// Returns MFI (MASTER FILE IDENTIFICATION) - creates it if necessary
        ///</summary>
        public MFI MFI
        {
            get
            {
                MFI ret = null;
                try
                {
                    ret = (MFI)this.GetStructure("MFI");
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
        /// Returns  first repetition of MFN_M01_MF (a Group object) - creates it if necessary
        ///</summary>
        public MFN_M01_MF getMF()
        {
            MFN_M01_MF ret = null;
            try
            {
                ret = (MFN_M01_MF)this.GetStructure("MF");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of MFN_M01_MF
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public MFN_M01_MF getMF(int rep)
        {
            return (MFN_M01_MF)this.GetStructure("MF", rep);
        }

        /** 
         * Returns the number of existing repetitions of MFN_M01_MF 
         */
        public int MFReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("MF").Length;
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
