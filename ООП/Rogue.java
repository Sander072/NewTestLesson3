import java.util.ArrayList;


public class Rogue extends Hero {

    public Rogue(String name, ArrayList<Hero> team, int x, int y) {
        super(name, 20, 0.8f, 3, 2, 10, team, x, y);
    }

    @Override
    public String toString() {
        return "Разбойник";
    }

    void dodge() {

    }

    void stealth() {

    }


    @Override
    public String getInfo() {
        return super.getInfo();
    }
}