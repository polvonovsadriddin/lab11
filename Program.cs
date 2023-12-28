///// Лабараторная работа: 11     вариант: 1
try
{

    Console.Write(" Введите наименование процессора:");
    string? name=Console.ReadLine();
    Console.Write(" Введите тактовая частота процессора:(МГц)");
    int chastota = int.Parse(Console.ReadLine()!);
    Console.Write("Введите обьем оперативной памяти:(Мб)");
    double size = double.Parse(Console.ReadLine()!);
    Console.Write(" Введите объем винчестера:(ГБ)");
    double p= double.Parse(Console.ReadLine()!);

    Parent parent = new Parent(name,chastota,size);
    Console.WriteLine($"Наименование процессора:{parent.name}; ' качество' класса 1 уровня(Q)={parent.Q(parent.chastota,parent.size)}");

    Child child = new Child(name, chastota, size,p);

    Console.WriteLine($"Наименование процессора:{child.name};'качество' класса  2 уровня (Qp)= {child.Q( child.chastota, child.size)}");





}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Parent
{
    public string? name;
    public int chastota;
    public double size;

  

    public string? Name { get { return name;  }set { if (value != null) name = value; } }
    public int  Chastota { get { return chastota; }set { if (value >= 0) chastota = value; } }
    public double Size { get { return size; } set {if (value>=0) size = value; } }
    public virtual double Q(int  Chastota, double Size)
    { return (Size +Chastota*0.1); }

    public Parent(string? name, int chastota, double size)
    {
        this.Name = name;
        this.Chastota = chastota;
        this.Size = size;
    }
}

class Child : Parent
{
    private string? name;
   private int? chastota;
    private double size;
    private double p;

    public string? Name { get { return name; } set { if (value != null) name = value; } }
    public int? Chastota { get { return chastota; } set { if (value >= 0) chastota = value; } }
    public double Size { get { return size; } set { if (value >= 0) size = value; } }
    public double P { get { return p; } set { if (value >= 0) p = value; } }

  
    public override double Q(int Chastota, double Size)
    {
        return (base.Q(Chastota, Size)*P );
    }
    public Child(string? name, int chastota, double size, double p) : base(name, chastota, size)
    {
        this.Name = base.Name;
        this.Chastota = base.Chastota;
        this.Size = base.Size;
        this.P = p;
    }
}