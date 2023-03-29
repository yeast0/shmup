using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,1);
        // destroys the explosion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
