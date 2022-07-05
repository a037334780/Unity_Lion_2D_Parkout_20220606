using UnityEngine;

namespace KID
{
    public class Manggerdary : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "忍者龜";
        [SerializeField, Header("結束管理器")]
        private ManagerFinal managerfinal;
        [SerializeField, Header("CM 攝影機控制物件")]
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision .name.Contains (nameTarget))
            {
                managerfinal.stringTitle = "挑戰失敗";
                managerfinal.enabled = true;
                goCM.SetActive(false);
            }
        }
    }
}
