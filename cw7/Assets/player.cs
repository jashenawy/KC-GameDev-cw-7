using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x >= -3f)
        {
            transform.position = new Vector3(transform.position.x-3f, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.D) && transform.position.x <= 3f)
        {
            transform.position = new Vector3(transform.position.x + 3f, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        if (name == "fence")
        {
            SceneManager.LoadScene(0);
            audioSource.Play();
        }
    }
}
