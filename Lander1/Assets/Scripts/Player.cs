using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed = 1f;
    // public GameObject ex;

    public Joystick j;

    private void Update()
    {
        float horizontal = j.Horizontal * speed * Time.deltaTime;
        float vertical = j.Vertical * speed * Time.deltaTime;

        transform.Translate(horizontal, vertical, 0f);
        //Instantiate(ex, transform.position, transform.rotation);
    }
}