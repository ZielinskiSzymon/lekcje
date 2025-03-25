package pl.mojafirma;

import pl.mojafirma.drive.Drive;
import pl.mojafirma.usbdevice.USBDevice;

import java.util.ArrayList;
import  java.util.List;

public class Computer {
    private Monitor monitor;
    private Drive drive;
    private Headphones headphone;

    List<USBDevice> usbDevices = new ArrayList<>();

    public Computer(Monitor monitor, Drive drive) {
        this.monitor = monitor;
        this.drive = drive;
    }

    public Monitor getMonitor() {
        return monitor;
    }

    public void setMonitor(Monitor monitor) {
        this.monitor = monitor;
    }

    public Drive getDrive() {
        return drive;
    }

    public void setDrive(Drive drive) {
        this.drive = drive;
    }

    public Headphones getHeadphone() {
        return headphone;
    }

    public void setHeadphone(Headphones headphone) {
        this.headphone = headphone;
    }

    public List<USBDevice> getUsbDevice() {
        return usbDevices;
    }

    public void addUSBDevice(USBDevice usbDevice){
        boolean isConnected = usbDevice.connect();
        if (isConnected)
            usbDevices.add(usbDevice);
    }
    public void removeUSBDevice(USBDevice usbDevice){
        boolean isDisconnected = usbDevice.disconected();
        if (isDisconnected)
            usbDevices.remove(usbDevice);
        else{
            System.out.println("Device is not connected");
            usbDevices.remove(usbDevice);
        }
    }

}
