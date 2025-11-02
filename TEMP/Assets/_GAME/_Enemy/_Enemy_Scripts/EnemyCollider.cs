
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollider : MonoBehaviour
{
    [SerializeField] private int enemyAtk;
    [SerializeField] private int enemyHp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            enemyHp -= GameStats.playerAttack;
            if (enemyHp <= 0)
            {
                GameStats.enemyCount -= 1;
                Debug.Log(GameStats.enemyCount);
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("PlayerCollider"))
        {
            GameStats.playerHp -= enemyAtk;
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
