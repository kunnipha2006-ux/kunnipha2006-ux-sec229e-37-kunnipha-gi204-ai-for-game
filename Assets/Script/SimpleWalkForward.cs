using UnityEngine;

public class SimpleWalkForward : MonoBehaviour
{
    [Header("Settings")]
    public float walkSpeed = 3.0f; // ความเร็วในการเดิน (เมตรต่อวินาที)

    void Update()
    {
        // สั่งให้เดินไปข้างหน้า (ตามทิศที่ตัวละครหันหน้าไป)
        transform.Translate(-Vector3.up * walkSpeed * Time.deltaTime);
    }
}