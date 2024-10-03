using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    private string stu1 = "Colin";
    //Create a empty Array of Strings
    public string[] students = new string[7] {/*0*/"Joseph",/*1*/"Emmanuel", /*2*/"Lebron", /*3*/"Justin", /*4*/"Bella", /*5*/"Evri", /*6*/"Colllin" };
    private GameObject[] floors;
    // Start is called before the first frame update

    //Make a list of Strings
    public List<string> stuList = new List<string>();
    //made a list for floors
    public List<GameObject> flList;
    //Make a stack for students
    //Stack in LIFO (Last in First out)
    public Stack<string> stuStack = new Stack<string>();
    //Make a Queue for students
    //Queue is FIFO (First in First out)
    public Queue<string> stuQueue = new Queue<string>();


    void Start()
    {
        //Change the last students spelling to stu1 variable
        students[6] = stu1;
        //add all of the students array to the list
        stuList.AddRange(students);
        //floors =  GameObject.FindGameObjectsWithTag("floor");
        //Make a new array not including absent students
        students = new string[6] { "Joseph", "Emmanuel", "Lebron", "Justin", "Bella", stu1 };

        //Remove absent students from the list
        stuList.Remove("Evri");

        //flList.AddRange(floors);

        //Add every student inside the list stuList to my stack

        foreach (string s in stuList)
        {
            stuStack.Push(s);
        }

        Debug.Log(stuStack.Pop());
      
    }

    // Update is called once per frame
    void Update()
    {
        //Print the number of items in the list and array
        //LIST COUNT
        //Debug.Log(stuList.Count);
        //ARRAY LENGTH
        //Debug.Log(students.Length);
        // -1 for <= no -1 for <
        /*for (int i= 0; i<students.Length ; i++)
        {
            Debug.Log(students[i]);
        }*/
    }
}
