using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //�C���X�y�N�^�Őݒ�ł���悤�ɂ���
    public float speed;


    private Rigidbody2D rb = null;
    void Start()
    {
        //�R���|�[�l���g�̃C���X�^���X��߂܂���
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //�L�[���͂��ꂽ��s������
        float horizontalkey = Input.GetAxis("Horizontal");
        float xSpeed = 0.0f;

        if(horizontalkey > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            xSpeed = speed; //�E���������琳�̑��x
        }
        else if(horizontalkey < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            xSpeed = -speed; //�����������畉�̑��x
        }
        else
        {
            xSpeed = 0.0f; //���������Ă��Ȃ��Ƃ��̑��x��0�ɂ���
        }
        //Rigidbody2D.velocity:�����I�����𖳎����������G���W�����삪�o����
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
    }
}
