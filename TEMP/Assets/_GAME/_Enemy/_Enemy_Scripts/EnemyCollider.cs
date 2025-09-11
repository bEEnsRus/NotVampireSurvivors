
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollider : MonoBehaviour
{
    [SerializeField] private int enemyAtk;
    private int enemyHp;
    [SerializeField] private PAttack playerStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            enemyHp -= playerStats.swordDmg;
            if (enemyHp <= 0)
            {
                GameStats.enemyCount -= 1;
                Debug.Log(GameStats.enemyCount);
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("Player"))
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
