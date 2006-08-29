using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment
{

    ///<summary>
    /// Represents an HL7 MSH message segment. 
    /// This segment has the following fields:
    /// * MSH-1: FIELD SEPARATOR (ST)
    /// * MSH-2: ENCODING CHARACTERS (ST)
    /// * MSH-3: SENDING APPLICATION (ST)
    /// * MSH-4: SENDING FACILITY (ST)
    /// * MSH-5: RECEIVING APPLICATION (ST)
    /// * MSH-6: RECEIVING FACILITY (ST)
    /// * MSH-7: DATE/TIME OF MESSAGE (TS)
    /// * MSH-8: Security (ST)
    /// * MSH-9: MESSAGE TYPE (ID)
    /// * MSH-10: MESSAGE CONTROL ID (ST)
    /// * MSH-11: PROCESSING ID (ID)
    /// * MSH-12: VERSION ID (NM)
    /// * MSH-13: SEQUENCE NUMBER (NM)
    /// * MSH-14: CONTINUATION POINTER (ST)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class MSH : AbstractSegment
    {

        /**
         * Creates a MSH (MESSAGE HEADER) segment object that belongs to the given 
         * message.  
         */
        public MSH(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ST), true, 1, 1, new System.Object[] { message }, "FIELD SEPARATOR");
                this.add(typeof(ST), true, 1, 4, new System.Object[] { message }, "ENCODING CHARACTERS");
                this.add(typeof(ST), false, 1, 15, new System.Object[] { message }, "SENDING APPLICATION");
                this.add(typeof(ST), false, 1, 20, new System.Object[] { message }, "SENDING FACILITY");
                this.add(typeof(ST), false, 1, 15, new System.Object[] { message }, "RECEIVING APPLICATION");
                this.add(typeof(ST), false, 1, 30, new System.Object[] { message }, "RECEIVING FACILITY");
                this.add(typeof(TS), false, 1, 19, new System.Object[] { message }, "DATE/TIME OF MESSAGE");
                this.add(typeof(ST), false, 1, 40, new System.Object[] { message }, "Security");
                this.add(typeof(ID), true, 1, 7, new System.Object[] { message, 76 }, "MESSAGE TYPE");
                this.add(typeof(ST), true, 1, 20, new System.Object[] { message }, "MESSAGE CONTROL ID");
                this.add(typeof(ID), true, 1, 1, new System.Object[] { message, 103 }, "PROCESSING ID");
                this.add(typeof(NM), true, 1, 8, new System.Object[] { message }, "VERSION ID");
                this.add(typeof(NM), false, 1, 15, new System.Object[] { message }, "SEQUENCE NUMBER");
                this.add(typeof(ST), false, 1, 180, new System.Object[] { message }, "CONTINUATION POINTER");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns FIELD SEPARATOR(MSH-1).
        ///</summary>
        public ST FIELDSEPARATOR
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
        /// Returns ENCODING CHARACTERS(MSH-2).
        ///</summary>
        public ST ENCODINGCHARACTERS
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns SENDING APPLICATION(MSH-3).
        ///</summary>
        public ST SENDINGAPPLICATION
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
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
        /// Returns SENDING FACILITY(MSH-4).
        ///</summary>
        public ST SENDINGFACILITY
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
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
        /// Returns RECEIVING APPLICATION(MSH-5).
        ///</summary>
        public ST RECEIVINGAPPLICATION
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
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
        /// Returns RECEIVING FACILITY(MSH-6).
        ///</summary>
        public ST RECEIVINGFACILITY
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns DATE/TIME OF MESSAGE(MSH-7).
        ///</summary>
        public TS DATETIMEOFMESSAGE
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
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
        /// Returns Security(MSH-8).
        ///</summary>
        public ST Security
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
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
        /// Returns MESSAGE TYPE(MSH-9).
        ///</summary>
        public ID MESSAGETYPE
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
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
        /// Returns MESSAGE CONTROL ID(MSH-10).
        ///</summary>
        public ST MESSAGECONTROLID
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
        /// Returns PROCESSING ID(MSH-11).
        ///</summary>
        public ID PROCESSINGID
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
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
        /// Returns VERSION ID(MSH-12).
        ///</summary>
        public NM VERSIONID
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
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
        /// Returns SEQUENCE NUMBER(MSH-13).
        ///</summary>
        public NM SEQUENCENUMBER
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(13, 0);
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
        /// Returns CONTINUATION POINTER(MSH-14).
        ///</summary>
        public ST CONTINUATIONPOINTER
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(14, 0);
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


    }
}