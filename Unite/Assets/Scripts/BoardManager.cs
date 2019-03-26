using UnityEngine;
using System.Collections.Generic;
public class BoardManager : MonoBehaviour {


   
    public GameObject[] shapesLeft;
    public GameObject[] shapesRight;
    public Transform boardHolder;
    public int maxLevel = 10;
    public Color white;
    public Color azureBlue;
    

    void BoardSetup()
    {
        boardHolder = new GameObject("Board").transform;

    }
    void LevelSetup(int level)
    {
        level--;
        float xPos1 = Random.Range(-7.0f, -5.0f);
        float yPos1 = Random.Range(-3.0f, 3.0f);
        float xPos2 = Random.Range(6.0f,6.75f);
        float yPos2 = -yPos1;
        //Debug.Log(xPos1 + yPos1 + '\n' + xPos2 + yPos2);
        GameObject instance1 = Instantiate(shapesLeft[level], new Vector3(xPos1, yPos1, 0f), Quaternion.identity) as GameObject;
        GameObject instance2 = Instantiate(shapesRight[level], new Vector3(xPos2, yPos2, 0f), Quaternion.identity) as GameObject;
        instance1.GetComponent<SpriteRenderer>().color = white;
        instance2.GetComponent<SpriteRenderer>().color = white;
        Camera.main.backgroundColor = azureBlue;
        instance1.transform.SetParent(boardHolder);
        instance2.transform.SetParent(boardHolder);
        GmManager.instance.score.color = white;
    }

    public void SetupScene(int level)
    {
        BoardSetup();
        LevelSetup(level);

    }

    public void Clear()
    {
       
        Destroy(boardHolder.gameObject);
    }

   
}
