using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    public float speed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -2)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        } else if (transform.position.x < -2)
        {
            Destroy(gameObject);
        }
    }
}
