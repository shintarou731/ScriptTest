using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{

    // Bossクラス作成
    public class boss
    {
        int mp = 53; // mp宣言



        // 魔法攻撃用の関数
        public void magic(int count)
        {
                //使われた回数だけ繰り返し処理
                for (int i = count; i > 0; i--)
                {
                    if (this.mp >= 5)
                    {
                        this.mp -= 5;
                        Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
                    }
                    else
                    {
                        Debug.Log("MPが足りないため、魔法が使えない。");
                    }
                }
            
        }

    }




    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        boss magicboss = new boss();

        // 魔法攻撃用の関数を呼び出す
        magicboss.magic(12);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
