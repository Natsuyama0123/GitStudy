using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager m_instance;
    public static GameManager Instance => m_instance;

    void Awake()
    {
        if (!m_instance)
        {
            m_instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
