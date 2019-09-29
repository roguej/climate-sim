using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeKeeper : MonoBehaviour
{
	[Range(0f,60f)]
	[Tooltip("How long, in minutes, each day should last. Max length is one hour.")]
    public float dayLength = 5.0f;
	
	[Tooltip("Increments at each sunrise")]
    public int currentDay = 0;
		
	public int yearLength = 30; //Homage to digimon world :)

	[Tooltip("Increments after the year length has ended")]
    public int currentYear = 0;
	
	[Range(0f, 1f)]
	public float currentTime;
	
	public bool pause = false;
	private Climate climate;

    [Tooltip("Need to manually set this in the editor")]
    public Text yearDisplay;
	
	void Start()
	{
        climate = GetComponentInParent<Climate>();
        displayDay();

    }

    void Update()
    {
		if(!pause)
		{
			UpdateTime();
		}     
        
    }
	
	void UpdateTime()
	{
		if(dayLength > 0)
		{
			float scale = 24 / (dayLength / 60); //scale real time to game time
			currentTime += Time.deltaTime * scale / 86400;
			
			float sunAngle = currentTime * 360f;
			transform.localRotation = Quaternion.Euler(new Vector3(sunAngle, 0));
			
			if(currentTime > 1)
			{
				currentDay++;
                displayDay();
                if (currentDay > yearLength)
                {
                    currentYear++;
                    currentDay = 0;
                    displayDay();
                }
				currentTime = 0;
                climate.incrementDay();
			}
		}
		else
		{
			pause = true;
		}
	}

    void displayDay()
    {

        yearDisplay.text = string.Format("Year {0} Day {1}", currentYear, currentDay);
    }


}
