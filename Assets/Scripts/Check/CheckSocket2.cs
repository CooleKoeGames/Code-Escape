using UnityEngine;

public class CheckSocket2 : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(gameObject.tag))
        {
            Check.checkBook2 = true;
            //Debug.Log("Book 2");
        }
    }
}