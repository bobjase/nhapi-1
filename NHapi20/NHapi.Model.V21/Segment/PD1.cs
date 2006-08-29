using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment
{

    ///<summary>
    /// Represents an HL7 PD1 message segment. 
    /// This segment has the following fields:
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class PD1 : AbstractSegment
    {

        /**
         * Creates a PD1 () segment object that belongs to the given 
         * message.  
         */
        public PD1(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
        }


    }
}