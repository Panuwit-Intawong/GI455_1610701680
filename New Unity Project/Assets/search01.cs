using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class search01 : MonoBehaviour
{
    private string profile;
    public Text found;
    public InputField file;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        profile = file.text;
    }

    void isFound()
    {
        found.text = profile + " is found";


    }
    public void Button()
    {
        switch (profile)
        {
                case "Minecraft":
                isFound();
                break;

                case "GoldenApple":
                isFound();
                break;

                case "Slime":
                    isFound();
                    break;

                case "Axe":
                    isFound();
                    break;

                case "Sword":
                 isFound();
                break;
            default:
                found.text = profile + " is not found";
                break;
            }
    }
}
