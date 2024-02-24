using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;


public class KT2 : MonoBehaviour
{
    [SerializeField] float speed;
    float angle;
    Vector3 velocity; // ˆÚ“®—Ê


    // Start is called before the first frame update
    void Start()
    {

        velocity.y = speed * Mathf.Cos(angle * Mathf.Deg2Rad);

        velocity.x = speed * Mathf.Sin(angle * Mathf.Deg2Rad);

   

        
    }

    // Update is called once per frame
    void Update()
    {
        float zAngle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg -90.0f;
         transform.rotation = Quaternion.Euler(0, 0, zAngle);

        transform.position += velocity * Time.deltaTime;
        velocity += new Vector3(0, -2.6f, 0) * Time.deltaTime;

        if (PRS.hidann == true)
        {
            Destroy(gameObject, 0.01f);
        }
    }

    public void Init(float input_angle)
    {
        angle = input_angle;
    }
}
