#A linked list is created using "Node" classes


#For a singly linked list we create the following class:

public class Node{
  public int data;  #we initialise the data of the linked list
  public Node next;   #we make the first node of the list
  public Node(int a){
    data = a;
    next = null;  #we set it to null
  }
}


#For a doubly linked list

public class DoubleNode{
  public int data;
  public DoubleNode prev;  #we create a pointer pointing to the previous value
  public DoubleNode next;  #we create a pointer pointing to the next value
  public DoubleNode(int a){
    data = a;
    prev = null;  #we set both values to null
    next = null;
  }
}
