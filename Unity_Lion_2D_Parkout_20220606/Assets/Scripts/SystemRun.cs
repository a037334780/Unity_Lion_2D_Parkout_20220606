using UnityEngine;

namespace KID
{
    /// C# 從藍圖變成實體物件

    /// </summary>跑步系統
    public class SystemRun : MonoBehaviour
    {
        #region 資料:保存統需要的資料
        // 欄位 Field :保存資料
        [SerializeField, Header("跑步速度"), Tooltip("這是角色跑步速度"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跳躍高度"), Range(0, 300)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 資料:保存系統需要的資料
        //方法 Method
        //語法
        //修飾詞 傳回資料類型 方法名稱(參數){程式}
        /// <summary>
        ///跑步功能 
        /// </summary>
        private void Run()
        {
            print("跑步中~");
            rig.velocity = new Vector2(speedRun,  rig .velocity .y );
        }
        #endregion

        #region 事件:程式入口
        //喚醒事件:開始事件前執行一次，取得原件等
        private void Awake()
        {
            // ani 指定 忍者龜身上的 Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        #endregion

        #region 開始事件
        private void Start()
        {
            //print("哈囉.沃德 :D")
        }
        //更新事件:每秒執行六十次 60fps
        private void Update()
        {
            //print("<color=yellow>更新事件執行中~</color>");

            //呼叫方法:方法名稱(對應的引數);
            Run();
        }
        #endregion

    }
}
