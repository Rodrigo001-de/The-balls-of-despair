using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour
{
    public rotateballs controller;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Point")
        {
            // soma ponto
            Destroy(collision.gameObject);
            controller.updateScore(); // atualizar pontuação 
        }

        if (collision.gameObject.tag == "platform")
        {
            // game over
            controller.callGameOver();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
