//Program to demonstrate class, objects and accessmodiferes using animals, birds etc

class Animal{
    private String name;
    private int age;
    private String color;
    public Animal(String name, int age, String color){
        this.name = name;
        this.age = age;
        this.color = color;
    }
    public String getName(){
        return name;
    }
    public int getAge(){
        return age;
    }
    public String getColor(){
        return color;
    }
}
public class class_objects_am {
    
    public static void main(String[] args) {
        //Creating objects of class Animal
        Animal dog = new Animal("Bella", 3, "Brown");
        Animal cat = new Animal("Mickey", 2, "Black");
        Animal bird = new Animal("Polly", 1, "White");
    }
}
