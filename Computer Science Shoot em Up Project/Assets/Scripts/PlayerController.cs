using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    Shooter[] shooter;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public int Gameover;
    bool shoot;
    float bulletTimer;



    private IEnumerator waitToFire()
    {
        foreach (Shooter shoot in shooter)
        {
            shoot.Shoot();
            yield return new WaitForSecondsRealtime(0.2f);
        }

    }
    // Start is called before the first frame update
    void Start()



    {


        //GameObject player = GameObject.FindGameObjectWithTag("nocollide");
       // Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());



        shooter = transform.GetComponentsInChildren<Shooter>();

        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        shoot = Input.GetKeyDown(KeyCode.Z);
        if (shoot)
        {

            StartCoroutine(waitToFire());

        }
        //   if (shoot)
        //      {
        //           bulletTimer += Time.deltaTime;
        //          if (bulletTimer > 0.5f) 
        //           { 
        //               shoot.Shoot(); 
        //               bulletTimer = 0; 
        //           }
        // :(
        //       }

    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        destructable destructable = collision.GetComponent<destructable>();
        if (destructable != null)
        {
            SceneManager.LoadScene(1);
            Destroy(gameObject);
        }
    }




}



    


