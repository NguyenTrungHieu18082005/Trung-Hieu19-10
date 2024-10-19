using UnityEngine;

public class lesson : MonoBehaviour
{
    // Tốc độ di chuyển của hình vuông
    public float moveSpeed = 5f;

    void Update()
    {
        // Lấy giá trị đầu vào từ bàn phím
        float moveX = 0f;
        float moveY = 0f;

        // Phím di chuyển ngang (A và D)
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;  // Di chuyển sang trái
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;  // Di chuyển sang phải
        }

        // Phím di chuyển dọc (S và E)
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;  // Di chuyển xuống
        }
        if (Input.GetKey(KeyCode.E))
        {
            moveY = 1f;  // Di chuyển lên
        }

        // Di chuyển đối tượng theo vector (moveX, moveY)
        Vector3 moveDirection = new Vector3(moveX, moveY, 0f).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
