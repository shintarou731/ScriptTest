using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{

    // Boss�N���X�쐬
    public class boss
    {
        int mp = 53; // mp�錾



        // ���@�U���p�̊֐�
        public void magic(int count)
        {
                //�g��ꂽ�񐔂����J��Ԃ�����
                for (int i = count; i > 0; i--)
                {
                    if (this.mp >= 5)
                    {
                        this.mp -= 5;
                        Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
                    }
                    else
                    {
                        Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
                    }
                }
            
        }

    }




    // Start is called before the first frame update
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        boss magicboss = new boss();

        // ���@�U���p�̊֐����Ăяo��
        magicboss.magic(12);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
