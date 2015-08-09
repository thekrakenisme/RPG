using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem {

	private int stamina;
	private int dexterity;
	private int strength;
	private int intellect;
	private int wisdom;
	private int luck;
	private int occult;

	public int Stamina{
		get{return stamina;}
		set{stamina = value;}
	}
	public int Dexterity{
		get{return dexterity;}
		set{dexterity = value;}
	}
	public int Strength{
		get{return strength;}
		set{strength = value;}
	}
	public int Intellect{
		get{return intellect;}
		set{intellect = value;}
	}
	public int Wisdom{
		get{return wisdom;}
		set{wisdom = value;}
	}
	public int Luck{
		get{return luck;}
		set{luck = value;}
	}
	public int Occult{
		get{return occult;}
		set{occult = value;}
	}
}
