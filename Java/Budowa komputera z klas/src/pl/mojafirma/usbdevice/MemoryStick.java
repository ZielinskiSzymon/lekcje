package pl.mojafirma.usbdevice;

public class MemoryStick implements USBDevice{
    private String name;
    private boolean ejected;

    public MemoryStick(String name) {
        this.name = name;
    }

    @Override
    public boolean connect() {
        System.out.println("MemoryStick connected");
        return true;
    }

    @Override
    public boolean disconected() {
        if (!ejected){
            System.out.println("Memorystick is still connected eject it first");
            return false;
        }
        else {
            System.out.println("MemoryStick disconnected");
            return true;
        }
    }
    public void ejected(){
        ejected = true;
        System.out.println("Memorystck ejected");
    }

    @Override
    public String getName() {
        return "";
    }
}
