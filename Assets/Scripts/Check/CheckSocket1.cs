using UnityEngine;

public class CheckSocket1 : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(gameObject.tag))
        {
            Check.checkBook1 = true;
            //Debug.Log("Book 1");
        }
    }
}