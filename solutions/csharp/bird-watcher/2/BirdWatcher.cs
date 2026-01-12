class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birds in birdsPerDay)
        {
            if (birds == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int firstThreeDays = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            firstThreeDays += birdsPerDay[i];
        }
        return firstThreeDays;
    }

    public int BusyDays()
    {
        int count =0;

        for (int i =0; i< birdsPerDay.Length; i++)
        {
            if(birdsPerDay[i] >= 5)
            {
                count ++;
            }
        }
        return count;
    }
}
