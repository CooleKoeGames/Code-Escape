//using UnityEngine;

//public class BookTag : MonoBehaviour
//{
//    public float bookNumber = 0f;

//    private void Update()
//    {
//        if (bookNumber == 5f)
//        {
//            Debug.Log("you won");
//        }
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Book1"))
//        {
//            bookNumber++;
//        }

//        if (other.CompareTag("Book2"))
//        {
//            bookNumber++;
//        }

//        if (other.CompareTag("Book3"))
//        {
//            bookNumber++;
//        }

//        if (other.CompareTag("Book4"))
//        {
//            bookNumber++;
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        if (other.CompareTag("Book1"))
//        {
//            bookNumber--;
//        }

//        if (other.CompareTag("Book2"))
//        {
//            bookNumber--;
//        }

//        if (other.CompareTag("Book3"))
//        {
//            bookNumber--;
//        }

//        if (other.CompareTag("Book4"))
//        {
//            bookNumber--;
//        }
//    }
//}