using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RQI_I03_GUARANTOR_INSURANCE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: GT1 (GT1 - guarantor segment) <b>optional repeating</b><br>
 * 1: RQI_I03_INSURANCE (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class RQI_I03_GUARANTOR_INSURANCE : AbstractGroup 
	{

		/** 
		 * Creates a new RQI_I03_GUARANTOR_INSURANCE Group.
		 */
		public RQI_I03_GUARANTOR_INSURANCE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(GT1), false, true);
				this.add(typeof(RQI_I03_INSURANCE), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RQI_I03_GUARANTOR_INSURANCE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns  first repetition of GT1 (GT1 - guarantor segment) - creates it if necessary
		 */
		public GT1 getGT1() 
		{
			GT1 ret = null;
			try 
			{
				ret = (GT1)this.get_Renamed("GT1");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of GT1
		 * (GT1 - guarantor segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public GT1 getGT1(int rep) 
		{ 
			return (GT1)this.get_Renamed("GT1", rep);
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
					reps = this.getAll("GT1").Length; 
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
		 * Returns  first repetition of RQI_I03_INSURANCE (a Group object) - creates it if necessary
		 */
		public RQI_I03_INSURANCE getINSURANCE() 
		{
			RQI_I03_INSURANCE ret = null;
			try 
			{
				ret = (RQI_I03_INSURANCE)this.get_Renamed("INSURANCE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RQI_I03_INSURANCE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RQI_I03_INSURANCE getINSURANCE(int rep) 
		{ 
			return (RQI_I03_INSURANCE)this.get_Renamed("INSURANCE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RQI_I03_INSURANCE 
		 */ 
		public int INSURANCEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("INSURANCE").Length; 
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
