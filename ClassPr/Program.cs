// Создание экзепляров классов
Player newPlayer = new("Player", 10, 10);
StaticObject newObject = new(50, 50);


// Интерфейс базовой сущности
public interface IEntity
{
    int id { get; set; }
    float posX {  get; set; }
    float posY { get; set; }
}


// Интерфейс для реализации движения
public interface IMovable
{
    float speed { get; set; }
    void Move();
}


// Класс игрока, реализующий сразу два интерфейса
public class Player : IEntity, IMovable
{
    public int id { get; set ; }
    public float posX { get; set; }
    public float posY { get; set; }
    public float speed { get; set; }
    public string Name { get; set; }
    
    // Конструктор
    public Player(string name, float posX, float posY)
    {
        Random random = new();
        
        this.id = random.Next();
        this.Name = name;
        this.posX = posX;
        this.posY = posY;
    }
    public void Move()
    {
        // Движение
    }
}


// Класс статичного объекта, реализующий один интерфейс
public class StaticObject: IEntity
{
    public int id { get; set; }
    public float posX { get; set; }
    public float posY { get; set; }
    public StaticObject(float posX, float posY)
    {
        Random random = new();

        this.id = random.Next();
        this.posX = posX;
        this.posY = posY;
    }
}
