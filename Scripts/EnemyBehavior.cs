using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed = 20.0f;
    public GameObject bullets;
    private AudioSource enemyAudio;
    public AudioClip shootSound;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 1f);
        enemyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }

    void Shoot()
    {
        enemyAudio.PlayOneShot(shootSound, 0.05f);
        Instantiate(bullets, transform.position, bullets.transform.rotation);
    }
}
