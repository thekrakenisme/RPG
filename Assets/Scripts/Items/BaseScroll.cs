using UnityEngine;
using System.Collections;

public class BaseScroll : BaseItem {

	public enum ScrollTypes{
		SUMMON,
		MAP,
		TREASURE
	}

	private ScrollTypes scrollType;
	private int spellEffectID;
	
	public ScrollTypes ScrollType{
		get{return scrollType;}
		set{scrollType = value;}
	}

	public int SpellEffectID{
		get{return spellEffectID;}
		set{spellEffectID = value;}
	}
}
