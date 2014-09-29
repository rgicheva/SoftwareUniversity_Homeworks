package Lection2;

import java.util.Scanner;

public class _5_DecimalToHexadecimal {

	public static void main(String[] args) {
		System.out.println("Please enter a number:");
        Scanner sc = new Scanner(System.in);
		String number = sc.nextLine();
		int i = Integer.parseInt(number);
		String hex = Integer.toHexString(i).toUpperCase();
		System.out.println("The hex number is " + hex);

		sc.close();
	}

}
