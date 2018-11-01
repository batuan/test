using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw1 : MonoBehaviour {
    public DrawRoad myDraw;
    List<node> myNode;
    List<Road> myRoad;
    // Use this for initialization
    public void Start()
    {
        SetRoad();
        foreach(Road road in myRoad) {
            node n1 = myNode[road.node1-1];
            node n2 = myNode[road.node2-1];
            myDraw.drawLine(new Vector2(n1.xPos, n1.yPos), new Vector2(n2.xPos, n2.yPos), road.width);

        }
    }


    void SetRoad()
    {
        myNode = new List<node>();
        myRoad = new List<Road>();
        string[] lines = System.IO.File.ReadAllLines("C:\\Users\\ThaiTuan\\Documents\\simulation\\Assets\\graph.txt");
        foreach (string line in lines)
        {
            string[] words = line.Split(';');
            int thutu = int.Parse(words[0]);
            float x = float.Parse(words[1]) / 10;
            float y = float.Parse(words[2])/10;
            int index = 3;
            while (index < words.Length - 1)
            {
                int dinhKe = int.Parse(words[index].Split('#')[1]);
                float leng = float.Parse(words[index + 1])/10;
                float wid = float.Parse(words[index + 2]);
                float tr = float.Parse(words[index + 3]);
                Road mRoad = new Road(thutu, dinhKe, leng, wid, tr);
                myRoad.Add(mRoad);
                index = index + 4;
            }
            node mNode = new node(x, y);
            myNode.Add(mNode);
        }
    }
}
