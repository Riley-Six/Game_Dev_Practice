using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    /*
    public float spinX;
    public float spinY;
    public float spinZ;
    public float moveX;
    public float moveY;
    public float moveZ;
    */
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(spinX, spinY, spinZ);
        //transform.Translate(moveX, moveY, moveZ);
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
