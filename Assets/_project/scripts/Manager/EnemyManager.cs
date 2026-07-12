using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameDirector level;
    public List<Enemy2> enemies;

    public Enemy2 enemy2;
    public void GeneratesEnemies()
    {
        for (int i = 0; i < 10; i++)
        {
            GeneratesEnemy();
           
        }
    }

    internal void EnemyDestroyed(Enemy2 enemy2)
    {
        enemies.Remove(enemy2);
        if (enemies.Count == 0)
        {
            level.LevelCleared();
        }
}

    private void GeneratesEnemy()
    {
        var newEnemy = Instantiate(enemy2);
        newEnemy.transform.position = new Vector3(UnityEngine.Random.Range(-5f, 5f),  0, UnityEngine.Random.Range(-5f, 5f));
        enemies.Add(newEnemy);
        newEnemy.Startenemy(this);

    }
  
}
