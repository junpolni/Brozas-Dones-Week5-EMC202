using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject saveDisplayText;

    [SerializeField] GameObject deathPanel;

    void Start()
    {
        saveDisplayText.SetActive(false);
    }

    public void ToggleDeathPanel()
    {
        deathPanel.SetActive(!deathPanel.activeSelf);
    }

    public void SaveGame() //to display "game saved" text
    {
        saveDisplayText.SetActive(true);

    }

    public void Clear()
    {
        saveDisplayText.SetActive(false);
    }
}
