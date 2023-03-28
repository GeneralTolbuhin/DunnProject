public class Node{
  public int data;
  public Node next;

  public Node(int data){
    this.data = data;
    next = null;
  }
}

public class LinkList{
  public Node head;

  public LinkList(){
    head = null;
  }

  public void InsertFront(int data){  //useful for implementing stacks manually
    Node temp = new Node(data);
    temp.next = head;  //connect the new node first to not lose the head's position
    head = temp;
  }

  public void InsertLast(int data){  //useful for implementing queues manually
    if(head == null) {  //when the head is null we have nothing to connect the new node to
      InsertFront(data);
      return;
    }
    Node last = GetLast();
    Node temp = new Node(data);
    last.next = temp;
  }

  public Node GetLast(){
    Node temp = head;
    while(temp.next != null){  //when the next node is null we know we are at the last node
      temp = temp.next;
    }
    return temp;
  }

  public void InsertInPosition(int position, int data){  //position starts counting from 0
    Node temp = head;
    for(int i = 0; i < position - 1; i++){  //since we use InsertAfter we want to insert after position - 1
      temp = temp.next;
    }
    InsertAfter(temp, data);
  }

  private void InsertAfter(Node previous, int data){
    Node temp = new Node(data);
    temp.next = previous.next;  //we give the new node a value first to not lose the position of previous
    previous.next = temp;
  }

  public void Delete(int data){
    Node current = head;
    Node previous = null;  //since this isn't a doubly linked list we need a variable to store the previous node
    while(current != null){
      if(current.data == data){
        if(previous != null){
          previous.next = current.next;
        }
        else{  //when we have no previous we have nothing to attatch ne next node to
          head = current.next;
        }
        return;
      }
      previous = current;
      current = current.next;
    }
  }
  
  public void Reverse(){
    Node current = head;
    Node previous = null;
    Node next = null;
    while(current != null){
        // Store the next node.
        next = current.next;

        // Reverse the link.
        current.next = previous;

        // Move pointers one position ahead.
        previous = current;
        current = next;
    }

    // Update the head node.
    head = previous;
  }
  
  public void Print(){
    Node temp = head;
    while(temp != null){
      Console.WriteLine(temp.data);
      temp = temp.next;
    }
    Console.WriteLine();
  }
}
