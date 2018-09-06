using UnityEngine;

public class StatsBar : MonoBehaviour {

    //variables provisionales y sus valores tambien.
    public float m_currentHp = 50;
    public float m_currentMana = 50;
    public float m_maxHp = 100;
    public float m_maxMana = 100;

    //GUI Art
    public Texture m_hpBarTexture;
    public Texture m_manaBarTexture;
    public Texture m_barsBackgroundTexture;

    //USER GUI Bars stats;
    public float m_userHPBarLength;
    public float m_percentHP;
    public float m_userManaBarLength;
    public float m_percentMana;

    private void fixBar()
    {
        if (m_currentHp > m_maxHp)
        {
            m_currentHp = m_maxHp;
        }

        if (m_currentMana > m_maxMana)
        {
            m_currentMana = m_maxMana;
        }

        if (m_currentMana < m_maxMana)
        {
            m_currentMana = 0;
        }

        if (m_currentMana < m_maxMana)
        {
            m_currentMana = 0;
        }
    }

    private void OnGUI()
    {
        //TODO: ver numero total de miembros en el grupo y mostrar mas si procede. y añadir imagen de la cara del pj
        GUI.DrawTexture(new Rect(20, 30, 120, 70), m_barsBackgroundTexture);
        GUI.DrawTexture(new Rect(30, 40, m_userHPBarLength, 20), m_hpBarTexture);
        GUI.DrawTexture(new Rect(30, 65, m_userManaBarLength, 20), m_manaBarTexture); //TODO: este no va :(
        GUI.Label(new Rect(50, 40, 200, 20), "" + m_currentHp + " / " + m_maxHp);
        GUI.Label(new Rect(50, 65, 200, 20), "" + m_currentMana + " / " + m_maxMana);
    }

    // Update is called once per frame
    void Update () {
        if (m_currentHp <= m_maxHp)
        {
            m_percentHP = m_currentHp / m_maxHp;
            m_userHPBarLength = m_percentHP * 100;
            m_percentMana = m_currentMana / m_maxMana * 100;
            m_userManaBarLength = m_percentMana * 100;
        }

        fixBar();
    }
}
