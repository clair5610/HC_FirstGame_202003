using UnityEngine;

public class LearnMemberStatic : MonoBehaviour
{
    // 定義屬性
    // 語法 : 類型 名稱 指定(=) 值;
    float a = 0.5f;               // float 浮點數(小數點，數字後須加f)
    int b = 100;                  // int   整數
    bool c = true;                // bool  布林植(是否) 是
    bool d = false;               // 否
    string e = "我是字串";        // string 字串

    // 修飾詞 類型 名稱 指定 值;
    // 公開 public 允許所有文件()存取 : 顯示在屬性面板(Unity右邊板塊)
    public int score = 10;
    // 私人 private 僅限此類別(腳本)存取 : 隱藏在屬性面板
    private int speed = 99;

    public Camera cam;    // 定義一個類型為 Camera 的物件，名稱是cam

    // GameObject 用來儲存階層面板或專案內的預製物
    public GameObject cube;
    public GameObject sphere;


    

    private void Start()
    {
        // 使用靜態成員
        // 靜態屬性
        // 取得 Get : 類別.靜態屬性
        print(Random.value);   // 隨機出0.0~1.0之間的數值，常用於攻擊傷害暴擊之類
        // 設定 Set : 類別.靜態屬性 = 值
        // 不能設定 Unity api (官網) 中描述後邊帶有 Read Only 的屬性
        Time.timeScale = 0.5f; // 時間速度變為0.5，也就是變慢為一半

        // 使用靜態方法
        print(Random.Range(0.1f, 0.99f));  // 第一個多載 (可用於傷害(暴擊) or 掉寶機率等)
        print(Random.Range(100, 500));     // 第二個多載

        // 練習一 :
        // 使用靜態成員 - 取得數學 PI 3.141592 : Mathf (Math Fnmction)

        print(Mathf.PI);

        // 練習二 :
        // 使用靜態方法 - 數學.絕對值 -999 : Mathf
        print(Mathf.Abs(-999));

        // 靜態 : 類別.成員
        print("攝影機數量:" + Camera.allCamerasCount);  
        // 非靜態 : 物件.成員
        print(cam.depth);

        // 取得 非靜態屬性
        print(cube.layer);
        print(sphere.layer);


        // 設定 非靜態屬性
        cube.layer = 3;
        sphere.layer = 4;

        // 使用 非靜態方法
        cube.SetActive(true);
        sphere.SetActive(false);


    }

}

