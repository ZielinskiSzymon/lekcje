package pl.mojafirma;

import pl.mojafirma.drive.HDDDrive;
import pl.mojafirma.drive.SSDDrive;
import pl.mojafirma.file.File;
import pl.mojafirma.file.imagefile.GIFImageFile;
import pl.mojafirma.file.imagefile.JPGImageFile;
import pl.mojafirma.usbdevice.MemoryStick;
import pl.mojafirma.usbdevice.Mouse;

public class Main {
    public static void main(String[] args) {

//        Monitor monitor = new Monitor();
//        System.out.println(monitor.getResolution());
//
//        monitor.setLowerResolution();
//        System.out.println(monitor.getResolution());


//        Monitor monitor = new Monitor();
//        HDDDrive drive = new HDDDrive();
//        Computer computer = new Computer(monitor, drive);

//        drive.addFile(new File("plik1.txt"));
//        drive.listFiles();

//        MemoryStick memoryStick = new MemoryStick("Pendrive");
//        Mouse mouse = new Mouse("Mysz");
//
//        computer.addUSBDevice(memoryStick);
//        computer.addUSBDevice(mouse);
//
//        memoryStick.ejected();
//
//        computer.removeUSBDevice(memoryStick);
//        computer.removeUSBDevice(mouse);

        SSDDrive ssdDrive = new SSDDrive();
        GIFImageFile gif1 = new GIFImageFile("Nazwa1.gif",100);
        JPGImageFile jpg1 = new JPGImageFile("Nazwa2.png", 200, 80);

        ssdDrive.addFile(gif1);
        ssdDrive.addFile(jpg1);
        ssdDrive.listFiles();
        File file = ssdDrive.findFile("nazwa1.gif");
        System.out.println(file.getSize());

    }
}