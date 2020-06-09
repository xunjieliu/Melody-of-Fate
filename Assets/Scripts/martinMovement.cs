using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class martinMovement : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody2D _rigidbody2D;
    private float x;
    private float y;
    private Vector2 moveVelocity;
     void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     if(isPause)
        //     {
        //         isPause = false;;
        //     }else{
        //         isPause = true;
        //     }
        //     GameObject.Find("Background").GetComponent<GUIManager>().setFreeze(isPause);
        // }
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        // Run();s
        Vector2 moveInput = new Vector2(x,y);
        moveVelocity =  moveInput.normalized*speed;
    }
    void FixedUpdate() {
        _rigidbody2D.MovePosition(_rigidbody2D.position+moveVelocity*Time.fixedDeltaTime);
    }
    private void Run()
    {
        Vector3 movement = new Vector3(x,y,0);
        _rigidbody2D.transform.position += movement * speed * Time.deltaTime;
    }
}