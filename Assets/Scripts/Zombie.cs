using System.Linq;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    string myCodes;
    //public string codes_to_str;
    Player player;

    public SpriteRenderer[] arrows;
    public Sprite[] arrowSprites;

    public float curSpeed;
    public float maxSpeed;

    void Start()
    {
        player = Object.FindAnyObjectByType<Player>().GetComponent<Player>();
        curSpeed = maxSpeed;

        GenerateCodes();
    }

    void Update()
    {
        transform.Translate(Vector2.left * curSpeed * Time.deltaTime);
        if(player != null)
        {
            //if(player.count == 4)
            //{
            //    if (player.curCodes == myCodes)
            //    {
            //        print("correct");
            //        player.count = 0;
            //        player.curCodes = "";
            //        Destroy(this.gameObject);
            //    }
            //    else
            //    {
            //        print($"wrong, current code: {myCodes} / player code: {player.curCodes}");
            //        player.count = 0;
            //        player.curCodes = "";
            //    }
            //}
            
            if(transform.position.x - player.transform.position.x >= 0)
            {
                transform.GetChild(0).localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.GetChild(0).localScale = new Vector3(1, 1, 1);
            }
        }
    }

    //left:0
    //right:1
    //up:2
    //down:3

    void GenerateCodes()
    {
        for (int i = 0; i < 4; i++)
        {
            int code;
            code = Random.Range(0, 4);
            myCodes += code.ToString();
            arrows[i].sprite = arrowSprites[code];
            //if (code == 0)
            //{
            //    codes_to_str += "left / ";
            //}
            //else if(code == 1)
            //{
            //    codes_to_str += "right / ";
            //}
            //else if(code == 2)
            //{
            //    codes_to_str += "up / ";
            //}
            //else if(code == 3)
            //{
            //    codes_to_str += "down / ";
            //} 
        }
        //print(codes_to_str.ToString());
    }

    public void CheckKeyMatch(string playerInput)
    {
        if(myCodes == playerInput)
        {
            print("correct");
            Destroy(this.gameObject);
        }
        else
        {
            print("wrong");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Wall"))
        {
            print("collide");
            Destroy(this.gameObject);
        }
    }
}
