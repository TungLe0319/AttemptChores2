namespace AttemptChores2.Models;

public class Chore{

  public int Id{ get; private set; }
  public string Name { get; private set; }
  public int ChoreCount { get; private set; }
  public bool IsCompleted { get; private set; }

public TaskType Task {get; private set;}
  public Chore(string name, int choreCount, bool isCompleted, TaskType task, int id){
Id = id;
Name = name;
ChoreCount = choreCount;
IsCompleted = isCompleted;
Task= task;




  }

}