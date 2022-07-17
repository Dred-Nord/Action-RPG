using Godot;
using System;

public abstract class ItemObject
{
	private static int IDS;
	public int ID { get; set; } = IDS++;
	public string UID { get; set; }
	public string name { get; set; }
	public string description { get; set; }
	public float weight { get; set; }
	public int sizeX { get; set; }
	public int sizeY { get; set; }
	public int quanity { get; set; }
	public int cost { get; set; }
}

public class WeaponItem : ItemObject
{
	public float damage { get; set; }
	public float defence { get; set; }
	
	public WeaponItem(string name, string description, float weight, int sizeX, int sizeY, int cost)
	{
		this.ID = IDS;
		this.UID = null;
		this.name = name;
		this.description = description;
		this.weight = weight;
		this.sizeX = sizeX;
		this.sizeY = sizeY;
		this.quanity = 1;
		this.cost = cost;
	} // Item generation 
	public WeaponItem(WeaponItem item, int quanity)
	{
		this.ID = item.ID;
		this.UID = Guid.NewGuid().ToString();
		this.name = item.name;
		this.description = item.description;
		this.weight = item.weight;
		this.sizeX = item.sizeX;
		this.sizeY = item.sizeY;
		this.quanity = quanity;
		this.cost = item.cost;
	} // Adding to inventory
} 
public class BookItem : ItemObject
{
	Dictionary <Attribute, float> increaseAttribute = new Dictionary<Attribute, float>();
	
	public BookItem(string name, string description, float weght, int sizeX, int sizeY, int cost)
	{
		this.ID = IDS;
		this.UID = null;
		this.name = name;
		this.description = description;
		this.weight = weight;
		this.sizeX = sizeX;
		this.sizeY = sizeY;
		this.quanity = 1;
		this.cost = cost;
	}
}

