package Lection4;

import java.util.Arrays;
import java.util.Scanner;

public class _01_SortArrayOfNUmbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.print("Enter a number n:");
		int n = Integer.parseInt(scan.nextLine());
		int[] nArray = new int[n];
		for(int i = 0; i < n; i++) {
			System.out.println("Enter #" + i);		
			nArray[i] = Integer.parseInt(scan.nextLine());		
		}
		Arrays.sort(nArray);	
		for(int i = 0; i < nArray.length; i++) {
			System.out.println(nArray[i]);
		}
		scan.close();
	}
	

}
