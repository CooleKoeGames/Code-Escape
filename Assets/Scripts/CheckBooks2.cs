//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit;

//public class CheckBooks2 : MonoBehaviour
//{
//    public XRSocketInteractor[] socketInteractors2;
//    public string[] bookTags;
//    public string[] socketTags;
//    public bool bookInRightPlace = false;
//    private string socketTag;

//    private void Update()
//    {
//        int count = 0;

//        for (int i = 0; i < socketInteractors2.Length; i++)
//        {
//            if (socketInteractors2[i].selectTarget != null)
//            {
//                for (int j = 0; j < bookTags.Length; j++)
//                {
//                    if (socketInteractors2[i].selectTarget.CompareTag(bookTags[j]) && socketInteractors2[i].socketTag == socketTags[j])
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