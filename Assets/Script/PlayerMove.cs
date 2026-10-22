using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// Input.GetAxisは古くて使えないってなったら、ProjectSettingsのPlayer
    /// Active Input Handling -> Bothにしたら解決した
    /// </summary>
    public float moveSpeed = 5.0f;
    Rigidbody rb;
    Vector3 input;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Debug.Log("Wキー: " + Input.GetKey(KeyCode.W));
        //ゆっくり加速したいので、GetAxisRawではなくGet.Axisにした
        //float moveInputX = Input.GetAxis("Horizontal");
        //float moveInputZ = Input.GetAxis("Vertical");

        ////キャラクターに移動を反映
        //transform.Translate(moveInputX * Time.deltaTime * moveSpeed, 0, moveInputZ * Time.deltaTime * moveSpeed);
    }

    void FixedUpdate()
    {
        // 物理の更新はFixedUpdateで。落下速度(y)はそのまま残す
        Vector3 v = input * moveSpeed;
        v.y = rb.linearVelocity.y;
        rb.linearVelocity = v;
    }
}
