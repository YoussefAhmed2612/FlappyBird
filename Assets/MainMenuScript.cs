using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
  public void loadLevel(){
    SceneManager.LoadSceneAsync(1);
    SceneManager.UnloadSceneAsync(0);
      }

}
