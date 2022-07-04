using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���D�t��
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3checkGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3checkGroundOffser;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;


        private Animation ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            ani = GetComponent<Animation>();
            rig = GetComponent<Rigidbody2D>();
        }
        //Input API ��ĳ�b Update �I�s
        //�@��60��
        private void Update()
        {
            JumpKey();
            CheckGround();
        }

        //�@��T�w50��
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion
        //ø�s�ϥ�
        //�b�s�边��ø�s���U�Ϊ��u��
        private void OnDrawGizmos()
        {
            //1.�M�w�C��
            Gizmos.color = colorCheckGround;
            //2.ø�s�ϥ�
            //transform.position ��e���󪺮y��
            Gizmos.DrawCube(transform.position + v3checkGroundOffser, v3checkGroundOffser);
        }

        #region �\��
        // / <summary> ���D����
        private void JumpKey()
        {
            // �p�G ���a ���U �ť��� �N���W ���D
            // if or switch
            // if �P�_���y�k : if(���L��){���L�� �� ture ����{��}
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //print("���D~");
                clickJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }

        private void JumpForce()
        {
            //�p�G �I�����D �åB && �b�a�O�W
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }

        ///<summary>
        /// <�ˬd�O�_�I��a�O>
        /// </summary>
        private void CheckGround()
        {
            //2D�I����
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3checkGroundOffser, v3checkGroundSize, 0, layerCheckGround);
            // print("�I�쪺����:" + hit.name);

            isGround = hit;

        }
    }
    #endregion
}

