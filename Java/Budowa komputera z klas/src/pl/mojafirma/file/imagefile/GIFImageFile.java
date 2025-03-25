package pl.mojafirma.file.imagefile;

public class GIFImageFile extends AbstractImageFile {

    //chcemy wywołac konstruktor z klasy dziedzczonej
    public GIFImageFile(String image, int i) {
        super(image, i);
    }
    public void showAnimation(){
        System.out.println("Showing fun animaton");
    }
}
