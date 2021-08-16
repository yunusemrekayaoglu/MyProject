ProjectManager personManager = new ProjectManager();
personManager.Add(new InternManager());


interface IPersonManager
{
    void Add();
    void Update();
}
class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("müşteri güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("personel eklendi");
    }

    public void Update()
    {
        Console.WriteLine("personel güncellendi");
    }
}
class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("stajyer eklendi");
    }

    public void Update()
    {
        Console.WriteLine("stajyer güncellendi");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}