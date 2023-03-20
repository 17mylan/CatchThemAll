using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DisplayStats : MonoBehaviour
{
    public TextMeshProUGUI displayStats;
    void Start()
    {
        displayStats.text = "You caught " + PlayerPrefs.GetInt("Coins") + " golds";
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}
