package FinalProject2sem.Idea.Beasts;

public class Camel extends Beast{

    public Camel(int id, String name, String birthdate, int loadCapacity) {
        super(id, name, birthdate, loadCapacity);
    }

    public static void Comands(){
        System.out.println("Выполняемые команды животного");
    }
}
