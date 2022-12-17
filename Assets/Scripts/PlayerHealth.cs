using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour, ISaveable
{
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;

    [SerializeField] private Slider healthSlider;

    private EnemySpawner enemySpawnManager;

    private void Start()
    {
        health = maxHealth;
        healthSlider.maxValue = maxHealth;

        enemySpawnManager = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
    }

    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0f)
        {
            health = 0f;
            healthSlider.value = health;
            enemySpawnManager.OnPlayerDeath();
            PlayerDied();
        }
    }

    private void PlayerDied()
    {
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }
    
    private void OnGUI()
    {
        float t = Time.deltaTime / 1f;
        healthSlider.value = Mathf.Lerp(healthSlider.value, health, t);
    }

    public object SaveState()
    {
        return new SaveData()
        {
            health = this.health,
            maxHealth = this.maxHealth
        };
    }

    public void LoadState(object state)
    {
        var saveData = (SaveData)state;
        health = saveData.health;
        maxHealth = saveData.maxHealth;
    }

    [Serializable]
    private struct SaveData
    {
        public float health;
        public float maxHealth;
    }
}
