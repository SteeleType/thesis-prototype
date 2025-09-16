using UnityEngine;

public class MagicManager : MonoBehaviour
{
    public GameObject lightningProjectile;
    public Transform lightningSpawn;
    public float lightningSpeed = 20f;
    public float lightningTime = 3f;




    private void LightningStrike()
    {
        lightningProjectile.transform.position = lightningSpawn.position;
        GameObject lightningBolt = Instantiate(lightningProjectile, lightningSpawn);
    }
}
