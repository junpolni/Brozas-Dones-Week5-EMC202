using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //[HideInInspector] public float BulletDamage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(gameObject);

        if(collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }

        gameObject.SetActive(false);
    }
}
