using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isBloodmageClass;
	private bool isCursedClass;
	private bool isDoppelgangerClass;
	private bool isEnchanterClass;
	private bool isGraverobberClass;
	private bool isKunoichiClass;
	private bool isMathematicianClass;
	private bool isMediumClass;
	private bool isScavengerClass;
	private bool isSyntheticClass;
	private bool isThoughtleechClass;
	private bool isTrancendantClass;
	private string playerName = "EnterName";

	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		playerName = GUILayout.TextField(playerName,15);
		if(GUILayout.Toggle(isBloodmageClass, "Bloodmage Class")){
			isBloodmageClass = true;
			isCursedClass = false;
			isDoppelgangerClass = false;
			isEnchanterClass = false;
			isGraverobberClass = false;
			isKunoichiClass = false;
			isMathematicianClass = false;
			isMediumClass = false;
			isScavengerClass = false;
			isThoughtleechClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isCursedClass, "Cursed Class")){
			isCursedClass = true;
			isBloodmageClass = false;
			isDoppelgangerClass = false;
			isEnchanterClass = false;
			isGraverobberClass = false;
			isKunoichiClass = false;
			isMathematicianClass = false;
			isMediumClass = false;
			isScavengerClass = false;
			isThoughtleechClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isDoppelgangerClass, "Doppelganger Class")){
			isDoppelgangerClass = true;
			isCursedClass = false;
			isBloodmageClass = false;
			isEnchanterClass = false;
			isGraverobberClass = false;
			isKunoichiClass = false;
			isMathematicianClass = false;
			isMediumClass = false;
			isScavengerClass = false;
			isThoughtleechClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isEnchanterClass, "Enchanter Class")){
			isEnchanterClass = true;
			isCursedClass = false;
			isDoppelgangerClass = false;
			isBloodmageClass = false;
			isGraverobberClass = false;
			isKunoichiClass = false;
			isMathematicianClass = false;
			isMediumClass = false;
			isScavengerClass = false;
			isThoughtleechClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isGraverobberClass, "Graverobber Class")){
			isGraverobberClass = true;
			isCursedClass = false;
			isDoppelgangerClass = false;
			isEnchanterClass = false;
			isBloodmageClass = false;
			isKunoichiClass = false;
			isMathematicianClass = false;
			isMediumClass = false;
			isScavengerClass = false;
			isThoughtleechClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isKunoichiClass, "Kunoichi Class")){
			isKunoichiClass = true;
			isCursedClass = false;
			isDoppelgangerClass = false;
			isEnchanterClass = false;
			isGraverobberClass = false;
			isBloodmageClass = false;
			isMathematicianClass = false;
			isMediumClass = false;
			isScavengerClass = false;
			isThoughtleechClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isMathematicianClass, "Mathematician Class")){
			isMathematicianClass = true;
			isCursedClass = false;
			isDoppelgangerClass = false;
			isEnchanterClass = false;
			isGraverobberClass = false;
			isKunoichiClass = false;
			isBloodmageClass = false;
			isMediumClass = false;
			isScavengerClass = false;
			isThoughtleechClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isMediumClass, "Medium Class")){
			isMediumClass = true;
			isCursedClass = false;
			isDoppelgangerClass = false;
			isEnchanterClass = false;
			isGraverobberClass = false;
			isKunoichiClass = false;
			isMathematicianClass = false;
			isBloodmageClass = false;
			isScavengerClass = false;
			isThoughtleechClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isScavengerClass, "Scavenger Class")){
			isScavengerClass = true;
			isCursedClass = false;
			isDoppelgangerClass = false;
			isEnchanterClass = false;
			isGraverobberClass = false;
			isKunoichiClass = false;
			isMathematicianClass = false;
			isMediumClass = false;
			isBloodmageClass = false;
			isThoughtleechClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isThoughtleechClass, "Thoughtleech Class")){
			isThoughtleechClass = true;
			isCursedClass = false;
			isDoppelgangerClass = false;
			isEnchanterClass = false;
			isGraverobberClass = false;
			isKunoichiClass = false;
			isMathematicianClass = false;
			isMediumClass = false;
			isScavengerClass = false;
			isBloodmageClass = false;
			isTrancendantClass = false;
		}
		if(GUILayout.Toggle(isTrancendantClass, "Trancendant Class")){
			isTrancendantClass = true;
			isCursedClass = false;
			isDoppelgangerClass = false;
			isEnchanterClass = false;
			isGraverobberClass = false;
			isKunoichiClass = false;
			isMathematicianClass = false;
			isMediumClass = false;
			isScavengerClass = false;
			isThoughtleechClass = false;
			isBloodmageClass = false;
		}

		if(GUILayout.Button("Create")){
			if(isBloodmageClass){
				newPlayer.PlayerClass = new BaseBloodmageClass();
			}else if(isCursedClass){
				newPlayer.PlayerClass = new BaseCursedClass();
			}else if(isDoppelgangerClass){
				newPlayer.PlayerClass = new BaseDoppelgangerClass();
			}else if(isEnchanterClass){
				newPlayer.PlayerClass = new BaseEnchanterClass();
			}else if(isGraverobberClass){
				newPlayer.PlayerClass = new BaseGraverobberClass();
			}else if(isKunoichiClass){
				newPlayer.PlayerClass = new BaseKunoichiClass();
			}else if(isMathematicianClass){
				newPlayer.PlayerClass = new BaseMathematicianClass();
			}else if(isMediumClass){
				newPlayer.PlayerClass = new BaseMediumClass();
			}else if(isScavengerClass){
				newPlayer.PlayerClass = new BaseScavengerClass();
			}else if(isThoughtleechClass){
				newPlayer.PlayerClass = new BaseThoughtleechClass();
			}else if(isTrancendantClass){
				newPlayer.PlayerClass = new BaseTrancendantClass();
			}
			newPlayer.PlayerLevel = 1;
			newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
			newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
			newPlayer.Strength = newPlayer.PlayerClass.Strength;
			newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
			newPlayer.Wisdom = newPlayer.PlayerClass.Wisdom;
			newPlayer.Luck = newPlayer.PlayerClass.Luck;
			newPlayer.Occult = newPlayer.PlayerClass.Occult;
			newPlayer.PlayerName = playerName;
			Debug.Log("Player Name: " + newPlayer.PlayerName);
			Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
			Debug.Log("Player Level: " + newPlayer.PlayerLevel);
			Debug.Log("Stamina: " + newPlayer.Stamina);
			Debug.Log("Dexterity: " + newPlayer.Dexterity);
			Debug.Log("Strength: " + newPlayer.Strength);
			Debug.Log("Intellect: " + newPlayer.Intellect);
			Debug.Log("Wisdom: " + newPlayer.Wisdom);
			Debug.Log("Luck: " + newPlayer.Luck);
			Debug.Log("Occult: " + newPlayer.Occult);
		}

	}
}
