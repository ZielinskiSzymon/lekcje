package pl.mojafirma.drive;

import pl.mojafirma.file.File;

public interface Drive {
    void addFile(File file); //nie mowimy jka ma byc dodany tylko ze ma byc
    void listFiles();
    File findFile(String name);
}
