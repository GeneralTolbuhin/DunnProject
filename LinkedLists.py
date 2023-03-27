using System;

public class LinkedLiast
{
    public static void Main(string[] args)
    {
        
    }
}


//A linked list is created inside a special linked list class


// For a normal linked list we create the following class:

private class Node(
    private int data;  //we initialise the data of the linked list
    private Node next;   //we make the first node of the list
    public Node(int a) { 
        data = a;
        next = null;  //we set it to null
    }  
}  

  
 
private class LinkedList{
  private node head; //we initialise the linked list with a node and a head
  
//For a doubly linked list

private class DoubleNode {  
    private int data;  
    private DoubleNode prev;  //we create a pointer pointing to the previous value
    private DoubleNode next;  //we create a pointer pointing to the next value
    public DoubleNode(int a) {  
        data = a;  
        prev = null;  //we set both values to null
        next = null;  
    }  
}  
  
  
private class DoubleLinkedList {  
    private DoubleNode head;  //we initialise the linked 
}  
