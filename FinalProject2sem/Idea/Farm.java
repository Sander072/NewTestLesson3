package FinalProject2sem.Idea;

import java.util.ArrayList;
import java.util.List;

import FinalProject2sem.Idea.Beasts.Beast;
import FinalProject2sem.Idea.Pets.Pet;

public class Farm<T> {
    private static List<Animal> animals;

    public Farm() {
        animals = new ArrayList();
    }

    public boolean adopt(Animal animal) {
        return animals.add(animal);
    }

    public Farm<Animal> release(Farm<Animal> animalFarm) {
        if (animals.contains(animalFarm)) {
            animals.remove(animalFarm);
            return animalFarm;
        }
        return null;
    }

    public static <A> Farm<A> create() {
        return new Farm<A>();
    }

    public static <A> boolean adopt(Farm<A> farm, Animal animal) {
        return farm.adopt(animal);
    }

    public void printOnlyThisClass(int animalClass) {
        switch (animalClass) {
            case 1:
                printCollection(Pet.class);
                break;
            case 2:
                printCollection(Beast.class);
                break;
        }
    }

    public void printCollection(Class<?> choiseClass){
        for (Animal animal :
                animals) {
            if (choiseClass.isInstance(animal)) {
                System.out.println(animal.toString());
            }
        }
    }

    public static void printAnimals() {
        for (Animal animal :
                animals) {
            System.out.println(animal.toString());
        }
    }
}