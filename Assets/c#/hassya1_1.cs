using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class hassya1_1 : MonoBehaviour
{
    public static bool Freeze = false;
    float timeCount = 0; // 経過時間
    float shotAngle = -80; // 発射角度
    float Ftime = 5;
    [SerializeField] GameObject aooodama1; // 発射する弾

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

        // 1秒を超えているか
        if (timeCount > 0.42f & Freeze == false)
        {
            timeCount = 0; // 再発射のために時間をリセット

            shotAngle += (Random.Range(-179, 179));

            for (int i = 0; i <= 360; i += 40)
            { 

                // GameObjectを新たに生成する
                // 第一引数：生成するGameObject
                // 第二引数：生成する座標
                // 第三引数：生成する角度
                // 戻り値：生成したGameObject
                GameObject createObject = Instantiate(aooodama1, transform.position, Quaternion.identity);


                // 生成したGameObjectに設定されている、Bulletスクリプトを取得する
                aooodam1 bulletScript = createObject.GetComponent<aooodam1>();

                // BulletスクリプトのInitを呼び出す
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
