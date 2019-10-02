using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomColor : MonoBehaviour
{
  
    public Color[] ColorBank;
    public bool sprite = false;
    public SpriteRenderer s;
    public int num;

    void Start()
    {
        ChangeColor();
            s = GetComponent<SpriteRenderer>();
            s.color = ColorBank[num];
    }
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor();
            s.color = ColorBank[num];
             
            
        }
    }

    public void ChangeColor(){
        num = Random.Range(0, ColorBank.Length -1);
    }
}
