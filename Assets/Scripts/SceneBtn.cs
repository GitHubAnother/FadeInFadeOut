/*
作者名称:YHB

脚本作用:OnGUI按钮切换场景

建立时间:2016.8.3.16.53
*/

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneBtn : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 100, 50), "切换场景"))
        {
            StartCoroutine(FadeScenes());
        }
    }

    IEnumerator FadeScenes()
    {
        float timer = GameObject.Find("Fade").GetComponent<FadeScene>().FadeTime(1);
        yield return new WaitForSeconds(timer);

        SceneManager.LoadScene(1);
    }
}
