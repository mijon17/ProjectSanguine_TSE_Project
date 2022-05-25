using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    GameObject[] enemyArray;
    public Text enemyNum;
    void Start()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy");
        enemyNum.text = enemyArray.Length.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyArray.Length > 0)
        {
            enemyArray = GameObject.FindGameObjectsWithTag("Enemy");
            enemyNum.text = enemyArray.Length.ToString();
        }
        else
        {
            enemyNum.text = "FIND THE EXIT";
        }
        
    }
}
