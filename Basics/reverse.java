import java.util.Scanner;

public class reverse {
    public static void main(String[] args) {
        System.out.print("Enter a string: ");
        Scanner sc = new Scanner(System.in);
        String val = sc.next();
        StringBuilder str = new StringBuilder(val);
        int len = val.length();
        if (val.length()%2==0) {
            for (int i = 0; i < val.length()/2; i++) {
                char temp = val.charAt(i);
                str.setCharAt(i, val.charAt(len-i-1));
                str.setCharAt((len-i-1), temp);
            }
        }else{
            for (int i = 0; i <= val.length()/2-1; i++) {
                char temp = val.charAt(i);
                str.setCharAt(i, val.charAt(len-i-1));
                str.setCharAt((len-i-1), temp);
            }
        }
        System.out.println("Rversed String: "+str);
        sc.close();
    }
}