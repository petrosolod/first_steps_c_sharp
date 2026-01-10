class RemoteControlCar
{
    public int meters = 0;
    public int battaryCharge = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {meters} meters";
    }

    public string BatteryDisplay()
    {
        if(battaryCharge == 0)
        {
            return "Battery empty";
        }
        
        return $"Battery at {battaryCharge}%";
    }

    public void Drive()
    {
        if(battaryCharge > 0)
        {
            meters += 20;
            DistanceDisplay();
            battaryCharge -= 1;
            BatteryDisplay();
        }

        else if (battaryCharge < 0)
        {
            Console.WriteLine($"Battery");
            Console.WriteLine($"Driven {meters} mile"); 
        }
    }
}
