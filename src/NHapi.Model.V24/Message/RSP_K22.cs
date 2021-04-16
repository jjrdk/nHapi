using System;
using System.Collections.Generic;
using NHapi.Base.Log;
using NHapi.Model.V24.Group;
using NHapi.Model.V24.Segment;
using NHapi.Model.V24.Datatype;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V24.Message

{
///<summary>
/// Represents a RSP_K22 message structure (see chapter 3). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (Message Header) </li>
///<li>1: MSA (Message Acknowledgment) </li>
///<li>2: ERR (Error) optional </li>
///<li>3: QAK (Query Acknowledgment) </li>
///<li>4: QPD (Query Parameter Definition) </li>
///<li>5: RSP_K22_QUERY_RESPONSE (a Group object) optional repeating</li>
///<li>6: DSC (Continuation Pointer) optional </li>
///</ol>
///</summary>
[Serializable]
public class RSP_K22 : AbstractMessage  {

	///<summary> 
	/// Creates a new RSP_K22 Group with custom IModelClassFactory.
	///</summary>
	public RSP_K22(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new RSP_K22 Group with DefaultModelClassFactory. 
	///</summary> 
	public RSP_K22() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for RSP_K22.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(ERR), false, false);
	      this.add(typeof(QAK), true, false);
	      this.add(typeof(QPD), true, false);
	      this.add(typeof(RSP_K22_QUERY_RESPONSE), false, true);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RSP_K22 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (Message Header) - creates it if necessary
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
	/// Returns MSA (Message Acknowledgment) - creates it if necessary
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
	/// Returns ERR (Error) - creates it if necessary
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
	/// Returns QAK (Query Acknowledgment) - creates it if necessary
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
	/// Returns QPD (Query Parameter Definition) - creates it if necessary
	///</summary>
	public QPD QPD { 
get{
	   QPD ret = null;
	   try {
	      ret = (QPD)this.GetStructure("QPD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RSP_K22_QUERY_RESPONSE (a Group object) - creates it if necessary
	///</summary>
	public RSP_K22_QUERY_RESPONSE GetQUERY_RESPONSE() {
	   RSP_K22_QUERY_RESPONSE ret = null;
	   try {
	      ret = (RSP_K22_QUERY_RESPONSE)this.GetStructure("QUERY_RESPONSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RSP_K22_QUERY_RESPONSE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RSP_K22_QUERY_RESPONSE GetQUERY_RESPONSE(int rep) { 
	   return (RSP_K22_QUERY_RESPONSE)this.GetStructure("QUERY_RESPONSE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RSP_K22_QUERY_RESPONSE 
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
	 * Enumerate over the RSP_K22_QUERY_RESPONSE results 
	 */ 
	public IEnumerable<RSP_K22_QUERY_RESPONSE> QUERY_RESPONSEs 
	{ 
		get
		{
			for (int rep = 0; rep < QUERY_RESPONSERepetitionsUsed; rep++)
			{
				yield return (RSP_K22_QUERY_RESPONSE)this.GetStructure("QUERY_RESPONSE", rep);
			}
		}
	}

	///<summary>
	///Adds a new RSP_K22_QUERY_RESPONSE
	///</summary>
	public RSP_K22_QUERY_RESPONSE AddQUERY_RESPONSE()
	{
		return this.AddStructure("QUERY_RESPONSE") as RSP_K22_QUERY_RESPONSE;
	}

	///<summary>
	///Removes the given RSP_K22_QUERY_RESPONSE
	///</summary>
	public void RemoveQUERY_RESPONSE(RSP_K22_QUERY_RESPONSE toRemove)
	{
		this.RemoveStructure("QUERY_RESPONSE", toRemove);
	}

	///<summary>
	///Removes the RSP_K22_QUERY_RESPONSE at the given index
	///</summary>
	public void RemoveQUERY_RESPONSEAt(int index)
	{
		this.RemoveRepetition("QUERY_RESPONSE", index);
	}

	///<summary>
	/// Returns DSC (Continuation Pointer) - creates it if necessary
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
