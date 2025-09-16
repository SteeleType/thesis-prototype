using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemySpawner;
    public Transform spawner;
    public float timer = 5f;

    void FixedUpdate()
    {
        timer -= Time.fixedDeltaTime;
        if (timer <= 0)
        {
            Instantiate(enemySpawner, spawner.position, spawner.rotation);
            timer = 5f;
        }
    }
}
