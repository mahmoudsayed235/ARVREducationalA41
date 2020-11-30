using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class pointer : MonoBehaviour
{
    public float m_Distance = 10.0f;
    public LineRenderer m_LineRenderer = null;
    public LayerMask m_EverythingMask = 0;
    public LayerMask m_InteractableMask= 0;
    public UnityAction<Vector3, GameObject> OnPointerUpdate = null;

    private Transform m_CurrentOrigin = null;
    private GameObject m_CurrentObject = null;


    private void Awake()
    {
        playerEvents.OnControllerSource += UpdateOrigin;
     //   playerEvents.OnTouchpadDown += ProcessTouchpadDown;
        playerEvents.OnTriggerDown += ProcessTriggerDown;
    }

    private void Start()
    {
        SetLineColor();
    }

    private void OnDestory()
    {
        playerEvents.OnControllerSource -= UpdateOrigin;
      //  playerEvents.OnTouchpadDown -= ProcessTouchpadDown;
        playerEvents.OnTriggerDown -= ProcessTriggerDown;
    }

    private void Update()
    {
        Vector3 hitPoint = UpdateLine();
        m_CurrentObject = UpdatePointerStatus();

        if (OnPointerUpdate != null)
        {
            OnPointerUpdate(hitPoint,m_CurrentObject);
        }
    }
    private Vector3 UpdateLine()
    {
        //create ray
        RaycastHit hit = CreateRaycast(m_EverythingMask);


        //default end
        Vector3 endPostion = m_CurrentOrigin.position+(m_CurrentOrigin.forward * m_Distance);

        //check hit
        if (hit.collider != null)
        {
            
            endPostion = hit.point;
          // do action
        }

        //set position
        m_LineRenderer.SetPosition(0,m_CurrentOrigin.position);
        m_LineRenderer.SetPosition(1, endPostion);
        return endPostion;
    }

    private void UpdateOrigin(OVRInput.Controller controller,GameObject controllerObject)
    {
        //set origin of pointer
        m_CurrentOrigin = controllerObject.transform;

        //is the laser visible
        if (controller == OVRInput.Controller.Touchpad)
        {
            m_LineRenderer.enabled = false;
        }
        else
        {
            m_LineRenderer.enabled = true;
        }
    }

    private GameObject UpdatePointerStatus()
    {
        //create ray
        RaycastHit hit = CreateRaycast(m_InteractableMask);
        //check hit
        if (hit.collider)
        {
            return hit.collider.gameObject;
        }
        //return
        return null;
    }

    private RaycastHit CreateRaycast(int layer)
    {
        RaycastHit hit;
        Ray ray = new Ray(m_CurrentOrigin.position,m_CurrentOrigin.forward);
        Physics.Raycast(ray, out hit, m_Distance,layer);

        return hit;
    }
    private void SetLineColor()
    {
        if (!m_LineRenderer)
        {
            return;
        }

        Color endColor = Color.white;
        endColor.a = 0.0f;
        m_LineRenderer.endColor = endColor;
    }
    private void ProcessTouchpadDown()
    {
        if (!m_CurrentObject)
        {
            return;
        }

        interactable Interactable = m_CurrentObject.GetComponent<interactable>();
        Interactable.Pressed(m_CurrentObject.name);
    }
    private void ProcessTriggerDown()
    {
        if (!m_CurrentObject)
        {
            return;
        }

        interactable Interactable = m_CurrentObject.GetComponent<interactable>();
        Interactable.Pressed(m_CurrentObject.name);
    }



}
