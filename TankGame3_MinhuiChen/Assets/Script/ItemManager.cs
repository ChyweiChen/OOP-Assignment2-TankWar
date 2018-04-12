﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemManager : MonoBehaviour {

    public GameObject Add_Health;
    public GameObject Add_Damage;
    public GameObject Add_Barrel;

    public Item[] item;
    public GameObject[] ItemPos;
    //Boolean Health, Damage, Barrel = false;
    System.DateTime currentTime = new System.DateTime();
    public int Item, Item_Pos, Ran_Item, Ran_Item_Pos = 0;

	// Use this for initialization
	void Start () {
        Invoke("Create_Item",1);
    }

    // Update is called once per frame
    void Update () {
        
        }
	void Create()
	{
		Invoke("Create_Item",5);
	}
    void Create_Item()
    {
        System.Random ran = new System.Random();

        int Item = ran.Next(0, 2);
        int Item_Pos = ran.Next(0, 5);

        switch (Item)
            {
                case 0:
                        Instantiate(Add_Health, ItemPos[Item_Pos].transform.position, ItemPos[Item_Pos].transform.rotation);
                    break;
                case 1:
                        Instantiate(Add_Damage, ItemPos[Item_Pos].transform.position, ItemPos[Item_Pos].transform.rotation);
                    break;
                case 2:
                        Instantiate(Add_Barrel, ItemPos[Item_Pos].transform.position, ItemPos[Item_Pos].transform.rotation);
                    break;
            }

    }
}
