using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCharacter : MonoBehaviour
{
    private Rigidbody2D  rbody2D;

    private float jumpForce = 350f;

    private int jumpCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnClickZoo()
    {
        this.rbody2D.AddForce(transform.up * jumpForce);
    }
}
