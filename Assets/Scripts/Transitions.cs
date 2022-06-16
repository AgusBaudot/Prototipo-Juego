using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    public Animator animator;

    private int MenuToLoad;

    private void Start()
    {
        gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || GameObject.Find("Player") == null)
        {
            int y = SceneManager.GetActiveScene().buildIndex;
            FadeToMenu(y+1);
        }
    }
    public void FadeToMenu(int menuIndex)
    {
        MenuToLoad = menuIndex;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(MenuToLoad);
    }
}
