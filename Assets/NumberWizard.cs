using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
       
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number:");
        Debug.Log("Highest number is " + max);
        Debug.Log("Lowest number is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max += 1;
        //vì  (min + max) bị lẻ [1+1000=1001] nên guess nó không lên nổi 1000 => sai yêu cầu. Sửa tạm thời bằng cách cho max = 1001 để nó ra kết quả chẳn.

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess(); 
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Okay");           
            StartGame();
        }

    }
    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}
