package pl.mojafirma;

public class Monitor {
    private int height = 1940;
    private int width = 3860;

    public void setLowerResolution() {
        height = 1080;
        width = 1920;
    }

    public void setHigherResolution() {
        height = 2160;
        width = 3840;
    }

    public String getResolution() {
        return width + "x" + height;
    }
}
