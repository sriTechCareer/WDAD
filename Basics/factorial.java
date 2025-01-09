import java.util.Scanner;

public class factorial {
    public static void main(String[] args) {
        System.out.print("Enter a number: ");
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        int ans=1;
        while (num>0) {
            ans=ans*num;
            num--;
        }
        System.out.println("Factorial is: "+ans);
        sc.close();
    }
}
