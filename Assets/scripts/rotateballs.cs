using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rotateballs : MonoBehaviour
{
    public float velocity; // variável float: ponto flutuante(números com vírgulas)
    bool right = false; // váriavel booleana(bool): só pode ter dois valores true ou false

    public GameObject gameOver;
    public int punctuation;

    public Text Textpunctuation;

    // Start is called before the first frame update
    void Start() // é um método que é chamado uam vez quando é inicializado o game 
    {
        
    }

    // Update is called once per frame
    void Update() // é chamado a cada frame
    {
        if(Input.GetMouseButtonDown(0)) // 0 = botão esquerdo do mause, 1 = botão direito do mause
        {
            right = !right; // !right: invertendo o valor da váriavel 
        }

        if(right == false)
        {
            transform.Rotate(new Vector3(0f, 0f, velocity * Time.deltaTime)); // Vector3 armazena um eixo x, y e z
        }
        else
        {
            transform.Rotate(new Vector3(0f, 0f, -velocity * Time.deltaTime)); // -velocity está colocando o valor negativo em relasão com o valor velocity
        }

       
    }

    public void callGameOver()
    {
        gameOver.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(0); // ela tem que carregar a cena 0 do game
    }

    public void updateScore()
    {
        punctuation++;
        Textpunctuation.text = punctuation.ToString();
    }
}
