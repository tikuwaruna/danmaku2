using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class hassya1_2 : MonoBehaviour
{
    float timeCount = 0; // 経過時間
    float shotAngle = -80; // 発射角度
    float Ftime = 5;
    float lea;
    [SerializeField] GameObject aooodama2; // 発射する弾

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

        // 1秒を超えているか
        if (timeCount > 3.3f)
        {
            timeCount = 0; // 再発射のために時間をリセット

            shotAngle += (Random.Range(-179, 179));

            lea = (UnityEngine.Random.Range(0, 2)) == 0 ? 3 : -3;

            for (int i = 0; i <= 360; i += 45)
            { 

                // GameObjectを新たに生成する
                // 第一引数：生成するGameObject
                // 第二引数：生成する座標
                // 第三引数：生成する角度
                // 戻り値：生成したGameObject
                GameObject createObject = Instantiate(aooodama2, transform.position, Quaternion.identity);


                // 生成したGameObjectに設定されている、Bulletスクリプトを取得する
                aooodam2 bulletScript = createObject.GetComponent<aooodam2>();

                // BulletスクリプトのInitを呼び出す
                bulletScript.Init(i +shotAngle,2.8f,lea);
            }
        }
   
        
    }
}
