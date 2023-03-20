using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    public int endGameTimer = 20;
    public TextMeshProUGUI timerText;
    public TextMeshPro bigTimerText;
    public FirstPersonController firstPersonController;
    public TextMeshProUGUI decompte;
    private int delayOfTimer;
    private void Start()
    {
        firstPersonController = FindObjectOfType<FirstPersonController>();
        StartCoroutine(BeforeGame());
        timerText.text = endGameTimer + " seconds";
        //bigTimerText.text = endGameTimer.ToString();
    }
    IEnumerator BeforeGame()
    {
        firstPersonController.playerCanMove = false;
        decompte.text = "4";
        yield return new WaitForSeconds(1);
        decompte.text = "3";
        yield return new WaitForSeconds(1);
        decompte.text = "2";
        yield return new WaitForSeconds(1);
        decompte.text = "1";
        yield return new WaitForSeconds(1);
        firstPersonController.playerCanMove = true;
        decompte.text = "Catch all coins!";
        StartCoroutine(EndGame());
        yield return new WaitForSeconds(3);
        decompte.text = " ";
    }
    public void AddTime()
    {
        endGameTimer = endGameTimer + 10;
    }
    IEnumerator EndGame()
    {
        while (endGameTimer > 0)
        {
            yield return new WaitForSeconds(1);
            endGameTimer--;
            timerText.text = endGameTimer + " seconds";
            //bigTimerText.text = endGameTimer.ToString();
            if(endGameTimer < 7)
                timerText.color = Color.red;
            else if(endGameTimer < 14)
                timerText.color = Color.yellow;
            else if(endGameTimer > 14)
                timerText.color = Color.green;
            if(endGameTimer == 0)
                SceneManager.LoadScene("Fini");
        }
    }
}