package Lection2;

import java.util.Scanner;

public class _7_CountOfBitsOne {

	public static void main(String[] args) {
		System.out.print("Please enter an integer number:");
		Scanner scan = new Scanner(System.in); 
		int numberN = scan.nextInt();
		int counter = 0;
		
		for(int i = 0; i < 32; i++) {
			if((numberN&1)==1) {
				counter++;
			}
			numberN = numberN>>1;
		}
		System.out.println(counter);
	}

}
