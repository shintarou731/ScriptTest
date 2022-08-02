using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 配列を初期化
        int[] array = { 10, 20, 30, 40, 50 };

        // 配列の要素の数だけ順番に繰り返す
        for (int i = 0; i < array.Length; i = i + 1 )
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }

        // 配列の要素の数だけ逆に繰り返す
        for (int i = 4; i >= 0; i = i - 1)
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
