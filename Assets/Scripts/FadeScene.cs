/*
作者名称:YHB

脚本作用:实现淡入淡出的效果

建立时间:2016.8.3.16.57
*/

using UnityEngine;
using System.Collections;

public class FadeScene : MonoBehaviour
{
    #region 字段
    public Texture texture;
    public float fadeSpeed = 0.5f;//淡入淡出的速度

    private int fade = -1;//用来控制是淡入还是淡出的
    private float alpha = 1;//透明度
    #endregion

    void OnGUI()
    {
        alpha += fade * fadeSpeed * Time.deltaTime;

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), texture);//绘制全图的图片
    }

    void OnLevelWasLoaded()//unity回调函数，场景被加载的时候会调用
    {
        FadeTime(-1);
    }

    //JK---返回淡入使用的时间
    public float FadeTime(int fade)
    {
        this.fade = fade;
        return 1 / fadeSpeed;
    }

}
