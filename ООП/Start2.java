import java.util.ArrayList;
import java.util.List;
import java.util.Random;


public class Start2 {
    public static void main( String[] args ) {
        List<Hero> lt_1 = generateHeroes( 10 );
        List<Hero> lt_2 = generateHeroes( 10 );
        System.out.println( "\nСписок 1:" );
        lt_1.forEach( u -> System.out.println( u.getInfo() ) );

        System.out.println( "\nСписок 2:" );
        lt_2.forEach( u -> System.out.println( u.getInfo() ) );
        System.out.println();
    }


    public static List<Hero> generateHeroes( int count ) {
        List<Hero> list = new ArrayList<>();
        for ( int i = 0; i < count; i++ ) {
            switch( new Random().nextInt( 7 ) ) {
                case 0:
                    list.add( new Peasant( getName(), 3, 100 ) );
                    break;
                case 1:
                    list.add( new Rogue( getName(), 5, 150 ) );
                    break;
                case 2:
                    list.add( new Sniper( getName(), 6, 120 ) );
                    break;
                case 3:
                    list.add( new Warlock( getName(), 9, 80 ) );
                    break;
                case 4:
                    list.add( new SpearMan( getName(), 8, 200 ) );
                    break;
                case 5:
                    list.add( new CrossBowMan( getName(), 7, 110 ) );
                    break;
                default:
                    list.add( new Monk( getName(), 4, 90 ) );
            }
        }
        return list;
    }


    private static String getName(){
        return Names.values()[ new Random().nextInt( Names.values().length ) ].toString();
    }
}