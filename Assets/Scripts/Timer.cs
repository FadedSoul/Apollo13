using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	float timeLeft = 80f;

	public delegate void TimerStop();
	public static event TimerStop OnTimerStop;

	void Update()
	{
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			if(OnTimerStop != null)
			{
				print("Fade should start");
				OnTimerStop();
			}
		}

		print(timeLeft);
	}
}
