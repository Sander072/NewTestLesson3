import java.util.ArrayList;

public class Peasant extends Hero {

    protected boolean readiness;

    public Peasant(String name, ArrayList<Hero> team, int x, int y) {
        super(name, 10, 0.5f, 1, 1, 0, team, x, y);
        this.readiness = true;
    }

    @Override
    public String toString() {
        return "Пизант";
    }


    @Override
    public String getInfo() {
        return super.getInfo();
    }

    @Override
    public void step(ArrayList<Hero> enemy) {
        if (readiness) {
            //System.out.println(this + " " + this.name + " ничего не делает");
        }else{
            readiness = true;
            //System.out.println(this + " " + this.name + " находит припасы");
        }
    }

}