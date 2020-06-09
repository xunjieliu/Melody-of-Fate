using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class martinController : MonoBehaviour
{
    float speed = 0.1f;
    bool isFacingRight = true;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed",Mathf.Abs(direction * speed));
        if(direction >0 && isFacingRight == false)
        {
            Flip();
        }
        else if(direction <0 && isFacingRight == true)
        {
            Flip();
        }
    }
    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
