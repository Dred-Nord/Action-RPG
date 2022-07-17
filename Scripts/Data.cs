using Godot;
using System;
using System.Collections.Generic;

public static class Data
{
	public static List<ItemObject> items = new List<ItemObject>()
	{
		new WeaponItem("Sword", "Iron Sword", 1.5f, 1, 2, 250),
		new WeaponItem("Sabre", "Steel Sabre", 0.5f, 1, 2, 400)
	};
	public static List<Character> sceneCharacters = new List<Chracter>()
	{
		new Player("")
		new NPC("Adolf Hitler", true, "Fuhrer", test)
	};
	public static List<Fraction> fractions = new List<Fraction>()
	{
		
	};
}
