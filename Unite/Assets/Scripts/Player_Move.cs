using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

public class Player_Move : MonoBehaviour {

   //moving
    public float playerSpeed = 4;
    bool allowMove = true, helper = true, alreadyOver = false;
    public string direction;

    //objects 
    public GameObject obj1, obj2;
    public Player_Score playerScore;
    Color white = new Color(255, 255, 255);

    void PlayerMove(){
     
        Vector3 pos = transform.position;
        pos.y += Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime;
        if (direction == "right")
            pos.x += playerSpeed * Time.deltaTime;
        else if (direction == "left")
            pos.x -= playerSpeed * Time.deltaTime;

        float size_obj2 = obj2.transform.localScale.x/2;
        if(allowMove && pos.x < obj2.transform.position.x - size_obj2)
            transform.position = pos;
        else{

            if (allowMove)
                playerScore.ShowExactScore(0);
                

            else
            {
                playerScore.ShowScore(pos,obj1,helper);
                GmManager.instance.setActive(true);
                Thread.Sleep(500);
                GmManager.instance.setActive(false);
                LevelOver();
            }
        }

    }

    

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "shape2")
            allowMove = false;
    }

    private void LevelOver()
    {
        if (!allowMove && !alreadyOver)
        {
            alreadyOver = true;
            GmManager.instance.LevelOver();
        }
    }

    void Start () {

        obj1.GetComponent<SpriteRenderer>().color = white;
        obj2.GetComponent<SpriteRenderer>().color = white;
        playerScore = GetComponent<Player_Score>();
        GmManager.instance.setActive(true);

    }


	
	// Update is called once per frame
	void Update () {
        PlayerMove();
    }
}
