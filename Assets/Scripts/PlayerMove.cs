using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //インスペクタで設定できるようにする
    public float speed;


    private Rigidbody2D rb = null;
    void Start()
    {
        //コンポーネントのインスタンスを捕まえる
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //キー入力されたら行動する
        float horizontalkey = Input.GetAxis("Horizontal");
        float xSpeed = 0.0f;

        if(horizontalkey > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            xSpeed = speed; //右を押したら正の速度
        }
        else if(horizontalkey < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            xSpeed = -speed; //左を押したら負の速度
        }
        else
        {
            xSpeed = 0.0f; //何も押していないときの速度を0にする
        }
        //Rigidbody2D.velocity:物理的挙動を無視した物理エンジン操作が出来る
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
    }
}
