using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyUI : MonoBehaviour
{
    int enemyCount;

    /*public static int enemyCount = 0;

    public TextMeshProUGUI enemyScore;

    void Start()
    {
        enemyScore = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        enemyScore.text = $"SCORE: {enemyCount}";
    } */


    public void IncrementEnemycount()
    {
        enemyCount++;
        GetComponent<TextMeshProUGUI>().text = $"SCORE: {enemyCount}";
    }
}
