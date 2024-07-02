using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicMangerScript : MonoBehaviour
{
    public int playerScore;
    public Text trackerText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void IncreaseScore()
    {
        playerScore ++;
        trackerText.text = playerScore.ToString();
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
}
