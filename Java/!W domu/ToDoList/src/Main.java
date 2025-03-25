import javax.swing.*;
import java.io.*;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException {
        String fileName = "toDoList.txt";
        ArrayList<String> tasks = new ArrayList<>();

        // Load tasks from file
        Scanner scanner = new Scanner(new FileReader(fileName));
        while (scanner.hasNextLine()) {
            tasks.add(scanner.nextLine());
        }
        scanner.close();

        // Display tasks in a list
        JList<String> taskList = new JList<>(tasks.toArray(new String[0]));
        JScrollPane scrollPane = new JScrollPane(taskList);
        scrollPane.setPreferredSize(new java.awt.Dimension(250, 200));

        int option = JOptionPane.showOptionDialog(null, scrollPane, "To-Do List",
                JOptionPane.OK_CANCEL_OPTION, JOptionPane.PLAIN_MESSAGE, null,
                new String[]{"Add Task", "Remove Selected Task", "Close"}, "Add Task");

        if (option == 0) { // Add Task
            String newTask = JOptionPane.showInputDialog("Enter a new task:");
            if (newTask != null && !newTask.trim().isEmpty()) {
                tasks.add(newTask);

                // Save updated tasks to file
                saveTasksToFile(fileName, tasks);
            }
        } else if (option == 1) { // Remove Selected Task
            int[] selectedIndices = taskList.getSelectedIndices();
            if (selectedIndices.length > 0) {
                for (int i = selectedIndices.length - 1; i >= 0; i--) {
                    tasks.remove(selectedIndices[i]);
                }

                // Save updated tasks to file
                saveTasksToFile(fileName, tasks);
                JOptionPane.showMessageDialog(null, "Selected tasks removed.");
            } else {
                JOptionPane.showMessageDialog(null, "No task selected for removal.");
            }
        }

        System.exit(0); // Close the application
    }

    // Method to save the tasks back to the file
    private static void saveTasksToFile(String fileName, ArrayList<String> tasks) throws IOException {
        FileWriter fileWriter = new FileWriter(fileName);
        PrintWriter outputFile = new PrintWriter(fileWriter);
        for (String task : tasks) {
            outputFile.println(task);
        }
        outputFile.close();
    }
}
