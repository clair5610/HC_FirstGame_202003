using UnityEngine;

public class CarManager : MonoBehaviour
{
    public Car car1;

    private void Start()
    {
        // 使用多個選填式參數可以用參數 : 指定
        car1.Drive(99,dir: "後方");       // 呼叫方法(引數)
        car1.Drive(999.9f);
        car1.Drive(1234.5f,"趴碰趴碰");

        print("汽車 1 號是否開空調了:" + car1.Cool());
    }
}
