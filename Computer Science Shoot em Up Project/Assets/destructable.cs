using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructable : MonoBehaviour
{

    public GameObject explosion;


    float hp = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerProjectile projectile = collision.GetComponent<PlayerProjectile>();
        // gets the projectile script
        if (projectile != null)
        // checks if projectile exists
        {
            if (!projectile.isEnemy)
                // checks if the projectile is an enemy projectile
            {
                if (hp == 0)
                {

                    Destroy(gameObject);
                    Instantiate(explosion, transform.position, Quaternion.identity);
                    Destroy(projectile.gameObject);
                    // destroys enemy and bullet on hit
                }
                else
                {
                    
                    hp = hp - 1;
                    Destroy(projectile.gameObject);
                }

            }
        }
    }
}
