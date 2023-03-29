using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Move : MonoBehaviour
{

    public float MOVspeed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.x += MOVspeed * Time.fixedDeltaTime;
        // postition is minus movespeed times deltatime

        transform.position = pos;
        // transform by pos
    }

}
