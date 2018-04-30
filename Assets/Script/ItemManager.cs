using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemManager : MonoBehaviour {

    public GameObject Add_Health;
    public GameObject Add_Damage;
    public GameObject Add_Barrel;
    //public GameObject Add_Collider;
    public int ItemType =0 ;

    public GameObject[] ItemPos;
    //Boolean Health, Damage, Barrel = false;
    public int No_Item = 0;
    System.DateTime currentTime = new System.DateTime();
    public int Item, Item_Pos, Ran_Item, Ran_Item_Pos = 0;
    
    // Use this for initialization
    void Start () {
        InvokeRepeating("Create_Item",5, 20);

    }

    // Update is called once per frame

    
    int No_Item_Control()
    {
        if (No_Item > 0)
        {
            No_Item --;
        }
        return No_Item;
    }
    void Create_Item()
    {
        if (No_Item < 2)
        {
            System.Random ran = new System.Random();

            do
            {
                Ran_Item = ran.Next(1, 4);

            } while (Item == Ran_Item);
            Item = Ran_Item;
            do
            {
                Ran_Item_Pos = ran.Next(0, 6);
            }
            while (Item_Pos == Ran_Item_Pos);
            Item_Pos = Ran_Item_Pos;

            switch (Item)
            {
                case 1:
                    Instantiate(Add_Health, ItemPos[Item_Pos].transform.position, ItemPos[Item_Pos].transform.rotation);
                    No_Item++;
                    break;
                case 2:
                    Instantiate(Add_Damage, ItemPos[Item_Pos].transform.position, ItemPos[Item_Pos].transform.rotation);
                    No_Item++;
                    break;
                case 3:
                    Instantiate(Add_Barrel, ItemPos[Item_Pos].transform.position, ItemPos[Item_Pos].transform.rotation);
                    No_Item++;
                    break;
            }
        }
    }
    public void OnTriggerEnter(Collider collider)
    {
        GameObject.Destroy(this.gameObject);

        if (collider.tag == "tank")  //when buff touch tank
        {

            if (ItemType == 0)
            {
                collider.SendMessage("Add_Health");
                GameObject.Find("ItemManager").SendMessage("No_Item_Control");
                GameObject.Find("AddHealthAudio").SendMessage("PlayAudio");
            }

            if (ItemType == 1)
            {
                
                collider.SendMessage("Add_Damage");
                GameObject.Find("ItemManager").SendMessage("No_Item_Control");
                GameObject.Find("AddDamageAudio").SendMessage("PlayAudio");
            }

            if (ItemType == 2)
            {
               
                collider.SendMessage("Add_Speed");
                GameObject.Find("ItemManager").SendMessage("No_Item_Control");
                GameObject.Find("AddSpeedAudio").SendMessage("PlayAudio");
            }
        }

            
    }
    void Update()
    {
    }

}

