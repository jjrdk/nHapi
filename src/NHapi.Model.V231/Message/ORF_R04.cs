using System;
using System.Collections.Generic;
using NHapi.Base.Log;
using NHapi.Model.V231.Group;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Message

{
///<summary>
/// Represents a ORF_R04 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (MSH - message header segment) </li>
///<li>1: MSA (MSA - message acknowledgment segment) </li>
///<li>2: QRD (QRD - original-style query definition segment) </li>
///<li>3: QRF (QRF - original style query filter segment) optional </li>
///<li>4: ORF_R04_QUERY_RESPONSE (a Group object) repeating</li>
///<li>5: ERR (ERR - error segment) optional </li>
///<li>6: QAK (Query Acknowledgement) optional </li>
///<li>7: DSC (DSC - Continuation pointer segment) optional </li>
///</ol>
///</summary>
[Serializable]
public class ORF_R04 : AbstractMessage  {

	///<summary> 
	/// Creates a new ORF_R04 Group with custom IModelClassFactory.
	///</summary>
	public ORF_R04(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new ORF_R04 Group with DefaultModelClassFactory. 
	///</summary> 
	public ORF_R04() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for ORF_R04.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(QRF), false, false);
	      this.add(typeof(ORF_R04_QUERY_RESPONSE), true, true);
	      this.add(typeof(ERR), false, false);
	      this.add(typeof(QAK), false, false);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORF_R04 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (MSH - message header segment) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns MSA (MSA - message acknowledgment segment) - creates it if necessary
	///</summary>
	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.GetStructure("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRD (QRD - original-style query definition segment) - creates it if necessary
	///</summary>
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRF (QRF - original style query filter segment) - creates it if necessary
	///</summary>
	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.GetStructure("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ORF_R04_QUERY_RESPONSE (a Group object) - creates it if necessary
	///</summary>
	public ORF_R04_QUERY_RESPONSE GetQUERY_RESPONSE() {
	   ORF_R04_QUERY_RESPONSE ret = null;
	   try {
	      ret = (ORF_R04_QUERY_RESPONSE)this.GetStructure("QUERY_RESPONSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORF_R04_QUERY_RESPONSE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORF_R04_QUERY_RESPONSE GetQUERY_RESPONSE(int rep) { 
	   return (ORF_R04_QUERY_RESPONSE)this.GetStructure("QUERY_RESPONSE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORF_R04_QUERY_RESPONSE 
	 */ 
	public int QUERY_RESPONSERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("QUERY_RESPONSE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the ORF_R04_QUERY_RESPONSE results 
	 */ 
	public IEnumerable<ORF_R04_QUERY_RESPONSE> QUERY_RESPONSEs 
	{ 
		get
		{
			for (int rep = 0; rep < QUERY_RESPONSERepetitionsUsed; rep++)
			{
				yield return (ORF_R04_QUERY_RESPONSE)this.GetStructure("QUERY_RESPONSE", rep);
			}
		}
	}

	///<summary>
	///Adds a new ORF_R04_QUERY_RESPONSE
	///</summary>
	public ORF_R04_QUERY_RESPONSE AddQUERY_RESPONSE()
	{
		return this.AddStructure("QUERY_RESPONSE") as ORF_R04_QUERY_RESPONSE;
	}

	///<summary>
	///Removes the given ORF_R04_QUERY_RESPONSE
	///</summary>
	public void RemoveQUERY_RESPONSE(ORF_R04_QUERY_RESPONSE toRemove)
	{
		this.RemoveStructure("QUERY_RESPONSE", toRemove);
	}

	///<summary>
	///Removes the ORF_R04_QUERY_RESPONSE at the given index
	///</summary>
	public void RemoveQUERY_RESPONSEAt(int index)
	{
		this.RemoveRepetition("QUERY_RESPONSE", index);
	}

	///<summary>
	/// Returns ERR (ERR - error segment) - creates it if necessary
	///</summary>
	public ERR ERR { 
get{
	   ERR ret = null;
	   try {
	      ret = (ERR)this.GetStructure("ERR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QAK (Query Acknowledgement) - creates it if necessary
	///</summary>
	public QAK QAK { 
get{
	   QAK ret = null;
	   try {
	      ret = (QAK)this.GetStructure("QAK");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns DSC (DSC - Continuation pointer segment) - creates it if necessary
	///</summary>
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.GetStructure("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
