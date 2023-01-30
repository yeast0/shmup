using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMovementY : MonoBehaviour
{

    float sinCenterY;
    public float amplitude = 0.5f;
    public float frequency = 0.5f;
    // sine wave center


    // Start is called before the first frame update
    void Start()
    {
        sinCenterY = transform.position.y;
        // changes position by center
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.x * frequency) * amplitude;
        pos.y = sinCenterY + sin;
        // uses sine waves to create a movement pattern

        transform.position = pos;
        // transforms position
    }
}
