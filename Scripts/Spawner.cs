using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
   
    public Enemy enemy;

    float nextSpawnTime;
    float waitTime = 120f;

    public TextMeshProUGUI scoreText;

    private int score;

    

    private void Update()
    {
        
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + waitTime * Time.deltaTime;
            Enemy spawnedEnemy = Instantiate(enemy, this.transform.position, Quaternion.identity) as Enemy;
            spawnedEnemy.OnDeath += OnEnemyDeath;
            

        }
    }

    void OnEnemyDeath()
    {         
        score++;
        print("enemy dies lol");
        scoreText.SetText(score.ToString());
    }

    
}
