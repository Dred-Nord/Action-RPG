using Godot;
using System;

public abstract class Character
{
	public bool isMale { get; set; }
	public string UID { get; set; }
	public string name { get; set; }
	public Sex sex { get; set; }
	public float maximumHealthPoints { get; set; }
	public float healthPoints { get; set; }
	public float maximumStaminaPoints { get; set; }
	public float staminaPoints { get; set; }
	public string job { get; set; }
	public float carma { get; set; }
	public string confession { get; set; }
	public int cost { get; set; }
	
	public float strenght { get; set; }
	public float vitality { get; set;}
	public float toughness { get; set; }
	
	public float agility { get; set; }
	public float dexterety { get; set; }
	public float stealth { get; set; }
	
	public float intelligence { get; set; }
	public float charisma { get; set; }
	public float experience { get; set; }
	// Quests AliFe
	public Inventory inventory = new Inventory();
}
