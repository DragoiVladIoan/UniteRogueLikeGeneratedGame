using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GmManager : MonoBehaviour {

    public static GmManager instance = null;
    public BoardManager boardScript;
    private int level = 1;
    private int maxLevel = 6;
    private float levelStartDelay = 2f;

    public Text score;
    public Text displayScoreList;
    public List<double> scoreList;
   
    // Use this for initialization
	void Awake () {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        boardScript = GetComponent<BoardManager>();
        
        InitGame();
	}
	
    public void LevelOver()
    {
        if (level < maxLevel)
        {
            level++;
            setActive(false);
            boardScript.Clear();
            //ResetLayout();
            InitGame();
        }
        else
        {
            enabled = false;
            boardScript.Clear();
            ShowScore();
        }
    }

    void InitGame()
    {
         
         boardScript.SetupScene(level);
    }

    public void setActive(bool active)
    {
        score.gameObject.SetActive(active);
    }

    private void ShowScore()
    {
       int index = 1;
       foreach(float lvl in scoreList)
        {
            displayScoreList.text = displayScoreList.text + "Level" + index + " " + lvl + "%"  + "\n\n\n";
            index++;
        }
            
           
    }

}
