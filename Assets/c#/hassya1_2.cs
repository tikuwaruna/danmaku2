using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class hassya1_2 : MonoBehaviour
{
    float timeCount = 0; // �o�ߎ���
    float shotAngle = -80; // ���ˊp�x
    float Ftime = 5;
    float lea;
    [SerializeField] GameObject aooodama2; // ���˂���e

    // Start is called before the first frame update
    void Start()
    {
        
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
        if (timeCount > 3.3f)
        {
            timeCount = 0; // �Ĕ��˂̂��߂Ɏ��Ԃ����Z�b�g

            shotAngle += (Random.Range(-179, 179));

            lea = (UnityEngine.Random.Range(0, 2)) == 0 ? 3 : -3;

            for (int i = 0; i <= 360; i += 45)
            { 

                // GameObject��V���ɐ�������
                // �������F��������GameObject
                // �������F����������W
                // ��O�����F��������p�x
                // �߂�l�F��������GameObject
                GameObject createObject = Instantiate(aooodama2, transform.position, Quaternion.identity);


                // ��������GameObject�ɐݒ肳��Ă���ABullet�X�N���v�g���擾����
                aooodam2 bulletScript = createObject.GetComponent<aooodam2>();

                // Bullet�X�N���v�g��Init���Ăяo��
                bulletScript.Init(i +shotAngle,2.8f,lea);
            }
        }
   
        
    }
}
