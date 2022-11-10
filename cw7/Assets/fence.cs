
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fence : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(transform.position.z <= 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Random.Range(20f, 40f) );
        }
        transform.position = new Vector3(transform.position.x , transform.position.y ,transform.position.z-speed );
    }
}
