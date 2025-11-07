using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static int playerHp;
    public static int enemyCount;
    public static int playerAttack;
    public static int playerExp;
    [SerializeField] public static GameObject _exp;
    public static PEnemySpawn rng;
    void OnEnable()
    {
        rng = GameObject.Find("Player").GetComponent<PEnemySpawn>();
        _exp = GameObject.Find("Exp");
        playerExp = -1;
        playerHp = 100;
        enemyCount = 0;
        playerAttack = 10;
    }

    public static void EnemyDeath(int expCount, Vector3 enemyPos)
    {
        for (int i = 0; i < expCount; i++)
        {
            Instantiate(GameStats._exp, enemyPos + new Vector3(rng.RandomFloat() * 0.05f, rng.RandomFloat() * 0.05f, 0), GameStats._exp.transform.rotation);
        }
    }
}
