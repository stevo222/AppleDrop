
using System.Collections;

using UnityEngine;
using UnityEngine.Events;

public class DragableBehavior : MonoBehaviour
{

    private Camera _cameraObj;

    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    
    
    void Start()
    {
        _cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - _cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();
        
        
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            //Debug.Log("Drag");
            position = _cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
