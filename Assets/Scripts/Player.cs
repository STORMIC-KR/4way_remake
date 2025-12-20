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
            print(curCodes);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            curCodes += "1";
            print(curCodes);
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            curCodes += "2";
            print(curCodes);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            curCodes += "3";
            print(curCodes);
        }
    }
}
