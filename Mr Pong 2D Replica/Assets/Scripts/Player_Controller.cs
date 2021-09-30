using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Game_Manager gm;
    public float _moveSpeed;
    [SerializeField] private float _jumpForce;
    void Update()
    {
        if(gm._isLive == true && gm._isStart == true) {
            if(Input.GetMouseButtonDown(0)) {
                rb.velocity = new Vector2(
                    _moveSpeed,
                    _jumpForce
                );
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Thorn")) {
            gm.GameOver();
        }
    }
}
