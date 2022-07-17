using Godot;
using System;
using System.Collections.Generic;

public class Inventory
{
	public float weight { get; set; }
	public int capacity { get; set; }
	
	public List<ItemObject> storage = new List<ItemObject>();
	public void AddItem(int ID, int quanity)
	{
		if (ExistsItem(ID))
			TryFindItem(ID).SetQuanity(TryFindItem(ID).quanity + quanity);
		else
			storage.Add(new WeaponItem((WeaponItem)TryFindDataItem(ID), quanity));
		CalculateWeight();
	}
	public bool ExistsItem(string ID) => storage.Exists(item => item.ID == ID);
	public ItemObject TryFindItem(string ID) => storage.Find(item => item.ID == ID);
