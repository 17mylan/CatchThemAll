using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip timeUp;
    public GameObject goldEarned;
    public ScoreManager scoreManager;
    public Timer timer;
    public GameObject timeUpPopup;
    private void Start()
    {
        PlayerPrefs.SetInt("Coins", 0);
        scoreManager = FindObjectOfType<ScoreManager>();
        timer = FindObjectOfType<Timer>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coins")
        {
            scoreManager.AddPoints(10);
            PlayerPrefs.SetInt("Coins", scoreManager.Score + 10);
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(audioClip);
            Instantiate(goldEarned, collision.transform.position, Quaternion.identity);
        }
        if(collision.gameObject.tag == "Timer")
        {
            Destroy(collision.gameObject);
            timer.AddTime();
            audioSource.PlayOneShot(timeUp);
            Instantiate(goldEarned, collision.transform.position, Quaternion.identity);
            StartCoroutine(timerAdd());
        }
    }
    IEnumerator timerAdd()
    {
        timeUpPopup.SetActive(true);
        yield return new WaitForSeconds(4);
        timeUpPopup.SetActive(false);
    }
}
