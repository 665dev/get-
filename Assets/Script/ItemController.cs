using UnityEngine;

public class ItemController : MonoBehaviour
{
    private ItemManager itemManager;

    void Start()
    {
        // シーン内のItemManagerを探して取得
        itemManager = Object.FindAnyObjectByType<ItemManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (itemManager != null)
            {
                itemManager.CollectItem();
            }
            Destroy(gameObject); // アイテムを消す
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
    }

}