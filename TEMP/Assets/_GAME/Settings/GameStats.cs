using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static int playerHp;
    public static int enemyCount;
    public static int playerAttack;
    public static int playerExp;
    void OnEnable()
    {
        playerExp = 0;
        playerHp = 100;
        enemyCount = 0;
        playerAttack = 10;
    }
}
