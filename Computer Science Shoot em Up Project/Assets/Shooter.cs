using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    
    

    public PlayerProjectile projectile;
    Vector2 direction;

    public bool autoShoot = true;
    float shootInterval = 0.5f;
    float shootDelay = 0f;
    float shootTimer = 0f;
    float delayTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        direction = (transform.localRotation * Vector2.up).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (autoShoot)
        {
            if (delayTimer >= shootDelay)
            {
                if (shootTimer >= shootInterval)
                {
                    Shoot();
                    shootTimer = 0;
                }
            }
            else
            {
                delayTimer += Time.deltaTime;
            }
        }
    }

    public void Shoot()
    {
        GameObject go = Instantiate(projectile.gameObject, transform.position, Quaternion.identity);
        PlayerProjectile goProjectile = go.GetComponent<PlayerProjectile>();
        goProjectile.direction = direction; 

    }
}
