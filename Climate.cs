using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Climate : MonoBehaviour
{
	[System.Serializable]
	public class Season
	{
		public int numberDays;
		public string name;
		//array of particle effects for the weather
	}
	
	public Season[] possibleSeasons;
	public Season currentSeason;
	public int index = 0;
	private int currentDay = 0;

    [Tooltip("Need to manually set this in the editor")]
    public Text seasonDisplay;

    private void Start()
    {
        currentSeason = possibleSeasons[index];
        displaySeason();
    }

    void incrementSeason()
	{
		index++;
		if(index >= possibleSeasons.Length)
		{
			index = 0;
		}
		currentSeason = possibleSeasons[index];
        displaySeason();

    }

	
	public void incrementDay()
	{
		currentDay++;
		if(currentDay > currentSeason.numberDays)
		{
			incrementSeason();
			currentDay = 0;
            displaySeason();

        }
	}

    void displaySeason()
    {
        seasonDisplay.text = string.Format("{0} Day {1}",currentSeason.name, currentDay);
    }
}