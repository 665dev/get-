using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject item;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("get!");
        Destroy(item);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
