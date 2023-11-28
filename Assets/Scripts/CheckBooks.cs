//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit;

//public class CheckBooks : MonoBehaviour
//{
//    public XRSocketInteractor[] socketInteractors;
//    public string[] bookTags;
//    public bool bookInRightPlace = false;

//    private void Update()
//    {
//        int count = 0;

//        foreach (XRSocketInteractor socketInteractor in socketInteractors)
//        {
//            if (socketInteractor.selectTarget != null)
//            {
//                foreach (string tag in bookTags)
//                {
//                    if (socketInteractor.selectTarget.CompareTag(tag))
//                    {
//                        count++;
//                    }
//                }
//            }
//        }

//        if (count == bookTags.Length)
//        {
//            bookInRightPlace = true;
//            Debug.Log("door open " + count);
//        }
//    }
//}