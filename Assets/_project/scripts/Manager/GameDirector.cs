using UnityEngine;

public class GameDirector : MonoBehaviour

{
    public EnemyManager enemyManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        enemyManager.GeneratesEnemies();
    }
    public void LevelCleared()
    {
        enemyManager.GeneratesEnemies();
    }
}
