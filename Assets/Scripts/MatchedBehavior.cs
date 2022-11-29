
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchedBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent, matchEvent, matchEventDelayed, nomatchEvent, nomatchDelayed;

    private IEnumerator OnTriggerEnter(Collider other)
    {
       // Debug.Log(idObj);
        //Debug.Log(other.GetComponent<IDContainerBehavior>().idobj);
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            yield break;
        var otherID = tempObj.idobj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
            yield return new WaitForSeconds(2.0f);
            matchEventDelayed.Invoke();
        }
        
        else
        {
            nomatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            nomatchDelayed.Invoke();
        }
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Object")
        {
            Destroy(gameObject);
        }
    }
}
