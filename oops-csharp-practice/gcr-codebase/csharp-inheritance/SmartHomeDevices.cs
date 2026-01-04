using System;
class Device
{
    public int DeviceId;
    public string Status;
    public Device(int id, string status)
    {
        DeviceId = id;
        Status = status;
    }
    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}

class Thermostat : Device
{
    public string TemperatureSetting;

    public Thermostat(int id, int status, string tempSetting)
            : base(id, status)
    {
        TemperatureSetting = tempSetting;
    }
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + TemperatureSetting);
    }
}
class SmartHomeDevices
{
    static void Main()
    {
        Thermostat device1 = new Thermostat(101, "Online", "22°C");
        device1.DisplayStatus();
    }
}