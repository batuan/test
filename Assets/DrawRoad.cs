using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRoad : MonoBehaviour {

    public GameObject sprite;
    public GameObject ngang;
    public GameObject mLine1;
    public GameObject mLine2;
    private RenderLine renderLine1;
    private RenderLine renderLine2;
    public GameObject Agent;
    public void drawLine(Vector2 a, Vector2 b, float width){
        setUp();
        if((float)(a.x - b.x) == 0){
            drawX(a, b, width);
        }else{
            drawY(a, b, width);
        }


    }

    void setUp(){
        GameObject game1 = Instantiate(mLine1);
        renderLine1 = game1.GetComponent<RenderLine>();
        GameObject game2 = Instantiate(mLine2);
        renderLine2 = game2.GetComponent<RenderLine>();
    }

    void drawX(Vector2 a, Vector2 b, float width)
    {
        GameObject msprite = Instantiate(sprite);
        SpriteRenderer spriteRenderer = msprite.GetComponent<SpriteRenderer>();
        GameObject mAgent = Instantiate(Agent);
        Transform agentTranform = mAgent.GetComponent<Transform>();
        agentTranform.SetPositionAndRotation(new Vector3((a.x + b.x)/2, (a.y+b.y)/2), new Quaternion());
        float distance = Vector2.Distance(a, b);
        spriteRenderer.transform.localScale = new Vector3(width / (float)311, distance / (float)1640, 0);
        spriteRenderer.transform.position = new Vector3((a.x + b.x) / 2, (float)(a.y + b.y) / (float)2, 0);
        renderLine1.RenderMyLine(new Vector3(a.x - width/2, a.y, 0), new Vector3(b.x - width/2, b.y, 0));
        renderLine2.RenderMyLine(new Vector3(a.x + width/2, a.y, 0), new Vector3(b.x + width/2, b.y, 0));
    }

    void drawY(Vector2 a, Vector2 b, float width)
    {
        GameObject msprite = Instantiate(ngang);
        SpriteRenderer spriteRenderer = msprite.GetComponent<SpriteRenderer>();
        msprite.transform.rotation = new Quaternion(0, 0, -90, 0);
        float distance = Vector2.Distance(a, b);
        GameObject mAgent = Instantiate(Agent);
        Transform agentTranform = mAgent.GetComponent<Transform>();
        agentTranform.SetPositionAndRotation(new Vector3((a.x + b.x) / 2, (a.y + b.y) / 2), new Quaternion());
        spriteRenderer.transform.localScale = new Vector3(distance /(float)16.4  , width / (float)3.11, 0);
        spriteRenderer.transform.position = new Vector3((a.x + b.x) / 2, (float)(a.y + b.y) / (float)2, 0);
        renderLine1.RenderMyLine(new Vector3(a.x , a.y + width/2, 0), new Vector3(b.x, b.y + width/2, 0));
        renderLine2.RenderMyLine(new Vector3(a.x , a.y - width/2, 0), new Vector3(b.x, b.y - width/2, 0));
    }


}
