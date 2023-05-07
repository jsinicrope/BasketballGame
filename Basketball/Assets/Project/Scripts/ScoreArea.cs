using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreArea : MonoBehaviour
{
    public GameObject effectObject;

    private void Start()
    {
        effectObject.SetActive(false);
    }


    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Ball> () != null)
        {
            effectObject.SetActive(true);
            StartCoroutine(sceneLoader());
        }
    }

    IEnumerator sceneLoader()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
