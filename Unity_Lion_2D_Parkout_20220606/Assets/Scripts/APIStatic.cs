using UnityEngine;

namespace KID
{
    ///<summary>
    ///API �R�A���ϥΤ覡
    ///</summary>
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);
       private void Start()
        {

            //���O�W��:�R�A�ݩʦW��
            print("�Ҧ���v���ƶq:" + Camera.allCamerasCount);
            print("�ثe�����x:" + Application.platform);

            Physics.sleepThreshold = 10;
            print("�ίv�{�ɭ�:" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("�ɶ��j�p:" + Time.timeScale);
            //���O�W��.�R�A��k�W��(�������޼�)
            print("9.999 �h���p���I�|�ˤ��J:" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=yalolow>�Z��:" + distance + "</color>");

            Application.OpenURL("https://unity.com");
        }
        private void Update()
        {

            //print("�O�_���U���N��:" + Input.anyKeyDown);
            //print("�C���g�L�ɶ�:" + Time.timeSinceLevelLoad);
            print("<color=red>�O�_���U�ť���:" + Input.GetKeyDown(KeyCode.Space ) + "</color>");
}
    }
}