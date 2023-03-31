package Java.Java_1.program1;

import java.util.Scanner;

public class program1 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("Введите n:");
        int n = scan.nextInt();
        int m = 0;
        for (int i = 1; i < n + 1; i++) {
            m = m + i;
        }
        System.out.println(m);
        scan.close();
    }
}
