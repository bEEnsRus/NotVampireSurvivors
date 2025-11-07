using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Vector2 _enemyPos;
    [SerializeField] private Rigidbody2D _enemyRb;
    [SerializeField] static GameObject _player;
    [SerializeField] private float _enemySpeed;
    private SpriteRenderer _enemySprite;
    private void Start()
    {
        _enemySprite = gameObject.GetComponent<SpriteRenderer>();
        if (_player == null)
            _player = GameObject.FindWithTag("Player");
    }
    public void FixedUpdate()
    {
        if (gameObject.transform.position.x < _player.transform.position.x)
            _enemySprite.flipX = true;
        else
            _enemySprite.flipX = false;
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, _player.transform.position, _enemySpeed * Time.fixedDeltaTime);
    }
}
