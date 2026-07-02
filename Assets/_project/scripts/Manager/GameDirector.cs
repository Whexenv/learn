using UnityEngine;

public class GameDirector : MonoBehaviour

{
    public EnemyDirection enemyDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        enemyDirection.GeneratesEnemies();
    }
}
