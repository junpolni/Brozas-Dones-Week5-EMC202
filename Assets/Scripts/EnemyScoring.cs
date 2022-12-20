using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyScoring : MonoBehaviour
{

    public UnityEvent destroyEnemy;

    public GameObject enemyPrefabs;

    // Update is called once per frame
    void Update()
    {
        destroyEnemy.Invoke();
    }

}
