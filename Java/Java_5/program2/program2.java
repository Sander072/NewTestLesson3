package Java.Java_5.program2;

import java.util.*;

public class program2 {
    public static void main(String[] args) {
        String[] employees = new String[] {"Иван Иванов", "Иван Петров", "Сергей Козлов", "Евгений Петров", "Сергей Васильев", "Иван Смирнов", "Андрей Петров"};
        ArrayList<String> employeesName = getName(employees);
        Map<String, Integer> mapName =  getMap(employeesName);
        System.out.println("Повторяющиеся имена: ");
        nameRepeat(mapName);
        System.out.println("Имена, отсортированные по убыванию популярности: ");
        sortName(mapName);
    }

    public static ArrayList<String> getName(String [] list){
        ArrayList<String> listName = new ArrayList<>();
        for (String el : list) {
            String [] elList = el.split(" ");
            listName.add(elList[0]);
        }
        return listName;
    }

    public static Map<String, Integer> getMap(ArrayList<String> name) {
        Map<String, Integer> mapName = new HashMap<>();
        for (int i = 0; i < name.size(); i++) {
            int count = 1;
            for (int j = i + 1; j < name.size(); j++){
                if (name.get(i).equals(name.get(j))) count += 1;
            }
            if (mapName.containsKey(name.get(i)) == false) mapName.put(name.get(i), count);
        }
        return mapName;
    }

    public static void nameRepeat(Map<String, Integer> map){
        for(var item: map.entrySet()){
            if (item.getValue() > 1) System.out.printf("%s: %d \n", item.getKey(), item.getValue());
        }
    }

    public static void sortName(Map<String, Integer> map){
        ArrayList<Integer> listCount = new ArrayList<>();
        for(var item: map.entrySet()) {
            if (listCount.contains(item.getValue()) == false) listCount.add(item.getValue());
        }
        listCount.sort(null);
        for (int i = listCount.size()-1; i > -1; i--){
            for (var item: map.entrySet()){
                if (listCount.get(i) == item.getValue()) System.out.printf("%s : %d \n", item.getKey(), item.getValue());
            }
        }
    }
    
}
