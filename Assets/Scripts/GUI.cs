using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

    //GUI Art
    public Texture hpBarTexture;
    public Texture manaBarTexture;
    public Texture barsBackgroundTexture;

    //USER GUI Bars stats;
    public float userHPBarLength;
    public float percentOfUserHP;
    public float userManaBarLength;
    public float percentOfUserMana;

    void OnGUI()
    {
        //GUI.DrawTexture(new Rect(20, 30, 120, 70), barsBackgroundTexture);
    

    }

}
