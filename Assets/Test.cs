using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        int[] array = new int[5];

        array[0] = 10;
        array[1] = 15;
        array[2] = 20;
        array[3] = 30;
        array[4] = 40;

        for (int i = 0; i < 5; i++) {
            Debug.Log(array[i]);

        }
        for (int i =4;i>0; i--) {
            Debug.Log(array[i]);
        }
    }
}





