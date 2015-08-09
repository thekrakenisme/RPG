using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

	private BaseCharacterClass class1 = new BaseTrancendantClass();
	private BaseCharacterClass class2 = new BaseGraverobberClass();
	private BaseCharacterClass class3 = new BaseThoughtleechClass();
	private BaseCharacterClass class4 = new BaseSyntheticClass();
	private BaseCharacterClass class5 = new BaseMediumClass();
	private BaseCharacterClass class6 = new BaseDoppelgangerClass();
	private BaseCharacterClass class7 = new BaseCursedClass();
	private BaseCharacterClass class8 = new BaseBloodmageClass();
	private BaseCharacterClass class9 = new BaseEnchanterClass();
	private BaseCharacterClass class10 = new BaseScavengerClass();
	private BaseCharacterClass class11 = new BaseKunoichiClass();
	private BaseCharacterClass class12 = new BaseMathematicianClass();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUILayout.Label(class1.CharacterClassName);
		GUILayout.Label(class1.CharacterClassDescription);
		GUILayout.Label(class1.Intellect.ToString()); //int value needs to be converted to strings with .ToString()
		GUILayout.Label(class2.CharacterClassName);
		GUILayout.Label(class2.CharacterClassDescription);
		GUILayout.Label(class2.Intellect.ToString());
		GUILayout.Label(class3.CharacterClassName);
		GUILayout.Label(class3.CharacterClassDescription);
		GUILayout.Label(class4.CharacterClassName);
		GUILayout.Label(class4.CharacterClassDescription);
		GUILayout.Label(class5.CharacterClassName);
		GUILayout.Label(class5.CharacterClassDescription);
		GUILayout.Label(class6.CharacterClassName);
		GUILayout.Label(class6.CharacterClassDescription);
		GUILayout.Label(class7.CharacterClassName);
		GUILayout.Label(class7.CharacterClassDescription);
		GUILayout.Label(class8.CharacterClassName);
		GUILayout.Label(class8.CharacterClassDescription);
		GUILayout.Label(class9.CharacterClassName);
		GUILayout.Label(class9.CharacterClassDescription);
		GUILayout.Label(class10.CharacterClassName);
		GUILayout.Label(class10.CharacterClassDescription);
		GUILayout.Label(class11.CharacterClassName);
		GUILayout.Label(class11.CharacterClassDescription);
		GUILayout.Label(class12.CharacterClassName);
		GUILayout.Label(class12.CharacterClassDescription);
	}
}
