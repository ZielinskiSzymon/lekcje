package pl.mojafirma.file.musicfile;

import pl.mojafirma.file.AbstractFile;
import pl.mojafirma.file.FileType;

public abstract class AbstractMusicFile extends AbstractFile {
    String bandName;
    String title;

    public AbstractMusicFile(String name, int size, String bandName, String title) {
        super(name, size);
        this.bandName = bandName;
        this.title = title;
    }

    @Override
    public FileType getType() {
        return FileType.MUSIC;
    }
}
