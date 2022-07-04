using UnityEngine;
using TMPro;

namespace KID
{
    ///<summary>管理結束畫面 過關與失敗
    public class ManagerFinal : MonoBehaviour
    {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textFinal;

        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;

            //MonoBehaveior 類別 API 可以直接使用名稱呼叫
            InvokeRepeating("FadeIn", 0, 0.2f);
        }

        ///<summary>
        ///淡入
        ///</summary>
        private void FandeIN()
            //按鈕與
            //1.定義
            //2.Button
        public void Quit()
        {
            //透明度遞增
            groupFinal.alpha += 0.1f;

            print("淡入~");

            //如果 透明度 >=1 就啟動互動與遮擋射線
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
        }
    }
}
