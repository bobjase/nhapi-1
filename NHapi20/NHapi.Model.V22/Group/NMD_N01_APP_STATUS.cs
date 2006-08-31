using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V22.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V22.Group
{
    ///<summary>
    ///Represents the NMD_N01_APP_STATUS Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: NSC (STATUS CHANGE) 
    /// * 1: NTE (NOTES AND COMMENTS) optional repeating
    ///</summary>
    [Serializable]
    public class NMD_N01_APP_STATUS : AbstractGroup
    {

        ///<summary> 
        /// Creates a new NMD_N01_APP_STATUS Group.
        ///</summary>
        public NMD_N01_APP_STATUS(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(NSC), true, false);
                this.add(typeof(NTE), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMD_N01_APP_STATUS - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns NSC (STATUS CHANGE) - creates it if necessary
        ///</summary>
        public NSC NSC
        {
            get
            {
                NSC ret = null;
                try
                {
                    ret = (NSC)this.GetStructure("NSC");
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

    }
}