using UnityEngine;

namespace KID
{
   ///<summary>
   ///API 靜態的使用方式
   ///</summary>
   public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            //取得靜態屬性
            //語法:
            //類別.靜態屬性名稱
            print("隋機值:" + Random.value);
            print("PI : " + Mathf.PI);
            print("無限大 : " + Mathf.Infinity);

            //設定靜態屬性
            //語法
            //類別.靜態屬性名稱
            Cusor.visible = false;
            physics2D.gravity = new vector2(0, -9.8f);
            Time.timescale = 10f;
        }   
    }
}