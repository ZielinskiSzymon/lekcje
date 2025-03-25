package pl.mojafirma.usbdevice;

public class Mouse implements USBDevice{
    public Mouse(String name) {
        this.name = name;
    }

    private String name;
    @Override
    public boolean connect() {
        System.out.println("Mouse connected");
        return true;
    }

    @Override
    public boolean disconected() {
        System.out.println("Mouse disconnected");
        return true;
    }

    @Override
    public String getName() {
        return name;
    }
}
