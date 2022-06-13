using UnityEngine;

namespace KID
{
    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料:保存統需要的資料
        //欄位 Field :保存資料
        //語法:
        //修飾詞 欄位資料類型 欄位自訂名稱(指定、預設值);

        [SerializeField, Header("跑步速度"), Tooltip("這是角色跑步速度"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跳躍高度"), Range(0, 300)]
        private float heightJump = 350;
        private Animation ani;
        private Rigidbody2D rig;
        #endregion

        #region 功能:實作該系統的複雜方法

        #endregion

        #region 事件:程式入口
        private void Start()
        {
            print("哈囉 . 沃德 :D");
        }
        #endregion

    }
}
