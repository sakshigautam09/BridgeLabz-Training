class Program
{
    static void Main()
    {
        Appliance livingRoomLight = new Light("Living Room");
        Appliance bedroomFan = new Fan("Bedroom");
        Appliance hallAC = new AC("Hall");

        SmartHomeController controller = new SmartHomeController();

        controller.OperateDevice(livingRoomLight);
        controller.OperateDevice(bedroomFan);
        controller.OperateDevice(hallAC);
    }
}
