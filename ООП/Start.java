package ООП;

public class Start {
    public static void main(String[] args) {

        // Крестьянин
        Peasant peasant = new Peasant("John", 5, 100);
        // Разбойник
        Rogue rogue = new Rogue("Alice", 5, 150);
        // Снайпер
        Sniper sniper = new Sniper("Bob", 5, 120);
        // Колдун
        Warlock warlock = new Warlock("Eve", 5, 80);
        // Копейщик
        SpearMan spearman = new SpearMan("David", 5, 200);
        // Арбалетчик
        CrossBowMan crossbowman = new CrossBowMan("Olivia", 5, 110);
        // Монах
        Monk monk = new Monk("Grace", 5, 90);

        // можем использовать каждый персонаж и вызывать их методы
        System.out.println(  );
        peasant.attack(rogue);
        peasant.harvest();
        rogue.attack(spearman);
        rogue.die();
        sniper.rest(50);
        sniper.aim();
        warlock.rest(30);
        warlock.curse();
        crossbowman.attack(monk);
        crossbowman.reload();
        spearman.takeDamage(50);
        spearman.brace();
        monk.rest(20);
        monk.heal();

        System.out.println( "\n" + peasant );
        System.out.println( rogue );
        System.out.println( sniper );
        System.out.println( warlock );
        System.out.println( crossbowman );
        System.out.println( spearman );
        System.out.println( monk + "\n" );
    }
}
