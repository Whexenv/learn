using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyDirection : MonoBehaviour
{
    public Enemy2 enemy2;
    public void GeneratesEnemies()
    {
        for (int i = 0; i < 10; i++)
        {
            GeneratesEnemy();
        }
    }

    private void GeneratesEnemy()
    {
        var newEnemy = Instantiate(enemy2);
        newEnemy.transform.position = new Vector3(UnityEngine.Random.Range(-5f, 5f),  0, UnityEngine.Random.Range(-5f, 5f));

    }
  
}
