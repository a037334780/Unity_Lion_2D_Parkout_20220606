using UnityEngine;

namespace KID
{
    ///<summary>
    ///API 靜態的使用方式
    ///</summary>
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);
       private void Start()
        {

            //類別名稱:靜態屬性名稱
            print("所有攝影機數量:" + Camera.allCamerasCount);
            print("目前的平台:" + Application.platform);

            Physics.sleepThreshold = 10;
            print("睡眠臨界值:" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("時間大小:" + Time.timeScale);
            //類別名稱.靜態方法名稱(對應的引數)
            print("9.999 去掉小數點四捨五入:" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=yalolow>距離:" + distance + "</color>");

            Application.OpenURL("https://unity.com");
        }
        private void Update()
        {

            //print("是否按下任意鍵:" + Input.anyKeyDown);
            //print("遊戲經過時間:" + Time.timeSinceLevelLoad);
            print("<color=red>是否按下空白鍵:" + Input.GetKeyDown(KeyCode.Space ) + "</color>");
}
    }
}