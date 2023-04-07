package Java.Java_3.program1;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class program1 {
    public static void main(String[] args) {
        
        Random rand = new Random();
        List<Integer> ArrayList = new ArrayList<>(10);
        for (int i = 0; i < 10; i++) {
            ArrayList.add(rand.nextInt(100));
        }
        System.out.println(ArrayList);

        for (int j = 0; j < ArrayList.size(); j++) {
            if (ArrayList.get(j)%2 == 0) {
                ArrayList.remove(j);
                j--;
            }
        }
        System.out.println(ArrayList);
    }
}
