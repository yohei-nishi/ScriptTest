using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;

    public void Magic()
    {
        if (this.mp > 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}
public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 2, 3, 5, 7 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int j = 0; j < array.Length; j++)
        { 
             int k = array.Length - 1 - j;
            Debug.Log(array[k]);
        }
        
        Boss lastboss= new Boss();

        for (int l = 0; l < 12; l++)
        { 
             lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
