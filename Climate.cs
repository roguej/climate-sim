using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climate : MonoBehavior
{
	[System.Serializable]
	public class Season
	{
		public int numberDays;
		public String name;
		public Weather[] possibleWeather;
	}
	
	public Season[] possibleSeasons;
	public int currentSeason;
	
	void setSeason(int index)
	{
		currentSeason = index;
	}
	
	void displaySeason(Season season)
	{
		
	}
}