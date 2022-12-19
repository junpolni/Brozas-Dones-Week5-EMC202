using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Animator))]


public class Popup : MonoBehaviour
{   //[SerializeField] private GameObject Window1;
    //[SerializeField] private GameObject Window2;

    [SerializeField] private Animator m_animator;
    [SerializeField] private Animator m_animator2;
    public TextMeshProUGUI pointsText, clickstext;

    [SerializeField] private int points, clicks;
    public bool scored100, clicked15;
    public bool pointaschievementshowed, clickachievementshowed;

    /*private void Awake()
    {
        m_animator = gameObject.GetComponent<Animator>()

    }*/

    void Update()
    {
        pointsText.text = "points: " + points;
        clickstext.text = "Clicks: " + clicks;

        if(points >= 100)
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
        }
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

    public void Click()
    {
        clicks++;
        points += 5;
    }
}
