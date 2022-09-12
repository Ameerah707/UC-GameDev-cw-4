using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MOVE : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 newPose = Camera.
            main.ScreenToWorldPoint(mousePos);
        transform.position = newPose;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "coin")
        {
            SceneManager.LoadScene(0);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(1);
    }

}   
