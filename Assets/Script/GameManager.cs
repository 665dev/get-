using UnityEngine;
using TMPro; // TextMeshProを使う場合

public class ItemManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI clearText; // 表示するテキスト
    private int totalItems; // フィールド上のアイテム総数
    private int collectedCount = 0; // 取得したアイテムの数

    void Start()
    {
        // 「Item」タグがついているオブジェクトをすべて数える
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        totalItems = items.Length;

        // 最初はテキストを非表示にする
        if (clearText != null)
        {
            clearText.gameObject.SetActive(false);
        }
    }

    // アイテムが取得されたときに呼び出すメソッド
    public void CollectItem()
    {
        collectedCount++;

        // すべて取得したかチェック
        if (collectedCount == totalItems)
        {
            ShowClearText();
        }
    }

    private void ShowClearText()
    {
        if (clearText != null)
        {
            clearText.gameObject.SetActive(true);
        }
    }
}


//using TMPro;
//using UnityEngine;

//public class GameManager : MonoBehaviour
//{
//    GameObject[] sphereObject = null;
//    [SerializeField] private TextMeshProUGUI clearText = null;
//    private int totalItems;
//    private int collectedCount = 0; // 取得したアイテムの数
//    //int count = 0;
//    //奮闘記
//    void Start()
//    {
//        totalItems = sphereObject.Length;
//        if (clearText != null)
//        {
//            clearText.gameObject.SetActive(false);
//        }
//    }

//void Update()
//    {
//        sphereObject = GameObject.FindGameObjectsWithTag("Item");
//        //count--;
//        Debug.Log("現在のアイテム数" + (sphereObject.Length /*- count*/));
//        if (sphereObject.Length)
//        {

//        }
//    }
//}
