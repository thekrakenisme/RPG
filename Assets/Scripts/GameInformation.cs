using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	//attach this script to an object in the scene
	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}
	
	public static string PlayerName{get;set;}
	public static int PlayerLevel{get;set;}
	public static BaseCharacterClass PlayerClass{get;set;}
	public static int Stamina{get;set;}
	public static int Dexterity{get;set;}
	public static string Strength{get;set;}
	public static string Intellect{get;set;}
	public static string Wisdom{get;set;}
	public static string Luck{get;set;}
	public static string Occult{get;set;}
}
