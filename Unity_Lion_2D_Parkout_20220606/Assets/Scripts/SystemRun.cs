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
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �\��:��@�Өt�Ϊ�������k

        #endregion

        #region �ƥ�:�{���J�f
        //����ƥ�:�}�l�ƥ�e����@���A���o���
        private void Awake()
        {
            // ani ���w �Ԫ��t���W�� Animator
            ani = GetComponent<Animator>();
        }
        #endregion

        #region �}�l�ƥ�

        #endregion
        //��s�ƥ�:�C����椻�Q�� 60fps
        private void Update()
        {

        }
    }
}
