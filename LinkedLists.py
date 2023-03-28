#A linked list is created inside a special linked list class


#For a singly linked list we create the following classes:

public class Node{
  public int data;  #we initialise the data of the linked list
  public Node next;   #we make the first node of the list
  
  public Node(int data){
    this.data = data;
    next = null;  #we set it to null
  }
}

public class LinkedList{
  public Node head;  #we initialise the linked list with a node for a head
  
  public LinkedList(int data){
    head = new Node(data);
  }
}

#For a doubly linked list

public class DoubleNode{
  public int data;
  public DoubleNode prev;  #we create a pointer pointing to the previous value
  public DoubleNode next;  #we create a pointer pointing to the next value
  
  public DoubleNode(int data){
    this.data = data;
    prev = null;  #we set both values to null
    next = null;
  }
}

public class DoubleLinkedList{
  public DoubleNode head;  #we initialise the linked list with a double node for a head
  
  public DoubleLinkedList(int data){
    head = new DoubleNode(data);
  }
}
