using UnityEngine;

public class CheckSocket4 : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(gameObject.tag))
        {
            Check.checkBook4 = true;
            //Debug.Log("Book 4");
        }
    }
}