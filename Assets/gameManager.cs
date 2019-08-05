using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public Text candy;
    public int candyCurrent;
    public int candyMax;
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void scoreUpdate()
    {
        candyCurrent = candyCurrent + 1;

    }
}
