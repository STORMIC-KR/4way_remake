using UnityEngine;

public class Player : MonoBehaviour
{
    public string curCodes;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            curCodes += "0";
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            curCodes += "1";
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            curCodes += "2";
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            curCodes += "3";
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            curCodes = "";
        }
    }
}
