using Mono.Cecil.Cil;
using NUnit.Framework;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string curCodes;
    public GameObject arrows;
    public Sprite[] arrowSprites;
    public AudioSource audioSource;
    public AudioClip[] clips; //0: click, 1: defeat, 2: dml_1, 3: dml_2

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AddKeyNumber("0");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            AddKeyNumber("1");
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AddKeyNumber("2");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            AddKeyNumber("3");
        }
        
    }

    void AddKeyNumber(string numK)
    {
        curCodes += numK;
        arrows.transform.GetChild(curCodes.Length - 1).GetComponent<SpriteRenderer>().sprite = arrowSprites[int.Parse(numK)]; //???
        if(audioSource.clip != clips[0])
        {
            audioSource.clip = clips[0];
        }
        audioSource.Play();
        if(curCodes.Length == 4)
        {
            ResetSprites();
        }
    }

    void CompareToZombies()
    {
        Zombie[] zombies = Object.FindObjectsByType<Zombie>(FindObjectsSortMode.None);
        foreach(Zombie zombie in zombies)
        {
            zombie.CheckKeyMatch(curCodes);
        }
    }

    void ResetSprites()
    {
        for (int i = 0; i < curCodes.Length; i++)
        {
            arrows.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = null;
        }
        CompareToZombies();
        curCodes = null;
    }

}
