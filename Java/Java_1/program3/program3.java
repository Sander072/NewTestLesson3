package Java.Java_1.program3;

import java.util.Scanner;

public class program3 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        for (int i = 1; i < 1001; i++) {
            int m = 0;
            for (int j = 2; j < i; j++) {
                if (i % j == 0){
                    m = m + 1; 
                }
            }
            if (m == 0) {
                System.out.println(i); 
            }
        }
        scan.close();
    }
}
