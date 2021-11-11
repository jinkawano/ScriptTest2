using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;
    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
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
        int[] array = {3, 1, 4, 1, 5};
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array [i]);
        }
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array [i]);
        }
        Boss magicshoot = new Boss();
        for (int i = 1; i <= 11; i++)
        {
            magicshoot.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
