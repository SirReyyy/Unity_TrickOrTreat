using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    private float min = -2f;
    private float max = 2f;

    public Text scoreText;
    private int score = 0;

    // Update is called once per frame
    void Update() {
        MovePlayer();
    }

    void MovePlayer() {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;

        if(h > 0) {
            currentPosition.x += speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        } else if(h < 0) {
            currentPosition.x -= speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (currentPosition.x < min)
        {
            currentPosition.x = min;
        }

        if (currentPosition.x > max) {
            currentPosition.x = max;
        }

        transform.position = currentPosition;
    }

    private void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Candy") {
            score = score + 5;
            scoreText.text = "Score : " + score;
            target.gameObject.SetActive(false);
        }

        if (target.tag == "Roll")
        {
            score = score + 10;
            scoreText.text = "Score : " + score;
            target.gameObject.SetActive(false);
        }

        if (target.tag == "Trick") {
            Time.timeScale = 0f;
        }
    }
}
