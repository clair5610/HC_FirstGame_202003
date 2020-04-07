using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 這是怪物的血量
    /// </summary>
    [Header("血量")]
    public float hp = 50;

    // 認識 屬性 Property
    // 可以設定權限 : 唯讀、允許所有權限
    // get 取得
    // set 設定

    // 允許所有權限
    /// <summary>
    /// 攻擊力
    /// </summary>
    public int attack { get; set; }

    /// <summary>
    /// 防禦力(唯獨)
    /// </summary>
    // public float def { get; }
    public float def
    {
        get
        {
            return 77.5f;
        }
    }

    public int lv = 5;      // 等級五

    // 錯誤 : 不能在欄位指定後方使用欄位 ( 欄位 = 欄位 (X) )
    // 改用屬性 ( prop + Tab*2 )
    // public int mp = lv * 8;
    // 魔力 = 等級 * 8
    public int mp
    {
        get
        {
            return lv * 8;
        }
    }

    // C# 物件導向程式設計三大核心之一 : 封裝 (繼承、多型)
    // 必須設成 private (私人)
    private float _damege;

    public float damege
    {
        set
        {
            // 傷害 - 防禦力 = 真正造成的傷害
            _damege = Mathf.Clamp(value - def, 1, 9999999);  // Mathf.Clamp(夾住) : 讓數值夾在設定的兩個數值中間
        }
        get
        {
            return _damege;
        }
    }

}
