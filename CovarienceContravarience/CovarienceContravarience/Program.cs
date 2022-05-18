namespace CovarienceContravarience;

class   AutoMobiles
{

}

class RoadVechiles : AutoMobiles
{

}

class Truck : RoadVechiles
{
    

}

class MonsterTruck : Truck
{

}

class Checker
{
    public static Func<AutoMobiles, AutoMobiles> ExampleCovarience;
    public static Action<MonsterTruck> ExampleContravarience;

    public Truck GetTruck(AutoMobiles dummy)
    {
        Console.WriteLine("returns obj of Truck");
        return new Truck();

    }

    public MonsterTruck GetMonsterTruck(AutoMobiles dummy)
    {
        Console.WriteLine("returns obj of MonsterTruck");
        return new MonsterTruck();
    }

    public RoadVechiles GetRoadVechiles(AutoMobiles dummy)
    {
        Console.WriteLine("returns obj of Roadvechiles");
        return new RoadVechiles();
    }


    public void DriveAutoMobile(AutoMobiles dummy)
    {
    }

    public void DriveRoadVechiles(RoadVechiles dummy)
    {
    }

    public void DriveMonsterTruck(MonsterTruck dummy)
    {
    }

    public static void Main(string[] args)
    {
        AutoMobiles
            vechiles1 =
                new RoadVechiles(); //by Normal inheritnace concept we can assign normal child class object to parent class object
        ExampleCovarience = new Checker().GetTruck;
        ExampleCovarience += new Checker().GetMonsterTruck;
        ExampleCovarience += new Checker().GetRoadVechiles;
        ExampleCovarience(new MonsterTruck());
        // even though ExampleCovarience is a deligate
        // which returns Automobile type objects but it accepts methods which return its child class objects

        ExampleContravarience = new Checker().DriveAutoMobile;
        ExampleContravarience += new Checker().DriveRoadVechiles;
        ExampleContravarience += new Checker().DriveMonsterTruck;
        // ExampleContravarience(new MonsterTruck());  no error
        //ExampleContravarience(new Truck());  error
        // here even though ExampleContravarience  has methods which can take a truck obj but it will not allow because it will affect the Innheritance hierarchy 
        // Contravarience : enables to use less derived than originally specified  (but in that deligate we can only pass the objects the same or derived type of the object which we declared during ExampleContravarience

        Console.ReadKey();
    }
}

interface  ICovariant< out T>
    {
        
    }
interface IContravariance<in T>
{

}


class GenericContravarienceCovarience
{
    public void Validaion()
    {
        
        ICovariant<AutoMobiles> varibale1 = (ICovariant<Truck>) new AutoMobiles();  // if we not specify out in the declaration we will get an error 
        //we specify the that the generic specified here supports covarience by specifying out  keyword 

        IContravariance<Truck> variable2= (IContravariance<AutoMobiles>) new AutoMobiles() ; //if we not specify in keyword in the declaration of the interface we will get error  
        //we can specify that the generic specified here supports Contravarience by specifying In keyword 



        IEnumerable<AutoMobiles> variables = new List<Truck>();
         
    }
}







