using UnityEngine;

namespace KID
{
    ///<summary>
    ///�D�R�A API
    ///�P�R�A���t�O�b��ݭn�@�ӡu���骫��v
    ///�u���骫��v�@�Ӧs�b��������C������ Game Object
    ///</summary>>
    public class APINnoStatic : MonoBehaviour
    {
        //1.�w�q���A������������O
        //2.Unity �ݩʭ��O�����T�w����줣�O�ŭ� None
        //3.�ϥΫD�R�AAPI
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform startpoint;

        private void Start()
        {
            //�D�R�A�ݩ�
            //1.���o
            //�y�k:
            //���W��:�D�R�A�ݩ�
            print("�Ԫ��t���Ұʪ��A:" + turtle.activeInHierarchy);
            print("�Ԫ��t�w�]�ϼh" + turtle.layer);
            print("�_�I���y��" + startpoint.position);

            //2.�]�w
            //�y�k:
            //���W�١A�D�R�A�ݩ� ���w ��;
            //turtle.activeInHierarchy = false; (���~�A��Ū�ݩ� �x��S�g)
            turtle.tag = "Player";
            turtle.layer = 4;
            startpoint.position = new Vector3(0, 5, 0);

            //3.�ϥ� �D�R�A��k
            //�y�k:���W�١A�D�R�A��k(�������޼�);
            turtle.SetActive(false);
        }
        private void Update()
        {
            startpoint.Translate(1.5f, 0, 0);
            startpoint.Rotate(0, 0, 3.5f);
        }
    }
}
