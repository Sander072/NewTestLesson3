package Java.Java_4.program1;

import java.util.*;

public class program1 {
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        Random rand = new Random();
        for (int i = 0; i < 10; i++) {
            list.add(rand.nextInt(100));
        }
        System.out.println(list);

        for (int i = 0; i < 10; i++) {
            if (i == 9) {
                System.out.print(list.getLast());
            }
            else {
                System.out.print(list.getLast() + ", ");
            }
            list.removeLast();

        }
    }
}
