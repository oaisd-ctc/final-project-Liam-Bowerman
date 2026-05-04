using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxEnemyHealth = 100.0f;
    [SerializeField] private float enemyHealth;
    public float dmgMultiplier = 1.0f;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = maxEnemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(enemy);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            EnemyTakeDamage();
        }
    }

    private void EnemyTakeDamage()
    {
        enemyHealth -= 10 * dmgMultiplier;
    }
}
