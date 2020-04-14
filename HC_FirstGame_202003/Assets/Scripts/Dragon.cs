using UnityEngine;

public class Dragon : MonoBehaviour
{
    [Header("移動速度"), Range(1, 1000)]
    public float speed = 300;
    [Header("虛擬搖桿")]
    public Joystick joy;
    
    // 第一種寫法 : 需要欄位
    // public Transform tra;

    /// <summary>
    /// 移動
    /// </summary>
    public void Move()
    {
        print("移動中~");

        // 第一種寫法
        // tra.Translate(0, 0, 1);
        // Time.deltaTim 一禎的時間 ---- PC 1s60次 手機 1s50次(更舊的1s40次)由於不同裝置會造成時間誤差，可使用這個改正
        // Input.GetAxis("Vertical"); -- WS 上下
        // 垂直 : Vertical
        // float h = Input.GetAxis("Horizontal"); -- AD 左右
        // 水平 : Horizontal

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        // 第二種寫法(簡寫) : 僅限於 transform 使用
        // transform.Translate(0, 0, 1(這樣寫只能在程式中調整速度));
        transform.Translate(speed * Time.deltaTime * h, 0, speed * Time.deltaTime*v);

        float joyV = joy.Vertical;
        float joyH = joy.Horizontal;

        transform.Translate(speed * Time.deltaTime * joyH, 0, speed * Time.deltaTime * joyV);

        Vector3 pos = transform.position;    // 取得飛龍座標
        pos.x = Mathf.Clamp(pos.x, 20, 80);  // 數學.夾住(值，最小，最大)
        transform.position = pos;            // 飛龍座標 = 夾住座標

    }

    private void Update()
    {
        Move();
    }
}
