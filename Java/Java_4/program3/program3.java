package Java.Java_4.program3;

import java.util.*;

public class program3 {
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        Random rand = new Random();
        for (int i = 0; i < 10; i++) {
            list.add(rand.nextInt(100));
        }
        System.out.println(list);
        Iterator iter = list.iterator();
        int n = (int) iter.next();
        while (iter.hasNext()) {
            n = n + (int) iter.next();
        }
        System.out.println(n);
        System.out.println(list);
    }
}
