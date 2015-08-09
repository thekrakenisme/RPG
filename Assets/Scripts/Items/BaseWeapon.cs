using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {  //BaseWeapon <- BaseStatItem <- BaseItem

	public enum WeaponTypes{
		DAGGER,
		SHORTSWORD,
		STAVE,
		GUN,
		KNUCKLES,
		TOME,
		WHIP,
		BOW,
		CROSSBOW,
		BOOMERANG,
		SHOVEL,
		ORB,
		AXE,
		CLUB,
		HAMMER,
		KATANA,
		WAKAZASHI,
		HALBERD,
		GREATSWORD,
		GREATCLUB,
		FLAIL,
		MORNINGSTAR,
		CENSER,
		RAPIER,
		MODULE,
		PUPPET,
		SOUL,
		FORMULA,
		ABACUS,
		NUNCHUCK,
		SAP,
		STEIN,
		LONGSWORD,
		BOMB,
		DICE,
		CANNON,
		HARPOON,
		MAIN_GAUCHE
	}
	private WeaponTypes weaponType;
	private int spellEffectID;

	public WeaponTypes WeaponType{
		get{return weaponType;}
		set{weaponType = value;}
	}
	public int SpellEffectID{
		get{return spellEffectID;}
		set{spellEffectID = value;}
	}
}
