using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    public Animator animator;

    private int MenuToLoad;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            FadeToMenu(1);
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
