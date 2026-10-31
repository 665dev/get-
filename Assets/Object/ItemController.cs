using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("touch!" + other.name); // 誰に当たったか表示
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// 奮闘記
    /// </summary>
    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("touch!");
    //    if (other.gameObject == player)
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
