package Java.Java_5.program1;

import java.util.*;

public class program1{
    
    public static void main(String[] args) {
        Map<String, ArrayList<Integer>> bookPhone = new HashMap<>();
        addNumber("Dorofeev", 1, bookPhone);
        addNumber("Starikov", 2, bookPhone);
        addNumber("Djafarov", 3, bookPhone);
        addNumber("Dorofeev", 4, bookPhone);
        addNumber("Starikov", 5, bookPhone);
        addNumber("Dorofeev", 6, bookPhone);
        printBook(bookPhone);
       }

       // Метод, который добавляет номера в книгу
    public static void addNumber(String key, int value, Map<String, ArrayList<Integer>> map){
        if (map.containsKey(key)) {
            map.get(key).add(value);
        } 
        else {
            ArrayList<Integer> list = new ArrayList<>();
            list.add(value);
            map.put(key, list);
        }

    }
    // Метод, который печатает список контактов
    public static void printBook(Map<String, ArrayList<Integer>> map){
        for (var item : map.entrySet()) {
            String phones = "";
            for(int el: item.getValue()){
                phones = phones + el + ", ";
            }
            System.out.printf("%s: %s \n", item.getKey(), phones);
        }
    }
}