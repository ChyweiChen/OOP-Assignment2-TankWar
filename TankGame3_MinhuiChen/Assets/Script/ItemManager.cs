using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemManager : MonoBehaviour {

    public GameObject Add_Health;
    public GameObject Add_Damage;
    public GameObject Add_Barrel;

    public Item[] item;
    public GameObject[] ItemPos;
	// Use this for initialization
	void Start () {

                System.Random ran = new System.Random();
                int Item = ran.Next(0, 2);
                int Item_born = ran.Next(0, 5);

                switch (Item)
                {
                    case 0:
                        Instantiate(Add_Health, ItemPos[Item_born].transform.position, ItemPos[Item_born].transform.rotation);
                        break;
                    case 1:
                        Instantiate(Add_Damage, ItemPos[Item_born].transform.position, ItemPos[Item_born].transform.rotation);
                        break;
                    case 2:
                        Instantiate(Add_Barrel, ItemPos[Item_born].transform.position, ItemPos[Item_born].transform.rotation);
                        break;
                }




    }

    // Update is called once per frame
    void Update () {

    }
}
