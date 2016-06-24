using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	float timeLeft = 85f;

	public delegate void TimerStop();
	public static event TimerStop OnTimerStop;
    void Start()
    {
        StartCoroutine(timer());
    }
	void Update()
	{
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
    IEnumerator timer()
    {
        yield return new WaitForSeconds(1);
        timeLeft--;
        StartCoroutine(timer());
    }
}
