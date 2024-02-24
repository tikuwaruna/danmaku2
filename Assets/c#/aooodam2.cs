using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;

public class aooodam2 : MonoBehaviour
{
    [SerializeField] float angle; // 角度
    [SerializeField] float speed; // 速度
    float zAngle;
    float ct;
    public float le;
    Vector3 velocity; // 移動量
    bool Fch;

    // Start is called before the first frame update
    void Start()
    {
        ct = 0;


        velocity.x = speed * Mathf.Cos(angle * Mathf.Deg2Rad);

        velocity.y = speed * Mathf.Sin(angle * Mathf.Deg2Rad);

        Destroy(gameObject, 1.1f);

         zAngle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg - 90.0f;
        transform.rotation = Quaternion.Euler(0, 0, zAngle);

        transform.position += velocity * 0.3f;

    }

    // Update is called once per frame
    void Update()
    {
        if ( ct < 20 )
        {
            angle += le;

            velocity.x = speed * Mathf.Cos(angle * Mathf.Deg2Rad);

            velocity.y = speed * Mathf.Sin(angle * Mathf.Deg2Rad);

            zAngle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg - 90.0f;
            transform.rotation = Quaternion.Euler(0, 0, zAngle);

            transform.position += velocity * Time.deltaTime;
            ct += 1;
            if (le > 0)
            {
                le += 0.5f;
            }
            else
            {
                le += -0.5f;
            }


        }
        else
        {
            transform.position += velocity * Time.deltaTime;
        }

         transform.position += velocity * Time.deltaTime;

        if (PRS.hidann == true)
        {
            Destroy(gameObject);
        }


    }
    
     
    // !!追加!!
    // 角度と速度を設定する関数
    public void Init(float input_angle, float input_speed,float input_lea)
    {
        angle = input_angle;
        speed = input_speed;
        le = input_lea;
    }
    
}
