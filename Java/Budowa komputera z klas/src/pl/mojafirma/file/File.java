package pl.mojafirma.file;

public interface File {
    String getName();
    int getSize();
    FileType getType(); //enuma, specjalny typ klasy w którym możemy przechowowac stałe
}
