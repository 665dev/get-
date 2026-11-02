using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject[] sphereObject = null;
    //int count = 0;
    //奮闘記
    //void Start()
    //{
    //    count = GameObject.FindGameObjectsWithTag("Item").Length; 
    //}

    void Update()
    {
        sphereObject = GameObject.FindGameObjectsWithTag("Item");
        //count--;
        Debug.Log("現在のアイテム数" + (sphereObject.Length /*- count*/));
    }
}
