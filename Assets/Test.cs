using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public class Boss
    {
        private int hp = 100; //�̗�
        private int power = 25;//�U����


        // �U���p�̊֐�
        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");    
        }


        // �h��p�̊֐�
        public void Defence(int damage)
        {
            Debug.Log( damage+ "�̃_���[�W���󂯂�");
            // �c��HP�����炷
            this.hp -= damage;
        }

    }


    
    // Start is called before the first frame update
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();

        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);

        // Boss�N���X��midboss���쐬���ăC���X�^���X����
        Boss midboss = new Boss();

        // �U���p�̊֐�
        midboss.Attack();

        // �h��p�̊֐�
        midboss.Defence(100);


    }
   


    // Update is called once per frame
    void Update()
    {
        
    }
}
