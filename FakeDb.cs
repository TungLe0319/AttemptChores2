namespace AttemptChores2.Data;

public class FakeDb{
  public List<Chore> Chores = new List<Chore>()
  {
new Chore("Walk Coco",0,false,TaskType.Pets,1),
new Chore("Cat Litter",1,false,TaskType.Pets,2),
new Chore("Dishes",2,false,TaskType.House,3),
new Chore("Make Lunches",3,true,TaskType.Food,4),
new Chore("Fold Cloths",4,true,TaskType.Laundry,5)



  };
}