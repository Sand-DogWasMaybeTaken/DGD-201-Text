using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    // Variables
    public TextMeshProUGUI text;
    public InputActionReference e;
    public InputActionReference d;

    private int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //make the text say that the game started
        text.text = "Game Started";
        //Set our score to 0
        score = 0;
        

    }

    // Update is called once per frame
    void Update()
    {
        // if the score is greater than or equal to 0, have the text say the score otherwise if the score is less than 0, have the text say game over
        if (score >= 0)
        {
            text.text = "Score: " + score;
        }
        else if (score < 0)
        {
            text.text = "Game Over";
        }
        // if we press e the score goes up
        //if we press d the score goes down
        if (e.action.WasPressedThisFrame())
        {
            score ++;
        }
        else if (d.action.WasPressedThisFrame())
        {
            score --;
        }
        // if the score is greater than or equal to 10, have the text color be gold otherwise if the score is less than 10, have the text color be silver
        if (score >= 10)
        {
            text.color = Color.gold;
        }
        else
        {
            text.color = Color.silver;
        }
    }
}
