using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckBooks4 : MonoBehaviour
{
    public XRSocketInteractor socketInteractor4;
    public string tagToCheck;
    public bool booksInRightPlace;
    public float booksRight = 0f;
    public int triggercount = 0;
    //public List<GameObject> triggers = new List<GameObject>();

    private bool b1;
    private bool b2;
    private bool b3;
    private bool b4;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag(tagToCheck))
    //    {
    //        if (socketInteractor4.selectTarget != null)
    //        {
    //            if (socketInteractor4.selectTarget.CompareTag(tagToCheck))
    //            {
    //                booksInRightPlace = true;
    //                Debug.Log(tagToCheck + " is in right place");
    //            }
    //        }
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag(gameObject.tag))
    //    {
    //        Debug.Log(other.gameObject.name + other.gameObject.tag + " trigger tag " + gameObject.name + gameObject.tag + " tag book");
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag(gameObject.tag))
    //    {
    //        if (booksInRightPlace == false)
    //        {
    //            booksRight++;
    //            Debug.Log(booksRight);

    //            if (booksRight == 4f)
    //            {
    //                booksInRightPlace = true;
    //                Debug.Log("the gate are open");
    //            }
    //        }

    //        Debug.Log(other.gameObject.name + other.gameObject.tag + " trigger tag " + gameObject.name + gameObject.tag + " tag book");
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(gameObject.tag))
        {
            if (booksInRightPlace == false)
            {
                booksRight++;
                Debug.Log(booksRight);

                if (booksRight == 4f)
                {
                    booksInRightPlace = true;
                    Debug.Log("the gate are open");
                }
            }
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag(gameObject.tag))
    //    {
    //        if (booksInRightPlace == false)
    //        {
    //            triggercount++;
    //            Debug.Log(triggercount);

    //            if (triggercount == 4f)
    //            {
    //                booksInRightPlace = true;
    //                Debug.Log("the gate are open");
    //            }
    //        }

    //        Debug.Log(other.gameObject.name + other.gameObject.tag + " trigger tag " + gameObject.name + gameObject.tag + " tag book");
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag(gameObject.tag))
    //    {
    //        if (booksInRightPlace == false)
    //        {
    //            triggercount--;
    //            Debug.Log(triggercount);

    //            if (booksRight == 4f)
    //            {
    //                booksInRightPlace = true;
    //                Debug.Log("the gate are open");
    //            }
    //        }

    //        Debug.Log(other.gameObject.name + other.gameObject.tag + " trigger tag " + gameObject.name + gameObject.tag + " tag book");
    //    }
    //}
}