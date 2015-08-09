using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem {

	public enum EquipmentTypes{
		HEAD,
		CHEST,
		SHOULDERS,
		LEGS,
		FEET,
		ARMS,
		NECKLACE,
		EARRING_LEFT,
		EARRING_RIGHT,
		CAPE,
		WAIST,
		SHIELD,
		RING_LEFT,
		RING_RIGHT
	}

	private EquipmentTypes equipmentType;
	private int spellEffectID;

	public EquipmentTypes EquipmentType{
		get{return equipmentType;}
		set{equipmentType = value;}
	}
	public int SpellEffectID{
		get{return spellEffectID;}
		set{spellEffectID = value;}
}
}