using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a TCU_U10 message structure (see chapter 13). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: EQU (Equipment Detail) <b></b><br>
 * 2: TCC (Test Code Configuration) <b>repeating</b><br>
 * 3: ROL (Role) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
	public class TCU_U10 : AbstractMessage  
	{

		/** 
		 * Creates a new TCU_U10 Group with custom ModelClassFactory.
		 */
		public TCU_U10(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new TCU_U10 Group with DefaultModelClassFactory. 
		 */ 
		public TCU_U10() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EQU), true, false);
				this.add(typeof(TCC), true, true);
				this.add(typeof(ROL), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating TCU_U10 - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MSH (Message Header) - creates it if necessary
		 */
		public MSH MSH 
		{ 
			get
			{
				MSH ret = null;
				try 
				{
					ret = (MSH)this.get_Renamed("MSH");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

		/**
		 * Returns EQU (Equipment Detail) - creates it if necessary
		 */
		public EQU EQU 
		{ 
			get
			{
				EQU ret = null;
				try 
				{
					ret = (EQU)this.get_Renamed("EQU");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

		/**
		 * Returns  first repetition of TCC (Test Code Configuration) - creates it if necessary
		 */
		public TCC getTCC() 
		{
			TCC ret = null;
			try 
			{
				ret = (TCC)this.get_Renamed("TCC");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of TCC
		 * (Test Code Configuration) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public TCC getTCC(int rep) 
		{ 
			return (TCC)this.get_Renamed("TCC", rep);
		}

		/** 
		 * Returns the number of existing repetitions of TCC 
		 */ 
		public int TCCReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("TCC").Length; 
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

		/**
		 * Returns ROL (Role) - creates it if necessary
		 */
		public ROL ROL 
		{ 
			get
			{
				ROL ret = null;
				try 
				{
					ret = (ROL)this.get_Renamed("ROL");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

	}
}
