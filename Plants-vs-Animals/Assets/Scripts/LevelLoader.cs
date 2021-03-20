using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    private int currBuildIndex;
    [SerializeField]
    private float waitTime=4f;
    void Start()
    {
        currBuildIndex = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(ILoadSNextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ILoadSNextScene()
    {
        yield return new WaitForSeconds(waitTime);
        LoadNextScene();
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currBuildIndex + 1);
    }
}
