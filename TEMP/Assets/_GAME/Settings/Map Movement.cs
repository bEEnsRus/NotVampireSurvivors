using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _map;
    private Vector2 _mapWorldPos;
    private void Start()
    {
        _mapWorldPos = gameObject.transform.position;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("collision out");
        if (!collision.gameObject.CompareTag("Player"))
            return;
        int xPos = ComparePosition(_mapWorldPos.x, _player.transform.position.x, 5.5f);
        int yPos = ComparePosition(_mapWorldPos.y, _player.transform.position.y, 4f);
        Debug.LogError(new Vector2(xPos, yPos));
        _map.transform.position += new Vector3(xPos*22, yPos*16);
        _mapWorldPos = _map.transform.position;
    }

    public int ComparePosition(float mapPos, float playerPos, float offset)
    {
        Debug.LogError(mapPos);
        Debug.LogError(playerPos);
        Debug.LogError(offset);
        if (playerPos - mapPos < -offset)
        {
            return -1;
        }
        else if (playerPos - mapPos > offset)
        {
            return 1;
        }
        else
            return 0;
    }
}
