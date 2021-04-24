using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

[DataContract]
public class RoadCenter : ITrackingCenter
{
    [DataMember]
    private List<Camera> cameras = new List<Camera>();

    public void AddCamera(int id, int maxSpeed)
    {
        cameras.Add(new Camera(id, maxSpeed));
    }

    public void CheckCarSpeed(int forCameraId, int carNumber, int carSpeed)
    {
        cameras.Find(cam => cam.Id == forCameraId)?.AddPenalty(
            carNumber, carSpeed);
    }

    public void GetData(string inFilePath)
    {
        var jsonSerializer =
            new DataContractJsonSerializer(typeof(RoadCenter));
        using (FileStream fs = File.OpenWrite(inFilePath))
        {
            jsonSerializer.WriteObject(fs, this);
        }
    }
}