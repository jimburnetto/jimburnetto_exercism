using System;

public class SpaceAge
{
    public Double Seconds;
    public Double EarthYears;
    public SpaceAge(int seconds)
    {
        Seconds = seconds;
        EarthYears = Seconds / 31557600;
    }

    public double OnEarth()
    {
        return EarthYears;
    }

    public double OnMercury()
    {
        return EarthYears  / 0.2408467;
    }

    public double OnVenus()
    {
        return EarthYears / 0.61519726;
    }

    public double OnMars()
    {
        return EarthYears / 1.8808158;
    }

    public double OnJupiter()
    {
        return EarthYears / 11.862615;
    }

    public double OnSaturn()
    {
        return EarthYears / 29.447498;
    }

    public double OnUranus()
    {
        return EarthYears / 84.016846;
    }

    public double OnNeptune()
    {
        return EarthYears / 164.79132;
    }
}