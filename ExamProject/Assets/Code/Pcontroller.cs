using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pcontroller : MonoBehaviour
{
    public float Ver,Hor;
    public float Speed = 10;
    public Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Ver = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        Hor = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        transform.Translate(new Vector3(Hor,0,Ver));
        
        if(Input.GetButtonDown("Jump"))
        {
        rb.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
        }
    }
}