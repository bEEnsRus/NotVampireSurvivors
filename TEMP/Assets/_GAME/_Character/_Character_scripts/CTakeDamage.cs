
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollider : MonoBehaviour
{
    public int health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit!");
        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            health -= 10;
            if (health <= 0)
            {
                Destroy(gameObject);
                GameStats.enemyCount--;
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
