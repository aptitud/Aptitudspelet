using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    private Renderer renderer;
    private IEnumerable<Renderer> childRenderers;


    void Start()
    {
        renderer = GetComponent<Renderer>();
        childRenderers = GetComponentsInChildren<Renderer>(true);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obsticle")
        {
            renderer.enabled = false;
            foreach (var childRenderer in childRenderers)
            {
                childRenderer.enabled = false;
            }

            StartCoroutine(Restart());
            Destroy(gameObject, 2);
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1);
        GameManager.StartNewGame();
    }
}
