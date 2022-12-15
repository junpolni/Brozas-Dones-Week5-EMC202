using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public PlayerClass playerClass;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce = 20f;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = playerClass.weaponSprite;
    }

    public void Fire()
    {
        //GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        GameObject bullet = ObjectPool.instance.GetPooledObejct();

        if (bullet != null)
        {
            bullet.transform.position = firePoint.position;
            bullet.SetActive(true);
        }

        //bullet.BulletDamage = BulletDamage;
        
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }
}
