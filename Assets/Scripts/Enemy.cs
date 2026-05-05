using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxEnemyHealth = 100.0f;
    public float enemyHealth;
    public float dmgMultiplier = 1.0f;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = maxEnemyHealth;
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            enemyHealth -= 10;
        }
        if (enemyHealth <= 0)
        {
            Destroy(enemy);
        }
    }
}
