using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class hassya1_1 : MonoBehaviour
{
    public static bool Freeze = false;
    float timeCount = 0; // �o�ߎ���
    float shotAngle = -80; // ���ˊp�x
    float Ftime = 5;
    [SerializeField] GameObject aooodama1; // ���˂���e

    // Start is called before the first frame update
    void Start()
    {
        Freeze = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PRS.hidann == true)
        {
            return;
        }
            timeCount += Time.deltaTime;
        Ftime -= Time.deltaTime;

        // 1�b�𒴂��Ă��邩
        if (timeCount > 0.42f & Freeze == false)
        {
            timeCount = 0; // �Ĕ��˂̂��߂Ɏ��Ԃ����Z�b�g

            shotAngle += (Random.Range(-179, 179));

            for (int i = 0; i <= 360; i += 40)
            { 

                // GameObject��V���ɐ�������
                // �������F��������GameObject
                // �������F����������W
                // ��O�����F��������p�x
                // �߂�l�F��������GameObject
                GameObject createObject = Instantiate(aooodama1, transform.position, Quaternion.identity);


                // ��������GameObject�ɐݒ肳��Ă���ABullet�X�N���v�g���擾����
                aooodam1 bulletScript = createObject.GetComponent<aooodam1>();

                // Bullet�X�N���v�g��Init���Ăяo��
                bulletScript.Init(i +shotAngle,6);
            }
        }
        if (Ftime < 0)
        {
            Freeze = !Freeze;
            if (Freeze == false)
            {
                Ftime = (Random.Range(3.0f,5.5f));
            } 
            else
            {
                Ftime = 2.8f;
            }
        }
    }
}
