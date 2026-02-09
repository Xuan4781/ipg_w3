using UnityEngine;

public class DoorComponent : MonoBehaviour
{
    public PlayerComponent.PlayerColor requiredColor;
    private bool isOpen;

    void OnTriggerEnter(Collider other)
    {
        PlayerComponent player = other.GetComponent<PlayerComponent>();

        if(player != null)
        {
            isOpen = player.currentColor == requiredColor ? true : false;

            transform.position += isOpen ? Vector3.up * 3 : Vector3.zero; 
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
