using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �z���������
        int[] array = { 10, 20, 30, 40, 50 };

        // �z��̗v�f�̐��������ԂɌJ��Ԃ�
        for (int i = 0; i < array.Length; i = i + 1 )
        {
            // �z��̗v�f��\������
            Debug.Log(array[i]);
        }

        // �z��̗v�f�̐������t�ɌJ��Ԃ�
        for (int i = 4; i >= 0; i = i - 1)
        {
            // �z��̗v�f��\������
            Debug.Log(array[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
