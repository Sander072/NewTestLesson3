package Java.Java_2.program2;
import java.io.IOException;
import java.io.FileWriter;
import java.io.PrintWriter;
import java.time.LocalDateTime;

public class program2 {
    public static void main(String arg[]) {
        PrintWriter log;
        FileWriter logFile;
        try {
            logFile = new FileWriter("exceptions.log", true);
            //Файл расположен в папке GitGroup
            log = new PrintWriter((java.io.Writer)logFile);
        } catch (IOException ex) {
            ex.printStackTrace();
            return;
        }
        try {
            throw new Exception();
        } catch (Exception ex) {
            log.printf("\n%s: %s\n", LocalDateTime.now(), ex.getMessage());
            ex.printStackTrace(log);
            log.flush();
        }
    }
}
