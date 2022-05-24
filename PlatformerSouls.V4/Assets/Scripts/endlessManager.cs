using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessManager : MonoBehaviour
{
    int randomEnemy;
    int randomSpawn;
    public GameObject[] enemies;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    bool flip;
    Transform whichSpawn;

    float enemyTimer = 1f;

    GameObject newEnemy;


    void Start()
    {
        randomEnemy = Random.Range(0, 100);
        randomSpawn = Random.Range(0, 2);
    }
    // Update is called once per frame
    void Update()
    {
        if (randomSpawn == 0)
        {
            whichSpawn = spawnPoint1;
            flip = false;
        }
        if (randomSpawn == 1)
        {
            whichSpawn = spawnPoint2;
            flip = false;
        }
        if (randomEnemy <= 50 & enemyTimer <= 0)
        {
            newEnemy = Instantiate(enemies[0], whichSpawn.position, Quaternion.identity);
            newEnemy.GetComponent<EnemyFlip>().isFlipped = flip;
            newEnemy.GetComponent<EnemyFlip>().player = GameObject.FindGameObjectWithTag("Player").transform;
            newEnemy.GetComponent<EnemyAgro>().agroRange = 1000;
            newEnemy.GetComponent<EnemyAgro>().player = GameObject.FindGameObjectWithTag("Player").transform;
            randomEnemy = Random.Range(0, 100);
            randomSpawn = Random.Range(0, 2);
            enemyTimer = 0.5f;
        }

        if (randomEnemy > 50 & randomEnemy <= 85 & enemyTimer <= 0)
        {
            newEnemy = Instantiate(enemies[1], whichSpawn.position, Quaternion.identity);
            newEnemy.GetComponent<EnemyFlip>().isFlipped = flip;
            newEnemy.GetComponent<EnemyFlip>().player = GameObject.FindGameObjectWithTag("Player").transform;
            newEnemy.GetComponent<EnemyAgro>().agroRange = 1000;
            newEnemy.GetComponent<EnemyAgro>().player = GameObject.FindGameObjectWithTag("Player").transform;
            randomEnemy = Random.Range(0, 100);
            randomSpawn = Random.Range(0, 2);
            enemyTimer = 1f;
        }
        if (randomEnemy > 85 & randomEnemy <= 95 & enemyTimer <= 0)
        {
            newEnemy = Instantiate(enemies[2], whichSpawn.position, Quaternion.identity);
            newEnemy.GetComponent<EnemyFlip>().isFlipped = flip;
            newEnemy.GetComponent<EnemyFlip>().player = GameObject.FindGameObjectWithTag("Player").transform;
            newEnemy.GetComponent<EnemyAgro>().agroRange = 1000;
            newEnemy.GetComponent<EnemyAgro>().player = GameObject.FindGameObjectWithTag("Player").transform;
            randomEnemy = Random.Range(0, 100);
            randomSpawn = Random.Range(0, 2);
            enemyTimer = 2f;
        }
        if (randomEnemy > 95 & enemyTimer <= 0)
        {
            newEnemy = Instantiate(enemies[3], whichSpawn.position, Quaternion.identity);
            newEnemy.GetComponent<EnemyFlip>().isFlipped = flip;
            newEnemy.GetComponent<EnemyFlip>().player = GameObject.FindGameObjectWithTag("Player").transform;
            newEnemy.GetComponent<EnemyAgro>().agroRange = 1000;
            newEnemy.GetComponent<EnemyAgro>().player = GameObject.FindGameObjectWithTag("Player").transform;
            randomEnemy = Random.Range(0, 100);
            randomSpawn = Random.Range(0, 2);
            enemyTimer = 8f;
        }
        enemyTimer -= Time.deltaTime;
        
    }
}
