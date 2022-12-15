using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public PlayerClass playerClass;

    public TextMeshProUGUI playerTypeText;

    // Start is called before the first frame update
    void Start()
    {
        playerTypeText.text = playerClass.playerType;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
