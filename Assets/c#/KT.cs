using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;


public class KT : MonoBehaviour
{
    [SerializeField] float speed;
    float angle;
    Vector3 velocity; // ˆÚ“®—Ê
    float SP;


    // Start is called before the first frame update
    void Start()
    {
        SP = 0;

        velocity.x = speed * Mathf.Cos(angle * Mathf.Deg2Rad);

        velocity.y = speed * Mathf.Sin(angle * Mathf.Deg2Rad);

        Destroy(gameObject, 15.0f);

        float zAngle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg - 90.0f;
        transform.rotation = Quaternion.Euler(0, 0, zAngle);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime * SP ;
        SP += 0.008f;
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
