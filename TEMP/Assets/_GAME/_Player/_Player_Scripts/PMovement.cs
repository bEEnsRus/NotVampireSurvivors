using UnityEngine.InputSystem;
using UnityEngine;
using Unity.VisualScripting;
using TMPro;
using UnityEngine.SceneManagement;

[SelectionBase]
public class PMovement : MonoBehaviour
{
    #region Data
    public float _playerSpeed;
    [SerializeField] private Vector2 _playerPos;
    [SerializeField] private Rigidbody2D _playerRb;
    [SerializeField] private TextMeshProUGUI HpTMP;
    [SerializeField] private SpriteRenderer _playerSprite;
    private Vector2 _playerDir;
    #endregion
    public void OnKeyPressed(InputAction.CallbackContext context)
    {
        _playerDir = context.ReadValue<Vector2>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyStats enemyStats = collision.gameObject.GetComponent<EnemyStats>();
            GameStats.playerHp -= enemyStats.enemyAtk;
            HpTMP.text = ($"{GameStats.playerHp} / 100");
            Debug.Log(GameStats.playerHp);
            if (GameStats.playerHp <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    
    void FixedUpdate()
    {
        if (_playerDir.x > 0)
            _playerSprite.flipX = true;
        else
            _playerSprite.flipX = false;
        _playerRb.linearVelocity = _playerSpeed * Time.fixedDeltaTime * _playerDir.normalized;
    }
}
