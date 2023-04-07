package Java.Java_3.program2;
import java.util.ArrayList;
import java.util.List;
import java.util.Collections;
import java.util.Random;

public class program2 {
    public static void main(String[] args) {
        
        Random rand = new Random();
        List<Integer> ArrayList = new ArrayList<>(10);
        for (int i = 0; i < 10; i++) {
            ArrayList.add(rand.nextInt(100));
        }
        System.out.println(ArrayList);

        
        int x = Collections.max(ArrayList);
        int y = Collections.min(ArrayList);

        int sum = 0;
        for(int i = 0; i < ArrayList.size(); i++)
            sum += ArrayList.get(i);
        float z = (float) sum/(float) ArrayList.size();

        System.out.println("Максимальное значение:" + x);
        System.out.println("Минимальное значение:" + y);
        System.out.println("Среднее значение:" + z);
    }
}
