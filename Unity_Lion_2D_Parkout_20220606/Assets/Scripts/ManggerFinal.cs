using UnityEngine;
using TMPro;

namespace KID
{
    ///<summary>�޲z�����e�� �L���P����
    public class ManagerFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;

            //MonoBehaveior ���O API �i�H�����ϥΦW�٩I�s
            InvokeRepeating("FadeIn", 0, 0.2f);
        }

        ///<summary>
        ///�H�J
        ///</summary>
        private void FandeIN()
            //���s�P
            //1.�w�q
            //2.Button
        public void Quit()
        {
            //�z���׻��W
            groupFinal.alpha += 0.1f;

            print("�H�J~");

            //�p�G �z���� >=1 �N�Ұʤ��ʻP�B�׮g�u
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
        }
    }
}
