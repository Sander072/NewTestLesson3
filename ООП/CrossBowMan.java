import java.util.ArrayList;

public class CrossBowMan extends Shooter {
    public CrossBowMan(String name, ArrayList<Hero> team, int x, int y) {
        super(name, 20, 0.5f, 4, 2, 2, 50, 0.5f, 10, team, x, y);
    }

    @Override
    public String toString() {
        return "Арбалетчик";
    }


    @Override
    public String getInfo() {
        return super.getInfo();
    }

}