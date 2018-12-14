using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    private Renderer playerRenderer;
    private IEnumerable<Renderer> childRenderers;


    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
        childRenderers = GetComponentsInChildren<Renderer>(true);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obsticle")
        {
            playerRenderer.enabled = false;
            foreach (var childRenderer in childRenderers)
            {
                childRenderer.enabled = false;
            }

            StartCoroutine(Restart());
            Destroy(gameObject, 2);
        }
        else if (collision.gameObject.tag == "Logo")
        {
            Destroy(collision.gameObject);
            ScoreKeeper.IncrementScore();
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1);
        ScoreKeeper.End();
        GameManager.StartNewGame();
    }
}
