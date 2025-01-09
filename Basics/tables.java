import java.util.Scanner;

public class tables {
    public static void main(String[] args) {
        System.out.print("Enter a number: ");
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        int i=0;
        do {
            System.out.println(num+"x"+(i+1)+"="+(num*(i+1)));
            i++;
        } while (i<10);
        sc.close();
    }
}
