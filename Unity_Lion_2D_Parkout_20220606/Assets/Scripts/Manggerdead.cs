using UnityEngine;

namespace KID
{
    public class Manggerdary : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�Ԫ��t";
        [SerializeField, Header("�����޲z��")]
        private ManagerFinal managerfinal;
        [SerializeField, Header("CM ��v�������")]
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision .name.Contains (nameTarget))
            {
                managerfinal.stringTitle = "�D�ԥ���";
                managerfinal.enabled = true;
                goCM.SetActive(false);
            }
        }
    }
}
