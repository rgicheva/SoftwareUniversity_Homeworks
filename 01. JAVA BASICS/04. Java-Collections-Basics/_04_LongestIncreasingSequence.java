package Lection4;

import java.util.ArrayList;
import java.util.Scanner;

public class _04_LongestIncreasingSequence {

	public static void main(String[] args) {
		System.out.println("Please enter an array of integers separated by space on one line:");
		Scanner scan = new Scanner(System.in);
		String row = scan.nextLine();
		String[] strArray = row.split("\\s+");
		int[] intArray = new int[strArray.length];
		for (int i = 0; i < strArray.length; i++) {
			try {
				intArray[i] = Integer.parseInt(strArray[i]);
			} catch (NumberFormatException nfe) {
			}
		}
		ArrayList<Integer> largestSequence = new ArrayList<Integer>();
		ArrayList<Integer> currentSequence = new ArrayList<Integer>();
		largestSequence.add(intArray[0]);
		currentSequence.add(intArray[0]);
		for (int i = 1; i < intArray.length; i++) {
			if (intArray[i] <= (intArray[i - 1])) {
				for (Integer element : currentSequence) {
					System.out.print(element + " ");
				}
				System.out.println();
				currentSequence.clear();
			}
			currentSequence.add(intArray[i]);
			if (currentSequence.size() > largestSequence.size()) {
				largestSequence = new ArrayList<Integer>(currentSequence);
			}
		}
		for (Integer element : currentSequence) {
			System.out.print(element + " ");
		}
		System.out.println();
		System.out.print("Longest:");
		for (Integer element : largestSequence) {
			System.out.print(element + " ");
		}
		scan.close();
	}
}
