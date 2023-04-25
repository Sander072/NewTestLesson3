public class CrossBowMan extends Hero {
    public CrossBowMan( String name, int strength, int health ) {
        super( name, strength, health );
    }


    public CrossBowMan() {
        super( "CrossBowMan", 7, 30 );
    }


    public void reload() {
        System.out.println(this.name + " is reloading their crossbow.");
    }


    public void fire() {
        System.out.println(this.name + " is firing their crossbow.");
    }
}
