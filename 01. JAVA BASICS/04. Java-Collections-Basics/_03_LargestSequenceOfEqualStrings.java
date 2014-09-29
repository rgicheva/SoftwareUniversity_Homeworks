package Lection4;

import java.util.ArrayList;
import java.util.Scanner;

public class _03_LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		System.out.println("Please enter an array of strings separated by space on one line:");
		Scanner scan = new Scanner(System.in);
		String row = scan.nextLine();
		String[] strArray = row.split("\\s+");
		ArrayList<String> largestSequence = new ArrayList<String>();
		ArrayList<String> currentSequence = new ArrayList<String>();
		largestSequence.add(strArray[0]);
		currentSequence.add(strArray[0]);
		for (int i = 1; i < strArray.length; i++) {
			if (!strArray[i].equals(strArray[i - 1])) {
				currentSequence.clear();
			}
			currentSequence.add(strArray[i]);
			if (currentSequence.size() > largestSequence.size()) {
				largestSequence = new ArrayList<String>(currentSequence);
			}
		}
		for (String element : largestSequence) {
			System.out.printf("%s ", element);
		}
		scan.close();
	}
}
