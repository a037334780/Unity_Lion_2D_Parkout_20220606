using UnityEngine;

namespace KID
{
   ///<summary>
   ///API �R�A���ϥΤ覡
   ///</summary>
   public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            //���o�R�A�ݩ�
            //�y�k:
            //���O.�R�A�ݩʦW��
            print("������:" + Random.value);
            print("PI : " + Mathf.PI);
            print("�L���j : " + Mathf.Infinity);

            //�]�w�R�A�ݩ�
            //�y�k
            //���O.�R�A�ݩʦW��
            Cusor.visible = false;
            physics2D.gravity = new vector2(0, -9.8f);
            Time.timescale = 10f;
        }   
    }
}