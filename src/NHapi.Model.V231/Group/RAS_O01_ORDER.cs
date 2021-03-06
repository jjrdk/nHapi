using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
///<summary>
///Represents the RAS_O01_ORDER Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: ORC (ORC - common order segment) </li>
///<li>1: RAS_O01_ORDER_DETAIL (a Group object) optional </li>
///<li>2: RAS_O01_ENCODING (a Group object) optional </li>
///<li>3: RXA (RXA - pharmacy/treatment administration segment) repeating</li>
///<li>4: RXR (RXR - pharmacy/treatment route segment) </li>
///<li>5: RAS_O01_OBSERVATION (a Group object) optional repeating</li>
///<li>6: CTI (CTI - clinical trial identification segment) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class RAS_O01_ORDER : AbstractGroup {

	///<summary> 
	/// Creates a new RAS_O01_ORDER Group.
	///</summary>
	public RAS_O01_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(RAS_O01_ORDER_DETAIL), false, false);
	      this.add(typeof(RAS_O01_ENCODING), false, false);
	      this.add(typeof(RXA), true, true);
	      this.add(typeof(RXR), true, false);
	      this.add(typeof(RAS_O01_OBSERVATION), false, true);
	      this.add(typeof(CTI), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RAS_O01_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORC (ORC - common order segment) - creates it if necessary
	///</summary>
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.GetStructure("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RAS_O01_ORDER_DETAIL (a Group object) - creates it if necessary
	///</summary>
	public RAS_O01_ORDER_DETAIL ORDER_DETAIL { 
get{
	   RAS_O01_ORDER_DETAIL ret = null;
	   try {
	      ret = (RAS_O01_ORDER_DETAIL)this.GetStructure("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RAS_O01_ENCODING (a Group object) - creates it if necessary
	///</summary>
	public RAS_O01_ENCODING ENCODING { 
get{
	   RAS_O01_ENCODING ret = null;
	   try {
	      ret = (RAS_O01_ENCODING)this.GetStructure("ENCODING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RXA (RXA - pharmacy/treatment administration segment) - creates it if necessary
	///</summary>
	public RXA GetRXA() {
	   RXA ret = null;
	   try {
	      ret = (RXA)this.GetStructure("RXA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RXA
	/// * (RXA - pharmacy/treatment administration segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RXA GetRXA(int rep) { 
	   return (RXA)this.GetStructure("RXA", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXA 
	 */ 
	public int RXARepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RXA").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RXA results 
	 */ 
	public IEnumerable<RXA> RXAs 
	{ 
		get
		{
			for (int rep = 0; rep < RXARepetitionsUsed; rep++)
			{
				yield return (RXA)this.GetStructure("RXA", rep);
			}
		}
	}

	///<summary>
	///Adds a new RXA
	///</summary>
	public RXA AddRXA()
	{
		return this.AddStructure("RXA") as RXA;
	}

	///<summary>
	///Removes the given RXA
	///</summary>
	public void RemoveRXA(RXA toRemove)
	{
		this.RemoveStructure("RXA", toRemove);
	}

	///<summary>
	///Removes the RXA at the given index
	///</summary>
	public void RemoveRXAAt(int index)
	{
		this.RemoveRepetition("RXA", index);
	}

	///<summary>
	/// Returns RXR (RXR - pharmacy/treatment route segment) - creates it if necessary
	///</summary>
	public RXR RXR { 
get{
	   RXR ret = null;
	   try {
	      ret = (RXR)this.GetStructure("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RAS_O01_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public RAS_O01_OBSERVATION GetOBSERVATION() {
	   RAS_O01_OBSERVATION ret = null;
	   try {
	      ret = (RAS_O01_OBSERVATION)this.GetStructure("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RAS_O01_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RAS_O01_OBSERVATION GetOBSERVATION(int rep) { 
	   return (RAS_O01_OBSERVATION)this.GetStructure("OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RAS_O01_OBSERVATION 
	 */ 
	public int OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RAS_O01_OBSERVATION results 
	 */ 
	public IEnumerable<RAS_O01_OBSERVATION> OBSERVATIONs 
	{ 
		get
		{
			for (int rep = 0; rep < OBSERVATIONRepetitionsUsed; rep++)
			{
				yield return (RAS_O01_OBSERVATION)this.GetStructure("OBSERVATION", rep);
			}
		}
	}

	///<summary>
	///Adds a new RAS_O01_OBSERVATION
	///</summary>
	public RAS_O01_OBSERVATION AddOBSERVATION()
	{
		return this.AddStructure("OBSERVATION") as RAS_O01_OBSERVATION;
	}

	///<summary>
	///Removes the given RAS_O01_OBSERVATION
	///</summary>
	public void RemoveOBSERVATION(RAS_O01_OBSERVATION toRemove)
	{
		this.RemoveStructure("OBSERVATION", toRemove);
	}

	///<summary>
	///Removes the RAS_O01_OBSERVATION at the given index
	///</summary>
	public void RemoveOBSERVATIONAt(int index)
	{
		this.RemoveRepetition("OBSERVATION", index);
	}

	///<summary>
	/// Returns  first repetition of CTI (CTI - clinical trial identification segment) - creates it if necessary
	///</summary>
	public CTI GetCTI() {
	   CTI ret = null;
	   try {
	      ret = (CTI)this.GetStructure("CTI");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CTI
	/// * (CTI - clinical trial identification segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CTI GetCTI(int rep) { 
	   return (CTI)this.GetStructure("CTI", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CTI 
	 */ 
	public int CTIRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CTI").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CTI results 
	 */ 
	public IEnumerable<CTI> CTIs 
	{ 
		get
		{
			for (int rep = 0; rep < CTIRepetitionsUsed; rep++)
			{
				yield return (CTI)this.GetStructure("CTI", rep);
			}
		}
	}

	///<summary>
	///Adds a new CTI
	///</summary>
	public CTI AddCTI()
	{
		return this.AddStructure("CTI") as CTI;
	}

	///<summary>
	///Removes the given CTI
	///</summary>
	public void RemoveCTI(CTI toRemove)
	{
		this.RemoveStructure("CTI", toRemove);
	}

	///<summary>
	///Removes the CTI at the given index
	///</summary>
	public void RemoveCTIAt(int index)
	{
		this.RemoveRepetition("CTI", index);
	}

}
}
