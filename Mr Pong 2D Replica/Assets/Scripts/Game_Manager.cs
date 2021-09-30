using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game_Manager : MonoBehaviour
{   
    [SerializeField] private Player_Controller player_Controller;
    [SerializeField] private TMP_Text _scoreText;
    public int _score = 0;
    public bool _isLive;
    public bool _isStart;

    private void Start() {
        _isLive = true;

        StartCoroutine(StartGame());
    }
    
    private void Update() {
        _scoreText.text = _score.ToString();
    }

    IEnumerator StartGame() {
        yield return new WaitForSeconds(1.5f);
        _isStart = true;
        player_Controller.GetComponent<Rigidbody2D>().gravityScale = 2;
    }

    public void GameOver() {
        SceneManager.LoadScene(0);
    }
}
