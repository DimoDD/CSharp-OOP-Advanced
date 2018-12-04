public class Ferrari : IDriveable
{
    public Ferrari(string driver)
    {
        this.Model = "488-Spider";
        this.Driver = driver;
    }

    public string Model { get; private set; }
    public string Driver { get; private set; }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        return $"{Model}/{UseBrakes()}/{PushGas()}/{Driver}";
    }
}

