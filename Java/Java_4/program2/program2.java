package Java.Java_4.program2;

import java.util.*;

public class program2 {
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        Random rand = new Random();
        for (int i = 0; i < 10; i++) {
            enqueue(list, rand.nextInt(100)); 
        }
        System.out.println(list);

        System.out.println(dequeue(list)); 
        System.out.println(list);

        System.out.println(first(list)); 
        System.out.println(list); 
    }

    public static void enqueue(LinkedList<Integer> list, int num) {
        list.addLast(num);
    }

    public static int dequeue(LinkedList<Integer> list) { 
        int num = list.get(0);
        list.remove(0);
        return num;
    }

    public static int first(LinkedList<Integer> list) { 
        int num = list.get(0);
        return num;
    }

}
