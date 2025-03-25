package pl.mojafirma.file.imagefile;

import pl.mojafirma.file.AbstractFile;
import pl.mojafirma.file.File;
import pl.mojafirma.file.FileType;

public abstract class AbstractImageFile extends AbstractFile {

    public AbstractImageFile(String name, int size) {
        super(name, size);
    }

    @Override
    public FileType getType() {
        return FileType.IMAGE;
    }
}