using UnityEngine;

namespace KID
{
    /// <summary>
    /// 跳躍系統
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3checkGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3checkGroundOffser;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("跳躍動畫參數")]
        private string nameJump = "關閉跳躍";


        private Animation ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animation>();
            rig = GetComponent<Rigidbody2D>();
        }
        //Input API 建議在 Update 呼叫
        //一秒60次
        private void Update()
        {
            JumpKey();
            CheckGround();
            UpdateAnimator();
        }

        //一秒固定50次
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion
        //繪製圖示
        //在編輯器內繪製輔助用的線條
        private void OnDrawGizmos()
        {
            //1.決定顏色
            Gizmos.color = colorCheckGround;
            //2.繪製圖示
            //transform.position 當前物件的座標
            Gizmos.DrawCube(transform.position + v3checkGroundOffser, v3checkGroundOffser);
        }

        #region 功能
        // / <summary> 跳躍按鍵
        private void JumpKey()
        {
            // 如果 玩家 按下 空白鍵 就往上 跳躍
            // if or switch
            // if 判斷式語法 : if(布林值){布林值 為 ture 執行程式}
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //print("跳躍~");
                clickJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }

        private void JumpForce()
        {
            //如果 點擊跳躍 並且 && 在地板上
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
                //音效來源撥放一次音效(音效片段，音量)
                aud.PlayOneShot(soundJump, Random.Range(0.7f, 1.5f));
            }
        }

        ///<summary>
        /// <檢查是否碰到地板>
        /// </summary>
        private void CheckGround()
           
        {
            //2D碰撞器
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3checkGroundOffser, v3checkGroundSize, 0, layerCheckGround);
            // print("碰到的物件:" + hit.name);

            isGround = hit;

        }
        ///<summary>更新動畫
        private void UpdateAnimator()
        {
            ani.SetBool(nameJump, !isGround);
        }
    }
    #endregion
}

