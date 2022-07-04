using UnityEngine;

namespace KID
{
    ///<summary>
    ///管理過關
    ///</summary>

    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "忍者龜";
        [SerializeField, Header("跑步系統")]
        private string systemRun;
        [SerializeField, Header("跳躍系統")]
        private string systemJump;

        #region 其中一個物件有勾選 Is Trigger
        //兩個物件碰撞時執行
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);

            //如果 碰撞物件的名稱 包含 (忍者龜)
            if(collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;  //關閉跑步
                systemJump.enabled = false; //關閉跳躍
                ManagerFinal.enabled = true; //啟動結束管理器
                ManagerFinal.stringTitle = "恭喜你過關";
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {

        }
        #endregion

        #region 兩個物件都沒有勾選 Is Trigger
        private void OnCollisionEnter2D(Collision collision)
        {

        }

        private void OnCollisionExit2D(Collision2D collision)
        {

        }

        private void OnCollisionStay2D(Collision2D collision)
        {

        }

    }

}

