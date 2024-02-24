using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACDK : MonoBehaviour
{
    float speed;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        speed = (Random.Range(-3.6f, -6.6f));
        velocity.y = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;

        if (PRS.hidann == true)
        {
            Destroy(gameObject);
        }
    }
}
