using UnityEngine;

public class CheckSocket3 : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(gameObject.tag))
        {
            Check.checkBook3 = true;
            //Debug.Log("Book 3");
        }
    }
}