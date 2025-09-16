using UnityEngine;

public class BasicCamera : MonoBehaviour
{
//script to just basically follow the player

    public Transform player;

    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -10);
    }
}
