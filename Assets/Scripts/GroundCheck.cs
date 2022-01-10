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

    //OnTriggerEnter2D：Unity側から呼ばれるメソッド
    //親オブジェクトであるPlayerにRigidbody2Dがある条件より、呼び出される
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            Debug.Log("地面が判定に入りました");
        }


    }
}
