using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;
	private string[] itemNames = new string[5]{"Common", "Uncommon", "Rare", "Epic", "Legendary"};
	private string[] itemDescription = new string[2] {"Description1", "Description2"};

	void Start(){
		CreateWeapon();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.ItemDescription);
		Debug.Log (newWeapon.ItemID.ToString());
		Debug.Log (newWeapon.WeaponType.ToString());
		Debug.Log (newWeapon.Stamina.ToString());
		Debug.Log (newWeapon.Dexterity.ToString());
		Debug.Log (newWeapon.Strength.ToString());
		Debug.Log (newWeapon.Luck.ToString());
		Debug.Log (newWeapon.Intellect.ToString());
		Debug.Log (newWeapon.Wisdom.ToString());
		Debug.Log (newWeapon.Occult.ToString());

	}

	public void CreateWeapon(){

		newWeapon = new BaseWeapon();
		//assign a name to the weapon
		newWeapon.ItemName = itemNames[Random.Range(0,4)] + " weapon";
		//create a weapon description
		newWeapon.ItemDescription = itemDescription[Random.Range(0,itemDescription.Length)];
		//weapon ID
		newWeapon.ItemID = Random.Range(1,101);
		//stats
		newWeapon.Strength = Random.Range(1,10);
		newWeapon.Stamina = Random.Range(1,10);
		newWeapon.Dexterity = Random.Range(1,10);
		newWeapon.Occult = Random.Range(1,10);
		newWeapon.Intellect = Random.Range(1,10);
		newWeapon.Wisdom = Random.Range(1,10);
		newWeapon.Luck = Random.Range(1,10);
		//choose type of weapon
		ChooseWeaponType();
		//spell effect ID
		newWeapon.SpellEffectID = Random.Range(1,101);
	}

	private void ChooseWeaponType(){
		int randomTemp = Random.Range(1,39);
		if(randomTemp == 1){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHORTSWORD;
		}
		else if(randomTemp == 2){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.LONGSWORD;
		}
		else if(randomTemp == 3){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAVE;
		}
		else if(randomTemp == 4){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.GUN;
		}
		else if(randomTemp == 5){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.KNUCKLES;
		}
		else if(randomTemp == 6){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.TOME;
		}
		else if(randomTemp == 7){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.WHIP;
		}
		else if(randomTemp == 8){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		}
		else if(randomTemp == 9){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.CROSSBOW;
		}
		else if(randomTemp == 10){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOOMERANG;
		}
		else if(randomTemp == 11){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHOVEL;
		}
		else if(randomTemp == 12){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.ORB;
		}
		else if(randomTemp == 13){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.AXE;
		}
		else if(randomTemp == 14){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.CLUB;
		}
		else if(randomTemp == 15){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.HAMMER;
		}
		else if(randomTemp == 16){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.KATANA;
		}
		else if(randomTemp == 17){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.WAKAZASHI;
		}
		else if(randomTemp == 18){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.HALBERD;
		}
		else if(randomTemp == 19){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.GREATSWORD;
		}
		else if(randomTemp == 20){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.GREATCLUB;
		}
		else if(randomTemp == 21){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.FLAIL;
		}
		else if(randomTemp == 22){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.MORNINGSTAR;
		}
		else if(randomTemp == 23){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.CENSER;
		}
		else if(randomTemp == 24){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.RAPIER;
		}
		else if(randomTemp == 25){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.MODULE;
		}
		else if(randomTemp == 26){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.PUPPET;
		}
		else if(randomTemp == 27){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SOUL;
		}
		else if(randomTemp == 28){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.FORMULA;
		}
		else if(randomTemp == 29){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.ABACUS;
		}
		else if(randomTemp == 30){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.NUNCHUCK;
		}
		else if(randomTemp == 31){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SAP;
		}
		else if(randomTemp == 32){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STEIN;
		}
		else if(randomTemp == 33){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOMB;
		}
		else if(randomTemp == 34){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.DICE;
		}
		else if(randomTemp == 35){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.CANNON;
		}
		else if(randomTemp == 36){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.HARPOON;
		}
		else if(randomTemp == 37){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.MAIN_GAUCHE;
		}
		else if(randomTemp == 38){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
		}
	}
}
