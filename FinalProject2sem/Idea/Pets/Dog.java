package FinalProject2sem.Idea.Pets;

public class Dog extends Pet{

    static boolean guard;
    boolean streetBooth;

    public Dog(int id, String name, String birthdate, boolean thoroughbred) {
        super(id, name, birthdate, thoroughbred);
        
    }
    
    public static void Comands(){
        System.out.println("Выполняемые команды животного");
    }
}