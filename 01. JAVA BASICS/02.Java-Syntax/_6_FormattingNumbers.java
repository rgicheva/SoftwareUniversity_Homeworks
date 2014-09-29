package Lection2;

import java.util.Scanner;

public class _6_FormattingNumbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int a;
		while(true) {
			System.out.print("Enter an integer number between 0 and 500:");
			a = scan.nextInt();
			if(a >= 0 && a <= 500) {
				break;
			}
		}
		float b = scan.nextFloat();
		float c = scan.nextFloat();
		
		String aHex = Integer.toHexString(a).toUpperCase();
		String aBinary = String.format("%10s", Integer.toBinaryString(a)).replace(' ','0');
		
		if (c%1 == 0) {
			System.out.printf("|%-10s|%s|%10.2f|%-10.0f|", aHex, aBinary, b,c);
		}else {
			System.out.printf("|%-10s|%s|%10.2f|%-10.3f|", aHex, aBinary, b, c);
		}
		scan.close();

	}

}
