public class Node{
  public int data;
  public Node prev;
  public Node next;

  public Node(int data){
    this.data = data;
    prev = null;
    next = null;
  }
}

public class LinkList{
  public Node head;

  public LinkList(){
    head = null;
  }

  public void InsertFront(int data){
    Node temp = new Node(data);
    temp.next = head;
    temp.prev = null;
    if (head != null) {
        head.prev = temp;
    }
    head = temp;
  }

  public void InsertLast(int data){
    if(head == null) {
      InsertFront(data);
    }
    Node last = GetLast();
    Node temp = new Node(data);
    last.next = temp;
    temp.prev = last;
  }

  public Node GetLast(){
    Node temp = head;
    while(temp.next != null){
      temp = temp.next;
    }
    return temp;
  }

  public void InsertInPosition(int position, int data){
    Node temp = head;
    for(int i = 0; i < position; i++){
      temp = temp.next;
    }
    InsertAfter(temp.prev, data);
  }

  private void InsertAfter(Node previous, int data){
    Node temp = new Node(data);
    temp.next = previous.next;
    previous.next = temp;
    temp.prev = previous;
    if (temp.next != null) {
        temp.next.prev = temp;
    }
  }

  public void Delete(int data){
    Node temp = head;
    while(temp != null){
      if(temp.data == data){
        if(temp.prev != null){
          temp.prev.next = temp.next;
        }
        else{
          head = temp.next;
        }
        if(temp.next != null){
          temp.next.prev = temp.prev;
        }
        else{
          temp.prev = null;
        }
        return;
      }
      temp = temp.next;
    }
  }

  public void Print(){
    Node temp = head;
    while(temp != null){
      Console.WriteLine(temp.data);
      temp = temp.next;
    }
  }
}
