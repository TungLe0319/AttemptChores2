namespace AttemptChores2.Services;

public class ChoresService{
  private readonly FakeDb _db;

  public List<Chore> GetChores()
{
  return _db.Chores;
}

public Chore GetChore(int id)
{
  var chore = _db.Chores.Find(c=> c.Id == id);
 if( chore == null)
 {
 throw new Exception("Invalid Id");
 }
 return chore;
}


public Chore AddChore(Chore choreData)
{
  _db.Chores.Add(choreData);
  return choreData;
}

public Chore DeleteChore(int id)
{
var chore = _db.Chores.Find(c=> c.Id == id);
 if(chore == null )
 {
 throw new Exception("Invalid Id [DeleteChore]");
 }

 _db.Chores.Remove(chore);
//NOTE Hi
return  chore;
}





public ChoresService(FakeDb db)
{
  _db = db;
}
}