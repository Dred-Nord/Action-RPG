using Godot;
using System;
using System.Collections.Generic;

public class Fraction
{
	public string UID { get; set; }
	public string name { get; set; }
	public Sprite emblem { get; set; }
	public float power { get; set; }
	private List<Member> members;
	public int memberCount { get; set; }
	public float assets { get; set; }
	public float reputation { get; set; }
	public Dictionary<Character, float> test = new Dictionary<Character, float>();
	
	public Fraction(string name, Sprite emblem)
	{
		this.UID = Guid.NewGuid().ToString();
		this.name = name;
		this.emblem = emblem;
		float floatPowerBuffer = 0;
		foreach(Member member in members) { floatPowerBuffer += member.power; }
		this.power = floatPowerBuffer;
		float 
	}
	// Территория 
}
// Methods.CreateFraction // Fraction.Create
