using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

	private BaseEquipment newEquipment;
	private string[] itemNames = new string[5]{"Common", "Uncommon", "Rare", "Epic", "Legendary"};
	private string[] itemDescription = new string[2] {"Description1", "Description2"};

	// Use this for initialization
	void Start () {
		CreateEquipment();
		Debug.Log (newEquipment.ItemName);
		Debug.Log (newEquipment.ItemDescription);
		Debug.Log (newEquipment.ItemID.ToString());
		Debug.Log (newEquipment.EquipmentType.ToString());
		Debug.Log (newEquipment.Stamina.ToString());
		Debug.Log (newEquipment.Dexterity.ToString());
		Debug.Log (newEquipment.Strength.ToString());
		Debug.Log (newEquipment.Luck.ToString());
		Debug.Log (newEquipment.Intellect.ToString());
		Debug.Log (newEquipment.Wisdom.ToString());
		Debug.Log (newEquipment.Occult.ToString());
	}

	private void CreateEquipment(){
		newEquipment = new BaseEquipment();
		newEquipment.ItemName = itemNames[Random.Range(0,4)] + " item";
		newEquipment.ItemID = Random.Range(1,101);
		ChooseItemType();
		newEquipment.ItemDescription = itemDescription[Random.Range(0,itemDescription.Length)];
		newEquipment.Strength = Random.Range(1,10);
		newEquipment.Stamina = Random.Range(1,10);
		newEquipment.Dexterity = Random.Range(1,10);
		newEquipment.Occult = Random.Range(1,10);
		newEquipment.Intellect = Random.Range(1,10);
		newEquipment.Wisdom = Random.Range(1,10);
		newEquipment.Luck = Random.Range(1,10);
	}

	private void ChooseItemType(){
		int randomTemp = Random.Range(1,15);
		if(randomTemp == 1){
		newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
		}else if(randomTemp == 2){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
		}else if(randomTemp == 3){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CAPE;
		}else if(randomTemp == 4){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
		}else if(randomTemp == 5){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.ARMS;
		}else if(randomTemp == 6){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
		}else if(randomTemp == 7){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
		}else if(randomTemp == 8){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EARRING_LEFT;
		}else if(randomTemp == 9){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EARRING_RIGHT;	
		}else if(randomTemp == 10){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING_LEFT;	
		}else if(randomTemp == 11){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING_RIGHT;	
		}else if(randomTemp == 12){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECKLACE;	
		}else if(randomTemp == 13){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.WAIST;	
		}else if(randomTemp == 14){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHIELD;
		}
	}
	

	// Update is called once per frame
	void Update () {
	
	}

}
