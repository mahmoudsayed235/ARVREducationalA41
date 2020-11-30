using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reticule : MonoBehaviour
{
    public pointer m_Pointer;
    public SpriteRenderer m_CircleRender;

    public Sprite m_OpenSprite;
    public Sprite m_ClosedSprite;

    private Camera m_Camera = null;
    public void setCamera()
    {
        m_Camera = Camera.main;

    }
    private void Awake()
    {
        m_Pointer.OnPointerUpdate += UpdateSprite;

        m_Camera = Camera.main;
    }

    private void Update()
    {
        transform.LookAt(m_Camera.gameObject.transform);
    }

    private void OnDestory()
    {
        m_Pointer.OnPointerUpdate -= UpdateSprite;

    }

    private void UpdateSprite(Vector3 point,GameObject hitObject)
    {
        transform.position = point;
        if (hitObject)
        {
            m_CircleRender.sprite = m_ClosedSprite;
        }
        else
        {
            m_CircleRender.sprite = m_OpenSprite;

        }
    }
}
