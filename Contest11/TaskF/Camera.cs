using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class Camera
{
    private const int finePerKmh = 100;
    
    [DataMember]
    private int id;

    private int maxSpeed;

    [DataMember]
    private List<Penalty> penalties = new List<Penalty>();

    public Camera(int id, int maxSpeed)
    {
        this.id = id;
        this.maxSpeed = maxSpeed;
    }

    public int Id => id;

    public int MaxSpeed => maxSpeed;

    public void AddPenalty(int carNumber, int speed)
    {
        if (speed > maxSpeed)
        {
            penalties.Add(new Penalty(carNumber,
                (speed - maxSpeed) * finePerKmh));
        }
    }
}