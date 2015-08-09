using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;
	private string[] itemNames = new string[5]{"Common", "Uncommon", "Rare", "Epic", "Legendary"};
	private string[] itemDescription = new string[2] {"Description1", "Description2"};

	// Use this for initialization
	void Start () {
		CreatePotion();
		Debug.Log (newPotion.ItemName);
		Debug.Log (newPotion.ItemDescription);
		Debug.Log (newPotion.ItemID.ToString());
		Debug.Log (newPotion.PotionType.ToString());
		Debug.Log (newPotion.Stamina.ToString());
		Debug.Log (newPotion.Dexterity.ToString());
		Debug.Log (newPotion.Strength.ToString());
		Debug.Log (newPotion.Luck.ToString());
		Debug.Log (newPotion.Intellect.ToString());
		Debug.Log (newPotion.Wisdom.ToString());
		Debug.Log (newPotion.Occult.ToString());
	}

	private void CreatePotion(){
		newPotion = new BasePotion();
		newPotion.ItemName = itemNames[Random.Range(0,4)] + " potion";
		newPotion.ItemDescription = itemDescription[Random.Range(0,itemDescription.Length)];
		newPotion.ItemID = Random.Range(1,101);
		newPotion.Strength = Random.Range(1,10);
		newPotion.Stamina = Random.Range(1,10);
		newPotion.Dexterity = Random.Range(1,10);
		newPotion.Occult = Random.Range(1,10);
		newPotion.Intellect = Random.Range(1,10);
		newPotion.Wisdom = Random.Range(1,10);
		newPotion.Luck = Random.Range(1,10);
		ChoosePotionType();
		newPotion.SpellEffectID = Random.Range(1,101);
	}

	private void ChoosePotionType(){
		int randomTemp = Random.Range(1,33);
		if(randomTemp == 1){
			newPotion.PotionType = BasePotion.PotionTypes.HP;
		}else if(randomTemp == 2){
			newPotion.PotionType = BasePotion.PotionTypes.HP_REGEN;
		}else if(randomTemp == 3){
			newPotion.PotionType = BasePotion.PotionTypes.MAX_HP;
		}else if(randomTemp == 4){
			newPotion.PotionType = BasePotion.PotionTypes.FOCUS;
		}else if(randomTemp == 5){
			newPotion.PotionType = BasePotion.PotionTypes.FOCUS_REGEN;
		}else if(randomTemp == 6){
			newPotion.PotionType = BasePotion.PotionTypes.MAX_FOCUS;
		}else if(randomTemp == 7){
			newPotion.PotionType = BasePotion.PotionTypes.MANA;
		}else if(randomTemp == 8){
			newPotion.PotionType = BasePotion.PotionTypes.MANA_REGEN;
		}else if(randomTemp == 9){
			newPotion.PotionType = BasePotion.PotionTypes.MAX_MANA;
		}else if(randomTemp == 10){
			newPotion.PotionType = BasePotion.PotionTypes.XP;
		}else if(randomTemp == 11){
			newPotion.PotionType = BasePotion.PotionTypes.XP_BONUS;
		}else if(randomTemp == 12){
			newPotion.PotionType = BasePotion.PotionTypes.LOVE;
		}else if(randomTemp == 13){
			newPotion.PotionType = BasePotion.PotionTypes.LEVEL_UP;
		}else if(randomTemp == 14){
			newPotion.PotionType = BasePotion.PotionTypes.AC;
		}else if(randomTemp == 15){
			newPotion.PotionType = BasePotion.PotionTypes.DAMAGE;
		}else if(randomTemp == 16){
			newPotion.PotionType = BasePotion.PotionTypes.DAMAGE_SHIELD;
		}else if(randomTemp == 17){
			newPotion.PotionType = BasePotion.PotionTypes.ACCURACY;
		}else if(randomTemp == 18){
			newPotion.PotionType = BasePotion.PotionTypes.INITIATIVE;
		}else if(randomTemp == 19){
			newPotion.PotionType = BasePotion.PotionTypes.ATTACKS;
		}else if(randomTemp == 20){
			newPotion.PotionType = BasePotion.PotionTypes.MUTATION;
		}else if(randomTemp == 21){
			newPotion.PotionType = BasePotion.PotionTypes.BOOZE;
		}else if(randomTemp == 22){
			newPotion.PotionType = BasePotion.PotionTypes.STEALTH;
		}else if(randomTemp == 23){
			newPotion.PotionType = BasePotion.PotionTypes.POISON;
		}else if(randomTemp == 24){
			newPotion.PotionType = BasePotion.PotionTypes.CONFUSION;
		}else if(randomTemp == 25){
			newPotion.PotionType = BasePotion.PotionTypes.BLINDNESS;
		}else if(randomTemp == 26){
			newPotion.PotionType = BasePotion.PotionTypes.STAMINA;
		}else if(randomTemp == 27){
			newPotion.PotionType = BasePotion.PotionTypes.INTELLECT;
		}else if(randomTemp == 28){
			newPotion.PotionType = BasePotion.PotionTypes.DEXTERITY;
		}else if(randomTemp == 29){
			newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
		}else if(randomTemp == 30){
			newPotion.PotionType = BasePotion.PotionTypes.LUCK;
		}else if(randomTemp == 31){
			newPotion.PotionType = BasePotion.PotionTypes.OCCULT;
		}else if(randomTemp == 32){
			newPotion.PotionType = BasePotion.PotionTypes.WISDOM;
		}
	}
}
