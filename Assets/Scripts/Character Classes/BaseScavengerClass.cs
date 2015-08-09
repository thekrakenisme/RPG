using UnityEngine;
using System.Collections;

public class BaseScavengerClass : BaseCharacterClass {
	
	public BaseScavengerClass(){
		CharacterClassName = "Scavenger";
		CharacterClassDescription = "Pieces together forgotten technology.";
		Stamina = 1;
		Dexterity = 1;
		Strength = 1;
		Intellect = 1;
		Wisdom = 2;
		Luck = 2;
		Occult = 1;
		
	}
}
