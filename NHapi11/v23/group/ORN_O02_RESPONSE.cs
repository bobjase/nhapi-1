using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORN_O02_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORN_O02_PATIENT (a Group object) <b>optional </b><br>
 * 1: ORN_O02_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class ORN_O02_RESPONSE : AbstractGroup 
	{

		/** 
		 * Creates a new ORN_O02_RESPONSE Group.
		 */
		public ORN_O02_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORN_O02_PATIENT), false, false);
				this.add(typeof(ORN_O02_ORDER), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORN_O02_RESPONSE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORN_O02_PATIENT (a Group object) - creates it if necessary
		 */
		public ORN_O02_PATIENT PATIENT 
		{ 
			get
			{
				ORN_O02_PATIENT ret = null;
				try 
				{
					ret = (ORN_O02_PATIENT)this.get_Renamed("PATIENT");
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
		 * Returns  first repetition of ORN_O02_ORDER (a Group object) - creates it if necessary
		 */
		public ORN_O02_ORDER getORDER() 
		{
			ORN_O02_ORDER ret = null;
			try 
			{
				ret = (ORN_O02_ORDER)this.get_Renamed("ORDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ORN_O02_ORDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ORN_O02_ORDER getORDER(int rep) 
		{ 
			return (ORN_O02_ORDER)this.get_Renamed("ORDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ORN_O02_ORDER 
		 */ 
		public int ORDERReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("ORDER").Length; 
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
