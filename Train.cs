using System;
public class Train{
  public static void Main(string[] args){
    LinkList train = new LinkList();
    Console.WriteLine("Add a few wagons");
    train.InsertLast("cows");
    train.InsertFront("locomotive");
    train.InsertLast("coal");
    train.Print();

    Console.WriteLine("Insert in position and delete");
    train.InsertInPosition(2, "electronics");
    train.Delete("cows");
    train.Print();

    Console.WriteLine("Reverse the train");
    train.Reverse();
    train.Print();

    Console.WriteLine("Clear the train");
    train.head = null;  //same as List.Clear(); for lists
    train.Print();
    Console.WriteLine("The train is gone :(");
  }
}
public class Node{
  public string wagon;
  public Node next;

  public Node(string wagon){
    this.wagon = wagon;
    next = null;
  }
}

public class LinkList{
  public Node head;

  public LinkList(){
    head = null;
  }

  public void InsertFront(string wagon){  //useful for implementing stacks
    Node temp = new Node(wagon);
    temp.next = head;
    head = temp;
  }

  public void InsertLast(string wagon){  //useful for implementing queues
    if(head == null) {
      InsertFront(wagon);
      return;
    }
    Node last = GetLast();
    Node temp = new Node(wagon);
    last.next = temp;
  }

  public Node GetLast(){
    Node temp = head;
    while(temp.next != null){
      temp = temp.next;
    }
    return temp;
  }

  public void InsertInPosition(int position, string wagon){
    Node temp = head;
    for(int i = 0; i < position - 1; i++){
      temp = temp.next;
    }
    InsertAfter(temp, wagon);
  }

  private void InsertAfter(Node previous, string wagon){
    Node temp = new Node(wagon);
    temp.next = previous.next;
    previous.next = temp;
  }

  public void Delete(string wagon){
    Node current = head;
    Node previous = null;
    while(current != null){
      if(current.wagon == wagon){
        if(previous != null){
          previous.next = current.next;
        }
        else{
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
        next = current.next;
        current.next = previous;

        previous = current;
        current = next;
    }
    head = previous;
  }

  public void Print(){
    Node temp = head;
    while(temp != null){
      Console.WriteLine(temp.wagon);
      temp = temp.next;
    }
    Console.WriteLine();
  }
}
