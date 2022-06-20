using UnityEngine;

namespace KID
{
    /// C# �q�Ź��ܦ����骫��

    /// </summary>�]�B�t��
    public class SystemRun : MonoBehaviour
    {
        #region ���:�O�s�λݭn�����
        // ��� Field :�O�s���
        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O����]�B�t��"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Range(0, 300)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region ���:�O�s�t�λݭn�����
        //��k Method
        //�y�k
        //�׹��� �Ǧ^������� ��k�W��(�Ѽ�){�{��}
        /// <summary>
        ///�]�B�\�� 
        /// </summary>
        private void Run()
        {
            print("�]�B��~");
            rig.velocity = new Vector2(speedRun,  rig .velocity .y );
        }
        #endregion

        #region �ƥ�:�{���J�f
        //����ƥ�:�}�l�ƥ�e����@���A���o���
        private void Awake()
        {
            // ani ���w �Ԫ��t���W�� Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        #endregion

        #region �}�l�ƥ�
        private void Start()
        {
            //print("���o.�U�w :D")
        }
        //��s�ƥ�:�C����椻�Q�� 60fps
        private void Update()
        {
            //print("<color=yellow>��s�ƥ���椤~</color>");

            //�I�s��k:��k�W��(�������޼�);
            Run();
        }
        #endregion

    }
}
