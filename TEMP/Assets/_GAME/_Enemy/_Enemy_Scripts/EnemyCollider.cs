
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyStats : MonoBehaviour
{
    public int enemyAtk;
    [SerializeField] private int enemyHp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            enemyHp -= GameStats.playerAttack;
            if (enemyHp > 0)
                return;
            GameStats.enemyCount -= 1;
            //Debug.Log(GameStats.enemyCount);
            Destroy(gameObject);
        }
    }
}
