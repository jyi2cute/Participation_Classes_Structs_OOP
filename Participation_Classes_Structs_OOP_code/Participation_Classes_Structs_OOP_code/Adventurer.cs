using System;

public class Adventurer
{
	public string name;
	public int experience = 0;
	public Adventurer()
	{
		Reset();
	}

	public Adventurer(string name)
	{
		this.name = name;
	}

	public virtual void PrintStatsInfo()
	{
		Console.WriteLine("Adventurer: " + this.name + " - " + this.experience + " EXP");
	}

	private void Reset()
	{
		this.name = "Not Assigned";
		this.experience = 0;
	}
}
