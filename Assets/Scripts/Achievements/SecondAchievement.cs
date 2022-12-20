using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Animator))]


public class SecondAchievement : MonoBehaviour
{  
    //[SerializeField] private GameObject Window1;
    //[SerializeField] private GameObject Window2;

    [SerializeField] private Animator m_animator;
    [SerializeField] private Animator m_animator2;

    public static int playerCount;

    public bool playerDeath;
    public bool playerDeathAchievementShowed;
    
    /*private void Awake()
    {
        m_animator = gameObject.GetComponent<Animator>()

    }*/

    void Start()
    {
        playerCount = 1;
    }

    void Update()
    {
        PlayerDies();
    }

    private void PlayerDies()
    {
        if (playerCount < 1)
        {
            playerDeath = true;
        }

        if (playerDeath == true && playerDeathAchievementShowed == false)
        {
            m_animator.SetTrigger("A1");
            m_animator.SetTrigger("A1done");
        }
    }
}
