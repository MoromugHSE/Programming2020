using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json;

[DataContract]
public class Penalty
{
    [DataMember(Name = "car_number")]
    private int carNumber;
    
    [DataMember]
    private int cost;

    public Penalty(int carNumber, int cost)
    {
        this.carNumber = carNumber;
        this.cost = cost;
    }
}