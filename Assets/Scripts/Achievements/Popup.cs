using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]


public class Popup : MonoBehaviour
{  
    //[SerializeField] private GameObject Window1;
    //[SerializeField] private GameObject Window2;

    public UnityEvent destroyEnemy;

    [SerializeField] private Animator m_animator;
    [SerializeField] private Animator m_animator2;
    
    /*public TextMeshProUGUI pointsText, clickstext;

    [SerializeField] private int points, clicks; */

    public static int enemyCount;
    
    public TextMeshProUGUI enemyScore;

    /* public bool scored100, clicked15;
    public bool pointaschievementshowed, clickachievementshowed; */

    public bool enemyScored100;
    public bool enemyScoreAchievementShowed;
    
    /*private void Awake()
    {
        m_animator = gameObject.GetComponent<Animator>()

    }*/

    void Start()
    {
        enemyCount = 0;
    }

    void Update()
    {
        /* pointsText.text = "points: " + points;
        clickstext.text = "Clicks: " + clicks;*/

        enemyScore.text = $"SCORE: {enemyCount}";

        EnemyScoring();

        /*if(points >= 100)
        {
            scored100 = true;
        }

        if(clicks >= 15)
        {
            clicked15 = true;
        }

        if(clicked15 == true && pointaschievementshowed == false)
        {
            m_animator.SetTrigger("A1");
            m_animator.SetTrigger("A1done");
            //OpenWindow1();
        }

       if(scored100 == true && clickachievementshowed == false)
        {
            m_animator2.SetTrigger("A2");
            m_animator2.SetTrigger("A1done");
            //OpenWindow2();
        } */
    }

    /*public void OpenWindow1()
    {
        Window1.SetActive(true);
    }
    public void OpenWindow2()
    {
        Window1.SetActive(true);
    }

    public void CloseWindow()
    {
        Window1.SetActive(false);
        Window2.SetActive(false);
    }*/

    private void EnemyScoring()
    {
        if(enemyCount >= 100)
        {
            enemyScored100 = true;
        }

        if(enemyScored100 == true && enemyScoreAchievementShowed == false)
        {
            m_animator.SetTrigger("A1");
            m_animator.SetTrigger("A1done");
            //OpenWindow1();
        }
    }

    /*public void EnemyDeaths()
    {
        /*clicks++;
        points += 5;

        enemyCount ++;
    } */
}
