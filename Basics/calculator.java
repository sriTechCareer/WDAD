import java.util.Scanner;

public class calculator {
    public static void main(String[] args) {
        int choice;
        Scanner sc = new Scanner(System.in);
        int num1, num2;
        do {
            System.out.println("Enter Number 1");
            num1 = sc.nextInt();
            System.out.println("Enter Number 2");
            num2 = sc.nextInt();
            System.out.println("\n");
            System.out.println("1. Addition");
            System.out.println("2. Subtraction");
            System.out.println("3. Multiplication");
            System.out.println("4. Division");
            System.out.println("5. Modular Division");
            System.out.println("6. Exit");
            System.out.println("Enter you choice: ");
            choice = sc.nextInt();
            switch (choice) {
                case 1:
                    System.out.println("Addition: "+(num1+num2));
                    break;
                case 2:
                    System.out.println("Subtraction: "+(num1-num2));
                    break;
                case 3:
                    System.out.println("Multiplication: "+(num1*num2));
                    break;
                case 4:
                    System.out.println("Division: "+(num1/num2));
                    break;
                case 5:
                    System.out.println("Module Division: "+(num1%num2));
                    break;
                case 6:
                    System.out.println("Exiting...");
                    break;
                default:
                    System.out.println("Wrong Choice");
                    break;
            }
        } while (choice!=6);
        sc.close();
    }
    
}
