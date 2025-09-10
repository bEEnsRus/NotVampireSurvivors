
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollider : MonoBehaviour
{
    public int health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            health -= 10;
            if (health <= 0)
            {
                GameStats.enemyCount -= 1;
                Debug.Log(GameStats.enemyCount);
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            GameStats.playerHp -= 10;
            Debug.Log(GameStats.playerHp);
            if (GameStats.playerHp <= 0)
            {
                GameStats.playerHp = 100;
                GameStats.enemyCount = 0;
                SceneManager.LoadScene(0);
            }
        }
    }
}
