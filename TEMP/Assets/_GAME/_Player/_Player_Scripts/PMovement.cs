using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine;

[SelectionBase]
public class PMovement : MonoBehaviour
{
    #region Data
    public float _playerSpeed;
    [SerializeField] private Vector2 _playerPos;
    [SerializeField] private Rigidbody2D _playerRb;
    private Vector2 _playerDir;
    #endregion
    public void OnKeyPressed(InputAction.CallbackContext context)
    {
        _playerDir = context.ReadValue<Vector2>();
    }

    
    void FixedUpdate()
    {
        _playerRb.velocity = _playerSpeed * Time.fixedDeltaTime * _playerDir.normalized;
    }
}
