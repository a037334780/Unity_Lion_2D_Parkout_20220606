using UnityEngine;

namespace KID
{
    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�O�s�λݭn�����
        //��� Field :�O�s���
        //�y�k:
        //�׹��� ��������� ���ۭq�W��(���w�B�w�]��);

        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O����]�B�t��"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Range(0, 300)]
        private float heightJump = 350;
        private Animation ani;
        private Rigidbody2D rig;
        #endregion

        #region �\��:��@�Өt�Ϊ�������k

        #endregion

        #region �ƥ�:�{���J�f
        private void Start()
        {
            print("���o . �U�w :D");
        }
        #endregion

    }
}
