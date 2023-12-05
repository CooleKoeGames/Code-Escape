using UnityEngine;

public class Check : MonoBehaviour
{
    [SerializeField] private GameObject check1;
    [SerializeField] private GameObject check2;
    [SerializeField] private GameObject check3;
    [SerializeField] private GameObject check4;

    public static bool checkBook1;
    public static bool checkBook2;
    public static bool checkBook3;
    public static bool checkBook4;

    private void Update()
    {
        if (checkBook1 && checkBook2 && checkBook3 && checkBook4)
        {
            DoorOpen.bookInRightPlace = true;

            //Debug.Log("Door is open");

            Destroy(check1.GetComponent<CheckSocket1>());
            Destroy(check2.GetComponent<CheckSocket2>());
            Destroy(check3.GetComponent<CheckSocket3>());
            Destroy(check4.GetComponent<CheckSocket4>());

            //check1.GetComponent<CheckSocket1>().enabled = false;
            //check2.GetComponent<CheckSocket2>().enabled = false;
            //check3.GetComponent<CheckSocket3>().enabled = false;
            //check4.GetComponent<CheckSocket4>().enabled = false;

            gameObject.GetComponent<Check>().enabled = false;
        }
    }
}