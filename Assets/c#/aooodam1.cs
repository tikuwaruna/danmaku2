using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;

public class aooodam1 : MonoBehaviour
{
    [SerializeField] float angle; // �p�x
    [SerializeField] float speed; // ���x
    Vector3 velocity; // �ړ���
    bool Fch;
    [SerializeField] GameObject KT; // ���˂���e

    // Start is called before the first frame update
    void Start()
    {

        velocity.x = speed * Mathf.Cos(angle * Mathf.Deg2Rad);

        velocity.y = speed * Mathf.Sin(angle * Mathf.Deg2Rad);

        Destroy(gameObject, 5.0f);

        float zAngle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg - 90.0f;
        transform.rotation = Quaternion.Euler(0, 0, zAngle);

    }

    // Update is called once per frame
    void Update()
    {
        if (hassya1_1.Freeze==false)
        {

            transform.position += velocity * Time.deltaTime;

        }
        if (hassya1_1.Freeze == true && Fch == false) 
        {
            Destroy(gameObject, 0.8f);
            Fch = true;
        }



    }
    
     
    // !!�ǉ�!!
    // �p�x�Ƒ��x��ݒ肷��֐�
    public void Init(float input_angle, float input_speed)
    {
        angle = input_angle;
        speed = input_speed;
    }
    void OnDisable()
    {
        for (float i = -64; i <= 64; i += (UnityEngine.Random.Range(14.0f, 18.0f)))
        {
            // GameObject��V���ɐ�������
            // �������F��������GameObject
            // �������F����������W
            // ��O�����F��������p�x
            // �߂�l�F��������GameObject
            GameObject createObject = Instantiate(KT, transform.position, Quaternion.identity);

            KT bulletScript = createObject.GetComponent<KT>();

            bulletScript.Init(i + angle);

        }
    }
}
