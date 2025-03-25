package pl.mojafirma.file.musicfile;

public class MP3MusicFile extends AbstractMusicFile{
    private int quality;

    public int getQuality() {
        return quality;
    }

    public MP3MusicFile(String name, int size, String bandName, String title, int quality) {
        super(name, size, bandName, title);
        this.quality = quality;
    }

    public void play(){
        System.out.println("Playing MP3 file");
    }
}
