package ООП;

public class SpearMan extends Hero {
    public SpearMan( String name, int strength, int health ) {
        super( name, strength, health );
    }

    
    public SpearMan() {
        super( "SpearMan", 7, 30 );
    }


    public void brace() {
        System.out.println(this.name + " is bracing with their spear.");
    }


    public void thrust() {
        System.out.println(this.name + " is thrusting their spear.");
    }
}

