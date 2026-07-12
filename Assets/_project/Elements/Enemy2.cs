using System;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public EnemyManager enemyManager2;
    private void OnMouseDown()
    {
        Destroy(gameObject);
        print("Enemy Destroyed"+gameObject.transform.position);
        destroycontrol();
        enemyManager2.EnemyDestroyed(this);
    }
   private  void destroycontrol()
    {
       
        var kalanDusmanlar = FindObjectsByType<Enemy2>(FindObjectsSortMode.None);
        if (kalanDusmanlar.Length<=1)
        {
            print("düşman kalmamıştır" );
        }
    }

    internal void Startenemy(EnemyManager em)
    {
        
        enemyManager2 = em;
    }
}
