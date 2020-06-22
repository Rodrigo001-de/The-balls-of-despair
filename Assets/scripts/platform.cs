using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(Mathf.PingPong(Time.time, 1), transform.localScale.y); // Vector2 é somente o valor X e Y, lacalScale =  tamanho do objeto, Mathf.PingPong() faz um efeito de ir e vir em alguma coisa

        transform.Translate(new Vector2(0F, velocity * Time.deltaTime));
        
    }
}
