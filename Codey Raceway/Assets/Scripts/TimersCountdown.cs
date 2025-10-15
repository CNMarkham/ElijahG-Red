using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    public CodeyMove codeyMove;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        

        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            codeyMove.Speed = 0;
        }

        if (totalCountdownTime < 1)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            codeyMove.Speed = 450;
        }




        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            
        }

        if (totalLapTime <= 0)
        {
            print("Time is up!");
            codeyMove.Speed = 0;
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("LoseScene");
        }

    }
}
