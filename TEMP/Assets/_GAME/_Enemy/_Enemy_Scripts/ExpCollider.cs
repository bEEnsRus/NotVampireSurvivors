using UnityEngine;

public class ExpCollider : MonoBehaviour
{
    private GameObject player;
    private bool shouldMove;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameStats.playerExp += Mathf.RoundToInt(Random.Range(1,3));
            if (GameStats.playerExp >= GameStats.neededExp)
            {
                GameStats.playerExp -= GameStats.neededExp;
                GameStats.neededExp = GameStats.playerLevel * 200;
                GameStats.playerLevel++;
                Debug.Log($"Level {GameStats.playerLevel}! You need {GameStats.neededExp} more Experience to level up.");
            }
            Destroy(this.gameObject);
        }
        if (!collision.gameObject.CompareTag("PlayerCollector"))
            return;
        shouldMove = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("PlayerCollector"))
            return;
        shouldMove = false;
    }
    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void Update()
    {
        if (!shouldMove)
            return;
        gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, player.transform.position, Time.deltaTime * 2f);

    }
    //deprecated code under \/
    /*#region GoToPlayer protocol
    private IEnumerator coroutine;
    IEnumerator GoToPlayer(GameObject player)
    {
        while (true)
        {
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, player.transform.position, 5*Time.deltaTime);
            yield return new WaitForSeconds(0.01f);
        }
    }
    #endregion
    #region OnTriggerEnter
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameStats.playerExp++;
            Destroy(this.gameObject);
        }
        if (!collision.gameObject.CompareTag("PlayerCollector"))
            return;
        Debug.LogWarning("triggered");
        coroutine = GoToPlayer(collision.gameObject);
        StartCoroutine(coroutine);
    }
    #endregion
    #region OnTriggerExit
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("PlayerCollector"))
            return;
        StopCoroutine(coroutine);
        Debug.LogWarning("untriggered");
    }
    #endregion*/
}