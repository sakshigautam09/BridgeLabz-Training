public class SmartHomeController
{
    public void OperateDevice(IControllable device)
    {
        device.TurnOn();
        device.TurnOff();
    }
}
