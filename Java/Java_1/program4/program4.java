package Java.Java_1.program4;

import java.util.Scanner;

public class program4 {
    public static void main(String[] args) {
        Scanner scan1 = new Scanner(System.in);
        System.out.println("Введите первое число:");
        int x = scan1.nextInt();
        System.out.println("Введите второе число:");
        int y = scan1.nextInt();
  
        Scanner scan2 = new Scanner(System.in);
        System.out.println("Введите математическое выражение:");
        String otv = scan2.nextLine();
        int m = 0;
        
        if (otv.equals("+")){
            m = x + y;
        }
        if (otv.equals("-")){
            m = x - y;
        }
        if (otv.equals("*")){
            m = x * y;
        }
        if (otv.equals("/")){
            m = x / y;
        }
        System.out.println(m);
        scan1.close();
        scan2.close();
    }
}
