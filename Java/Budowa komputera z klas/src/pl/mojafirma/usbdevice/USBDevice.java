package pl.mojafirma.usbdevice;

public interface USBDevice {
    public boolean connect();// podlaczone urzadzenie i zwrocenie czy ostało podlaczone czy nie
    public boolean disconected();
    public String getName();

}
