import java.util.ArrayList;

public class SpearMan extends Hero {
    public SpearMan(String name, ArrayList<Hero> team,  int x, int y){
        super(name, 30, 0.6f, 3, 3, 30, team, x, y);
    }

    @Override
    public String toString() {
        return "Копейщик";
    }


    @Override
    public String getInfo() { 
        return super.getInfo();
    }
}