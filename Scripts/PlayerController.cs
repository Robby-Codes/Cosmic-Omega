using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 20;
    public GameObject bullets;
    private AudioSource playerAudio;
    public AudioClip shootSound;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Basic movement and firing controls
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAudio.PlayOneShot(shootSound, 0.5f);
            Instantiate(bullets, transform.position, bullets.transform.rotation);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        // Movement Boundary
        if (transform.position.x < -1)
        {
            transform.position = new Vector3(-1, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 31)
        {
            transform.position = new Vector3(31, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -38)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,  -38);
        }
        if (transform.position.z > 38)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 38);
        }
    }
}
