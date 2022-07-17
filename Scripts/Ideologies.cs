using Godot;
using System;
using static Methods; // Method - Data.Ideologies.Find(); // findIdeology()

new Ideology("socialism", "Socialism", 10); // Generation to Data
new Ideology(findIdeology("socialism"), new Dictionary<Ideology, float>()
{
	findIdeology("liberalism") = 0,
	findIdeology("conservatism") = 0,
	findIdeology("communism") = 0,
	findIdeology("socialism") = 0,
}); // Processing

public class Ideology
{
	public Ideology(string ID, string name, float baseIntolerance)
	{
		this.ID = ID;
		this.name = name;
		this.baseIntolerance = baseIntolerance;
		this.ideologyTolerance = new Dictionary<Ideology, float>();
	} // Generation to Data
	public Ideology(Ideology ideology, Dictionary<Ideology, float> ideologyTolerance)
	{
		this.ID = ideology.ID;
		this.name = ideology.name;
		this.baseIntolerance = ideology.baseIntolerance;
		this.ideologyTolerance = ideologyTolerance;
	} // Processing

	public string ID { get; private set; }
	public string name { get; private set; }
	public float baseIntolerance { get; private set; }
	public Dictionary<Ideology, float> ideologyTolerance { get; private set; }
}
