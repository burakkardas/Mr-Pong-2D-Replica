using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area_Controller : MonoBehaviour
{
    [SerializeField] private Game_Manager gm;
    [SerializeField] private Player_Controller player_Controller;
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float[] _speed; 
    void Update()
    {
        if(gm._isLive == true) {
            transform.Translate(0f, _moveSpeed * Time.deltaTime, 0f);

            if(transform.position.y >= _points[0].position.y) {
            _moveSpeed *= -1;
            }
            else if(transform.position.y <= _points[1].position.y) {
                _moveSpeed *= -1;
            } 
        } 
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")) {
            _moveSpeed = _speed[Random.Range(0, _speed.Length)];
            player_Controller._moveSpeed *= -1;
            gm._score++;
        }
    }
}
