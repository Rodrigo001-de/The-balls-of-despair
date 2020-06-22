using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject platformPrefab;

    float time;
    public float minimumtime;
    public float maximumtime;
    float totaltime;

    // Start is called before the first frame update
    void Start()
    {
        totaltime = Random.Range(minimumtime, maximumtime); // Retornando um valor randomico emtre o minimumtime e maximumtime para a variável totaltime
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; // A variavel time vai ser acrecida do Time.deltaTime a cada frame, vai virar um cronometro

        if(time >= totaltime)
        {
            Instantiate(platformPrefab, transform.position, transform.rotation); // cria uma copia da plataforma 
            totaltime = Random.Range(minimumtime, maximumtime);
            time = 0f;
        }
    }
}
