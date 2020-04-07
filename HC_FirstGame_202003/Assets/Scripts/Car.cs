﻿using UnityEngine;

public class Car : MonoBehaviour
{
    // 方法語法 : 修飾詞 傳回類型 方法名稱(參數) {敘述}\
    // void 無傳回 : 使用此方法時不會有任何資料傳回
    // 參數與法 : 類型 名稱 ( 要注意盡量維持方便不容易出錯，的維護性與擴充性 )
    // 參數與法 : 類型 名稱 指定 值 ( 選填式參數 - 可甜可鹹)
    /// <summary>
    /// 開車
    /// </summary>
    /// <param name="speed">時速</param>> 
    /// <param name="sound">音效</param>> 
    public void Drive(float speed,string sound = "呼呼呼", string dir = "前方")
    {
        print("開車啦! 時速:" + speed);
        print("開車音效" + sound);
        print("開車方向:" + dir);
    }

    /// <summary>
    /// 開空調
    /// </summary>
    /// <returns>傳回開啟空調</returns>
    public bool Cool()
    {
        print("開空調啦!");
        return true;
    }
}
