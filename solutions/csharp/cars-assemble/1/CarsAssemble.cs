static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed >= 1 && speed <= 4)
        {
            return 1;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed == 10)
        {
            return 0.77;
        }

        else
        {
            return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        if (speed >= 1 && speed <= 4)
            {
                return 221 * 1 * speed;
            }
            else if (speed >= 5 && speed <= 8)
            {
                return 221 * 0.9 * speed;
            }
            else if (speed == 9)
            {
                return 221 * 0.8 * speed;
            }
            else if (speed == 10)
            {
                return 221 * 0.77 * speed;
            }
            else
            {
                return 0;
            }
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double productionRatePerHour = ProductionRatePerHour(speed);
        return Convert.ToInt32(Math.Floor(productionRatePerHour / 60));
    }
}
