using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text scoreText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    private int score;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        score = 0;
        SetCountText();
        winText.text = "";


    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(Movement * speed);

     
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            score = score + 1;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("Red Pick Up"))
        {
            other.gameObject.SetActive(false);
            score = score - 1;


        }
        if (count == 16)
        {
            transform.position = new Vector3(20.0f, transform.position.y, 3.0f);
        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 26)
        {
            winText.text = "You Finished with a score of:"+ count.ToString();
        }
    }

}



