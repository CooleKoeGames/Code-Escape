//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit;

//public class CheckBooks : MonoBehaviour
//{
//    public XRSocketInteractor[] socketInteractors;
//    public int books = 4;
//    public bool bookInRightPlace = false;

//    private void Update()
//    {
//        int count = 0;

//        foreach (XRSocketInteractor socketInteractor in socketInteractors)
//        {
//            if (socketInteractor.selectTarget != null)
//            {
//                //foreach (string tag in bookTags)
//                //{
//                //    if (socketInteractor.selectTarget.CompareTag(tag))
//                //    {
//                //        count++;
//                //    }
//                //}

//                if (socketInteractor.selectTarget.CompareTag(gameObject.tag))
//                {
//                    count++;
//                }

//            }
//        }

//        if (count == books)
//        {
//            bookInRightPlace = true;
//            Debug.Log("door open " + count);
//        }

//        //if (other.gameObject.CompareTag(gameObject.tag))
//        //{
//        //    Debug.Log(other.gameObject.name + other.gameObject.tag + " trigger tag " + gameObject.name + gameObject.tag + " tag book");
//        //}
//    }
//}