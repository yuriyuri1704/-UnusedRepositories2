using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private string groundTag = "Ground";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //OnTriggerEnter2D�FUnity������Ă΂�郁�\�b�h
    //�e�I�u�W�F�N�g�ł���Player��Rigidbody2D������������A�Ăяo�����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            Debug.Log("�n�ʂ�����ɓ���܂���");
        }


    }
}
