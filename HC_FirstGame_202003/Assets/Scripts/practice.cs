using UnityEngine;

public class practice : MonoBehaviour
{
    // 非靜態皆須有欄位，2、4兩個練習皆需要先寫出新增的欄位，並掛到物件上才能執行

    public SpriteRenderer logo;  // SpriteRenderer 渲染圖片(應該是?)
    public GameObject cam;

    private void Start()
    {
        // 練習
        // 1.隱藏鼠標
        Cursor.visible = false;

        // 2.翻轉圖片
        logo.flipX = true;       // 讓掛上的圖片水平翻轉 

        // 3.去小數點
        print("去小數點:" + Mathf.Floor(1.23456f));   // print(輸出) Mathf.Floor(四捨五入)將後邊括號內小數點去除

        // 4.旋轉物件
        cam.transform.Rotate(0, 90, 0);
    }
}
