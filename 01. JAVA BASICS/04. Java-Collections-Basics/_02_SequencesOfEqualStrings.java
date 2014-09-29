package Lection4;

import java.util.Scanner;

public class _02_SequencesOfEqualStrings {

	public static void main(String[] args) {
		System.out.println("Please enter an array of strings separated by space on one line:");
		Scanner scan = new Scanner(System.in);
		String row = scan.nextLine();
		String[] stringArray = row.split("\\s+");
		
		for( int i = 0; i < stringArray.length - 1; i++) {
			
			if(stringArray[i].equals(stringArray[i+1])) {
				System.out.print(stringArray[i] + " ");
			}
			else {
				System.out.println(stringArray[i]);
			}
		}
		System.out.print(stringArray[stringArray.length-1]);
		scan.close();
	}

}
