using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//[System.Serializable]
public class Button : MonoBehaviour
{

    public Sprite[] happyCat;
    public Sprite[] sadCat;

    public GameController GC;

    public SpriteRenderer Cat;


    void Start()
    {
        GC = FindObjectOfType<GameController>(); //Finds the object of that script (so you can use whats in it) 

        if (gameObject.name == "emoji_cat_11")
        {
            Cat = GetComponent<SpriteRenderer>();
        }
    }

    void Update()
    {
        if (gameObject.name == "emoji_cat_11" && SceneManager.GetActiveScene().buildIndex != 0)
        {

            if (GC.HappyKitty)
            {
                Cat.sprite = happyCat[GC.randNum];
            }
            else
            {
                Cat.sprite = sadCat[GC.randNum];
            }
        }
    }

    public void OnClick()
    {

        if(SceneManager.GetActiveScene().buildIndex == 6)
        {


            if (GC.CorrectAnswer > GC.WrongAnswer)
            {
                GC.SceneNum = 7;
                SceneManager.LoadScene(7);
            }
            else
            {
                GC.SceneNum = 8; 
                SceneManager.LoadScene(8);
            }
        }

        else
        {
            GC.randNum = Random.Range(0, 4);

            if (gameObject.name == "WrongButton")
            {
                GC.WrongAnswer += 1;
                GC.HappyKitty = false;

            }
            else if (gameObject.name == "RightButton")
            {
                GC.CorrectAnswer += 1;
                GC.HappyKitty = true;
            }

            GC.SceneNum += 1;
        }

        SceneManager.LoadScene(GC.SceneNum);

    }

}
