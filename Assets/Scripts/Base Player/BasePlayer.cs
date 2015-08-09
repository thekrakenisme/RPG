using UnityEngine;
using System.Collections;

public class BasePlayer {

	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;
	private int stamina;
	private int dexterity;
	private int strength;
	private int intellect;
	private int wisdom;
	private int luck;
	private int occult;

	public string PlayerName{get;set;}	
	public int PlayerLevel{get;set;}
	public BaseCharacterClass PlayerClass{get;set;}
	public int Stamina{get;set;}
	public int Dexterity{get;set;}
	public int Strength{get;set;}
	public int Intellect{get;set;}
	public int Wisdom{get;set;}
	public int Luck{get;set;}
	public int Occult{get;set;}
}
