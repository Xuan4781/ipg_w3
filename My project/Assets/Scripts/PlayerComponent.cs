using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    public enum PlayerColor {Red, Blue, Green}
    public PlayerColor currentColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeColor(1);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeColor(2);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            ChangeColor(3);
    }

    void ChangeColor(int colorChoice)
    {
        switch(colorChoice)
        {
            case 1:
                currentColor = PlayerColor.Red;
                // change color of the door
                break;
            case 2:
                currentColor = PlayerColor.Blue;
                // change color of the door
                break;
            case 3: 
                currentColor = PlayerColor.Green;
                // change color of the door
                break;
        }
    }
}
