using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (gameObject.CompareTag("Player Bullet"))
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }

            if (gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                SceneManager.LoadScene("SampleScene");
                Debug.Log("Game Over!");
            }
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Enemy Bullet"))
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                SceneManager.LoadScene("SampleScene");
                Debug.Log("Game Over!");
            }
        }
    }
}
