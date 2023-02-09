using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed = 20f;
    void Update()
    {
        transform.position += new Vector3(0, Time.deltaTime * _speed, 0);
        if (transform.position.y > 20)
        {
            Destroy(gameObject);
        }
    }

}