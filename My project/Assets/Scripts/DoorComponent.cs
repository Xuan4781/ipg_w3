using UnityEngine;

public class DoorComponent : MonoBehaviour
{
    public PlayerComponent.PlayerColor requiredColor; 
    private bool isOpen;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();

        switch (requiredColor)
        {
            case PlayerComponent.PlayerColor.Red:
                rend.material.color = Color.red;
                break;
            case PlayerComponent.PlayerColor.Blue:
                rend.material.color = Color.blue;
                break;
            case PlayerComponent.PlayerColor.Green:
                rend.material.color = Color.green;
                break;
        }

        transform.position += Vector3.up * 1f;
    }

    // change to trigger stay
    void OnTriggerStay(Collider other)
    {
        PlayerComponent player = other.GetComponent<PlayerComponent>();
        if (player != null)
        {
            // check if door color match
            isOpen = player.currentColor == requiredColor;
        }
    }

    void Update()
    {
        if (isOpen)
        {
            transform.position += Vector3.up * 3f * Time.deltaTime;
        }
    }
}
