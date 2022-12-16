using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    private void Start()
    {
        Instantiate(GameManager.instance.currentCharacter.playerPrefab, transform.position, Quaternion.identity);
    }
}
