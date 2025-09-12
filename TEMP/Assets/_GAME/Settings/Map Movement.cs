using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _map;
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("collision out");
        if (!collision.gameObject.CompareTag("Player"))
            return;
        int xPos = ComparePosition(gameObject.transform.position.x, _player.transform.position.x, 5.5f);
        int yPos = ComparePosition(gameObject.transform.position.y, _player.transform.position.y, 4f);
        _map.transform.position += new Vector3(xPos*22, yPos*16);
    }

    public int ComparePosition(float mapPos, float playerPos, float offset)
    {
        if (playerPos - mapPos < mapPos - offset)
        {
            return -1;
        }
        else if (playerPos - mapPos > mapPos + offset)
        {
            return 1;
        }
        else
            return 0;
    }
}
