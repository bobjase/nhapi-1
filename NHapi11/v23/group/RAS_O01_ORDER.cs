using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RAS_O01_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common order segment) <b></b><br>
 * 1: RAS_O01_ORDER_DETAIL (a Group object) <b>optional </b><br>
 * 2: RAS_O01_ENCODING (a Group object) <b>optional </b><br>
 * 3: RXA (Pharmacy administration segment) <b>repeating</b><br>
 * 4: RXR (Pharmacy route segment) <b></b><br>
 * 5: RAS_O01_OBSERVATION (a Group object) <b>optional repeating</b><br>
 * 6: CTI (Clinical Trial Identification) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class RAS_O01_ORDER : AbstractGroup 
	{

		/** 
		 * Creates a new RAS_O01_ORDER Group.
		 */
		public RAS_O01_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RAS_O01_ORDER_DETAIL), false, false);
				this.add(typeof(RAS_O01_ENCODING), false, false);
				this.add(typeof(RXA), true, true);
				this.add(typeof(RXR), true, false);
				this.add(typeof(RAS_O01_OBSERVATION), false, true);
				this.add(typeof(CTI), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RAS_O01_ORDER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORC (Common order segment) - creates it if necessary
		 */
		public ORC ORC 
		{ 
			get
			{
				ORC ret = null;
				try 
				{
					ret = (ORC)this.get_Renamed("ORC");
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
		 * Returns RAS_O01_ORDER_DETAIL (a Group object) - creates it if necessary
		 */
		public RAS_O01_ORDER_DETAIL ORDER_DETAIL 
		{ 
			get
			{
				RAS_O01_ORDER_DETAIL ret = null;
				try 
				{
					ret = (RAS_O01_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
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
		 * Returns RAS_O01_ENCODING (a Group object) - creates it if necessary
		 */
		public RAS_O01_ENCODING ENCODING 
		{ 
			get
			{
				RAS_O01_ENCODING ret = null;
				try 
				{
					ret = (RAS_O01_ENCODING)this.get_Renamed("ENCODING");
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
		 * Returns  first repetition of RXA (Pharmacy administration segment) - creates it if necessary
		 */
		public RXA getRXA() 
		{
			RXA ret = null;
			try 
			{
				ret = (RXA)this.get_Renamed("RXA");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RXA
		 * (Pharmacy administration segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RXA getRXA(int rep) 
		{ 
			return (RXA)this.get_Renamed("RXA", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RXA 
		 */ 
		public int RXAReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RXA").Length; 
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
		 * Returns RXR (Pharmacy route segment) - creates it if necessary
		 */
		public RXR RXR 
		{ 
			get
			{
				RXR ret = null;
				try 
				{
					ret = (RXR)this.get_Renamed("RXR");
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
		 * Returns  first repetition of RAS_O01_OBSERVATION (a Group object) - creates it if necessary
		 */
		public RAS_O01_OBSERVATION getOBSERVATION() 
		{
			RAS_O01_OBSERVATION ret = null;
			try 
			{
				ret = (RAS_O01_OBSERVATION)this.get_Renamed("OBSERVATION");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RAS_O01_OBSERVATION
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RAS_O01_OBSERVATION getOBSERVATION(int rep) 
		{ 
			return (RAS_O01_OBSERVATION)this.get_Renamed("OBSERVATION", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RAS_O01_OBSERVATION 
		 */ 
		public int OBSERVATIONReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("OBSERVATION").Length; 
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
		 * Returns  first repetition of CTI (Clinical Trial Identification) - creates it if necessary
		 */
		public CTI getCTI() 
		{
			CTI ret = null;
			try 
			{
				ret = (CTI)this.get_Renamed("CTI");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of CTI
		 * (Clinical Trial Identification) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public CTI getCTI(int rep) 
		{ 
			return (CTI)this.get_Renamed("CTI", rep);
		}

		/** 
		 * Returns the number of existing repetitions of CTI 
		 */ 
		public int CTIReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("CTI").Length; 
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
