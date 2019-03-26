using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCustomization : MonoBehaviour
{
    Color white = new Color(255, 255, 255);
    public Color blueAzure;
    Player_Move playerMove;
    bool isSwitched = true;

    // Start is called before the first frame update
    void Start()
    {
        playerMove = GetComponent<Player_Move>();
        SwapColors(white, blueAzure);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) == true || Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            if (isSwitched)
            {
                SwapColors(blueAzure, white);
                isSwitched = false;
            }

            else
            {
                SwapColors(white, blueAzure);
                isSwitched = true;
            }
                
        }
    }

    void SwapColors(Color color1, Color color2)
    {
        Camera.main.backgroundColor = color1;
        GmManager.instance.score.color = color2;
        playerMove.obj1.GetComponent<SpriteRenderer>().color = color2;
        playerMove.obj2.GetComponent<SpriteRenderer>().color = color2;
    }
}
