using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {

	public enum PotionTypes{
		HP,
		MAX_HP,
		FOCUS,
		MAX_FOCUS,
		XP,
		XP_BONUS,
		LOVE,
		LEVEL_UP,
		AC,
		MANA_REGEN,
		MAX_MANA,
		HP_REGEN,
		FOCUS_REGEN,
		DAMAGE_SHIELD,
		ACCURACY,
		DAMAGE,
		INITIATIVE,
		ATTACKS,
		MUTATION,
		BOOZE,
		STEALTH,
		POISON,
		CONFUSION,
		BLINDNESS,
		MANA,
		STAMINA,
		INTELLECT,
		DEXTERITY,
		STRENGTH,
		OCCULT,
		LUCK,
		WISDOM
	}

	private PotionTypes potionType;
	private int spellEffectID;
	
	public PotionTypes PotionType{
		get{return potionType;}
		set{potionType = value;}
	}

	public int SpellEffectID{
		get{return spellEffectID;}
		set{spellEffectID = value;}
	}
}
