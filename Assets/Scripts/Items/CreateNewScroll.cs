using UnityEngine;
using System.Collections;

public class CreateNewScroll : MonoBehaviour {

	private BaseScroll newScroll;
	private string[] itemNames = new string[5]{"Common", "Uncommon", "Rare", "Epic", "Legendary"};
	private string[] itemDescription = new string[2] {"Description1", "Description2"};

	// Use this for initialization
	void Start () {
		CreateScroll();
		Debug.Log (newScroll.ItemName);
		Debug.Log (newScroll.ItemDescription);
		Debug.Log (newScroll.ItemID.ToString());
		Debug.Log (newScroll.ScrollType.ToString());

	}
	private void CreateScroll(){
		newScroll = new BaseScroll();
		newScroll.ItemName = itemNames[Random.Range(0,4)] + " scroll";
		newScroll.ItemDescription = itemDescription[Random.Range(0,itemDescription.Length)];
		newScroll.ItemID = Random.Range(1,101);
		ChooseScrollType();
		newScroll.SpellEffectID = Random.Range(1,101);
	}
	private void ChooseScrollType(){
		int randomTemp = Random.Range(1,4);
		if(randomTemp == 1){
			newScroll.ScrollType = BaseScroll.ScrollTypes.SUMMON;
		}else if(randomTemp == 2){
			newScroll.ScrollType = BaseScroll.ScrollTypes.MAP;
		}else if(randomTemp == 3){
			newScroll.ScrollType = BaseScroll.ScrollTypes.TREASURE;
		}
	}
}
