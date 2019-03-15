using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int CorrectAnswer;
    public int WrongAnswer;

    public bool HappyKitty;

    public int SceneNum = 0;

    public int randNum;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        
    }
}
