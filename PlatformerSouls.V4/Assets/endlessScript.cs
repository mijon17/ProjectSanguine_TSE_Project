using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessScript : MonoBehaviour
{
    int randomEnemy = Random.Range(0, 100);
    int randomSpawn = Random.Range(0, 2);
    public GameObject[] enemies;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    bool flip;
    Transform whichSpawn;

    float enemyTimer = 300f;

    GameObject newEnemy;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(randomEnemy);
        if (randomSpawn == 0)
        {
            whichSpawn = spawnPoint1;
            flip = true;
        }
        if(randomSpawn == 1)
        {
            whichSpawn = spawnPoint2;
            flip = false;
        }
        if (randomEnemy <= 30 && enemyTimer <= 0)
        {
            newEnemy = Instantiate(enemies[0], whichSpawn.position, Quaternion.identity);
            newEnemy.GetComponent<EnemyFlip>().isFlipped = flip;
            enemyTimer = 3f;
        }
        enemyTimer -= 1;
        //randomEnemy = Random.Range(0, 100);
    }
}
